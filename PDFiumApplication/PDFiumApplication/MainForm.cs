using ApplicationInfo;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PDFiumApplication
{
    public partial class MainForm : Form
    {
        string iniFilePath = Application.UserAppDataPath + @"\MmgPdf.ini";
        PdfViewer pdfViewer;
        public MainForm()
        {
            InitializeComponent();

            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            Controls.Add(pdfViewer);
            InitViewer();
            Disposed += (s, e) => pdfViewer.Document?.Dispose();
        }

        private void InitViewer()
        {
            // Set what is to be displayed to the user
            PDFPermissions p = new PDFPermissions
            {
                MainMenuVisible = true,
                MainToolBarVisible = true,
                MainStatusBarVisible = true,

                OpenEnabled = true,
                SaveEnabled = true,
                PrintEnabled = true,
                DocumentPropertiesEnabled = true,
                EditEnabled = true
            };

            // Here's a little function pointer to update the title bar
            Action<string> setDocumentName = (name) => this.Text = name + " - MMG PDF Reader";
            pdfViewer.Init(p, setDocumentName);

            // Here we read the initialization data
            IniFile iniFile;
            if (File.Exists(this.iniFilePath))
            {
                StreamReader xmlStream = new StreamReader(this.iniFilePath);
                XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
                iniFile = (IniFile)serializer.Deserialize(xmlStream);
                xmlStream.Close();
            }
            else
            {
                iniFile = new IniFile();
            }
            pdfViewer.IniFile = iniFile;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IniFile iniFile = this.pdfViewer.IniFile;

            // Here we write the initialization data
            StreamWriter xmlStream = new StreamWriter(this.iniFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
            serializer.Serialize(xmlStream, iniFile);
            xmlStream.Close();
        }
    }
}

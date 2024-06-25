###### [<img src="flag-br.png" alt="Portugu&ecirc;s">](readme-pt.md)
# Just Another PDF Reader

By [Marco Aurélio Oliveira](https://maurelio.com.br)

Modified from https://github.com/pvginkel/PdfiumViewer, by [Pieter van Ginkel](https://github.com/pvginkel)

This project isn't anything special. I just wanted a FAST AND SIMPLE PDF READER, which is not easy to find nowadays. So, I modified van Ginkel's project and added a few things I wanted, plus tweaked the user interface to my taste.

Feel free to make it look however you want.

**Additionally**, I moved almost all the main application code into the DLL, making the component pretty much complete for inclusion in other applications. The programmer only needs to follow a few steps and write a few lines of code to get the component working.

## Let's dive into our "Hello World"
1. On Visual Studio, create a new Windows Forms project;
2. Choose a pair of `pdfium.dll` and `PDFiumMMG.dll` files, as you wish;
>*Remember, they can be "Release" or "Debug", and 32-bit or 64-bit.*
3. Add `pdfium.dll` to the project by right-clicking on the project name in the `Solution Explorer` and selecting `Add > Existing Item`.
>*The file will be copied to the project root folder. This is the easiest way to get Visual Studio to copy it to the same folder as the executable when the application is built.*
4. In the `Solution Explorer`, select `pdfium.dll`;
>*The `Properties` window will display the file properties.*
5. Set the `Copy to Output Directory` property to `Copy always`;
6. In the `Solution Explorer`, right-click `References` or `Dependencies` and select `Add > Reference`;
7. In the `Reference Manager` window, click the `Browse` button and find the `PDFiumMMG.dll` file and select it.

Done! The project is now ready to run the PDF Reader with just a few more lines of code, as shown below:

```
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
    }

    private void InitViewer()
    {
        // Set the options to be displayed to the user
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
        Action<string> setDocumentName = (name) => this.Text = name + " - MMG PDF Viewer";
        pdfViewer.Init(p, setDocumentName);

        
        // Here we read the initialization data
        IniFile iniFile;
        if (File.Exists(this.iniFilePath))
        {
            StreamReader xmlStream = new StreamReader(this.iniFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
            iniFile = (IniFile)serializer.Deserialize(xmlStream);
        }
        else
        {
            iniFile = new IniFile();
        }
        pdfViewer.IniFile = iniFile;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        
        // Here we write the initialization data
        IniFile iniFile = this.pdfViewer.IniFile;

        StreamWriter xmlStream = new StreamWriter(this.iniFilePath);
        XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
        serializer.Serialize(xmlStream, iniFile);
    }
}
```

>*Save the initialization file in whatever format you prefer. In this example, I used XML because I didn't want to include more DLLs in the project to use JSON.*
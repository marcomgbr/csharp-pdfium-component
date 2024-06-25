using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer
{
    public class PDFPermissions
    {
        public bool MainMenuVisible { get; set; }
        public bool MainToolBarVisible { get; set; }
        public bool MainStatusBarVisible { get; set; }

        public bool OpenEnabled { get; set; }
        public bool SaveEnabled { get; set; }
        public bool PrintEnabled { get; set; }
        public bool DocumentPropertiesEnabled { get; set; }
        public bool EditEnabled { get; set; }
    }
}

using System.Collections.Generic;
using System.IO;

namespace ApplicationInfo
{
    public class IniFile
    {

        MMG.Utils.RotationStack<string> filePaths;
        public MMG.Utils.RotationStack<string> FilePaths
        {
            get
            {
                return this.filePaths;
            }
            set
            {
                this.filePaths = value;
            }
        }

        public IniFile()
        {
            Init(10);
        }

        public IniFile(int maxFileCount)
        {
            Init(maxFileCount);
        }

        private void Init(int maxFileCount)
        {
            this.filePaths = new MMG.Utils.RotationStack<string>(maxFileCount);
        }
    }
}

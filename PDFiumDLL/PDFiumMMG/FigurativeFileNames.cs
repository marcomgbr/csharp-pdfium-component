using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfiumViewer
{
    public static class FigurativeFileNames
    {
        /// <summary>
        /// Generates a decorative name for display purposes only. 
        /// If the string is longer than <code>maxStringLength</code>, truncates parts of the name.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GenerateTruncatedNames(string filePath, int maxStringLength)
        {
            string fullPath = System.IO.Path.GetFullPath(filePath);
            string name = System.IO.Path.GetFileName(fullPath);
            string rootPath = System.IO.Path.GetPathRoot(fullPath);
            string figurativeName;
            //int maxFigurativePart = 

            // space is needed to display the name twice, plus the rootPath,
            // plus "..." (three dots), plus about 20 characters of directory name
            // for the figurative name to make sense
            int nameOnBeginningAndOnPathLength = 2 * name.Length;
            string[] delimiters = { " (", "...", ")" };
            const int DELIMITERS_CHAR_COUNT = 6;
            const int ROOT_PATH_LENGTH = 3;
            const int MIN_PATH_CHARS_LENGTH = 20;
            int minLength = nameOnBeginningAndOnPathLength + DELIMITERS_CHAR_COUNT 
                + ROOT_PATH_LENGTH + MIN_PATH_CHARS_LENGTH;

            string pathWithoutRoot = fullPath.Substring(ROOT_PATH_LENGTH);
            if (minLength > maxStringLength)
            {
                figurativeName
                    = name.Length > maxStringLength ? name.Substring(0, maxStringLength) : name;
            }
            else
            {
                int descriptiveElementsLength = name.Length + DELIMITERS_CHAR_COUNT + ROOT_PATH_LENGTH;
                int wantedLength = Math.Max(0, maxStringLength - descriptiveElementsLength);
                int finalLength = Math.Min(wantedLength, pathWithoutRoot.Length);

                if (pathWithoutRoot.Length == finalLength)
                {
                    figurativeName = name + delimiters[0] + rootPath 
                        + pathWithoutRoot.Substring(pathWithoutRoot.Length - finalLength) + delimiters[2];
                }
                else
                {
                    figurativeName = name + delimiters[0] + rootPath + delimiters[1]
                        + pathWithoutRoot.Substring(pathWithoutRoot.Length - finalLength) + delimiters[2];
                }
            }

            return figurativeName;
        }
    }
}

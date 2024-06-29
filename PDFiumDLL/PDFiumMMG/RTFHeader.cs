using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMG.CustomPresentation.RTF
{
    public class RTFHeader
    {
        readonly StringBuilder text = new StringBuilder();

        public RTFPage page;

        public RTFHeader()
        {
            this.page = new RTFPage();

            this.text.Append(@"{\rtf1\ansi\deff0\deftab720 {\fonttbl {\f0\fswiss Helvetica;} {\f1\fmodern Courier;} {\f2\froman Times;}}").Append("\n");
            this.text.Append(@"{\colortbl;\red255\green0\blue0;\red0\green255\blue0;\red0\green0\blue255;").Append("\n");
            this.text.Append(@"\red255\green255\blue0;\red0\green0\blue0;\red255\green255\blue255;").Append("\n");
            this.text.Append(@"\red0\green255\blue255;\red255\green0\blue255;\red250\green128\blue114; }").Append("\n");
        }

        public override string ToString()
        {
            return GetRTFString();
        }

        public string GetRTFString()
        {
            return this.text.ToString() + this.page.ToString();
        }
    }
}

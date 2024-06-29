using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMG.CustomPresentation.RTF
{
    public class RTFBuilder
    {
        readonly StringBuilder text = new StringBuilder();
        private Func<string, DialogResult> showMessage;

        private int linksCharsCount = 0;

        public RTFHeader header;
        //public RTFTable table;

        public RTFBuilder()
        {
            this.header = new RTFHeader();
            //this.table = new RTFTable();
        }

        public RTFBuilder(Func<string, DialogResult> showMessage)
        {
            this.showMessage = showMessage;
            this.header = new RTFHeader();
        }

        #region ==================== FONT TYPES ====================

        /// <summary>
        /// Start font Helvetica.
        /// </summary>
        public RTFBuilder fhelvetica
        {
            get
            {
                this.text.Append(@"\f0");
                return this;
            }
        }

        /// <summary>
        /// Start font Courier.
        /// </summary>
        public RTFBuilder fcourier
        {
            get
            {
                this.text.Append(@"\f1");
                return this;
            }
        }

        /// <summary>
        /// Start font Times.
        /// </summary>
        public RTFBuilder ftimes
        {
            get
            {
                this.text.Append(@"\f2");
                return this;
            }
        }
        #endregion ===================================

        #region ==================== FONT STYLES ====================

        /// <summary>
        /// Begin font size (in points).
        /// </summary>
        public RTFBuilder fsize(int i)
        {
            this.text.Append(@"{\fs").Append((i * 2).ToString());
            return this;
        }

        /// <summary>
        /// End font size.
        /// </summary>
        public RTFBuilder efsize
        {
            get
            {
                this.text.Append(@"}");
                return this;
            }
        }

        /// <summary>
        /// Begin italics format.
        /// </summary>
        public RTFBuilder i
        {
            get
            {
                this.text.Append(@"\i1");
                return this;
            }
        }

        /// <summary>
        /// End italics format.
        /// </summary>
        public RTFBuilder ei
        {
            get
            {
                this.text.Append(@"\i0");
                return this;
            }
        }

        /// <summary>
        /// Begin bold text.
        /// </summary>
        public RTFBuilder b
        {
            get
            {
                this.text.Append(@"\b1");
                return this;
            }
        }

        /// <summary>
        /// End bold text.
        /// </summary>
        public RTFBuilder eb
        {
            get
            {
                this.text.Append(@"\b0");
                return this;
            }
        }

        /// <summary>
        /// Begin small caps.
        /// </summary>
        public RTFBuilder scaps
        {
            get
            {
                this.text.Append(@"\scaps1");
                return this;
            }
        }

        /// <summary>
        /// End small caps.
        /// </summary>
        public RTFBuilder escaps
        {
            get
            {
                this.text.Append(@"\scaps0");
                return this;
            }
        }

        /// <summary>
        /// Begin all caps.
        /// </summary>
        public RTFBuilder caps
        {
            get
            {
                this.text.Append(@"\caps1");
                return this;
            }
        }

        /// <summary>
        /// End all caps.
        /// </summary>
        public RTFBuilder ecaps
        {
            get
            {
                this.text.Append(@"\caps0");
                return this;
            }
        }

        /// <summary>
        /// Strike through.
        /// </summary>
        public RTFBuilder strike
        {
            get
            {
                this.text.Append(@"\strike1");
                return this;
            }
        }

        /// <summary>
        /// End strike through.
        /// </summary>
        public RTFBuilder estrike
        {
            get
            {
                this.text.Append(@"\strike0");
                return this;
            }
        }

        /// <summary>
        /// Begin outline.
        /// </summary>
        public RTFBuilder outl
        {
            get
            {
                this.text.Append(@"\outl1");
                return this;
            }
        }

        /// <summary>
        /// End outline.
        /// </summary>
        public RTFBuilder eoutl
        {
            get
            {
                this.text.Append(@"\outl0");
                return this;
            }
        }

        /// <summary>
        /// Begin underline.
        /// </summary>
        public RTFBuilder u
        {
            get
            {
                this.text.Append(@"\ul1");
                return this;
            }
        }

        /// <summary>
        /// End underline.
        /// </summary>
        public RTFBuilder eu
        {
            get
            {
                this.text.Append(@"\ul0");
                return this;
            }
        }

        /// <summary>
        /// Begin double underline.
        /// </summary>
        public RTFBuilder udbl
        {
            get
            {
                this.text.Append(@"\uldb1");
                return this;
            }
        }

        /// <summary>
        /// End double underline.
        /// </summary>
        public RTFBuilder eudbl
        {
            get
            {
                this.text.Append(@"\uldb0");
                return this;
            }
        }

        /// <summary>
        /// Begin thick underline.
        /// </summary>
        public RTFBuilder uth
        {
            get
            {
                this.text.Append(@"\ulth1");
                return this;
            }
        }

        /// <summary>
        /// End thick underline.
        /// </summary>
        public RTFBuilder euth
        {
            get
            {
                this.text.Append(@"\ulth0");
                return this;
            }
        }

        /// <summary>
        /// Begin underline words only.
        /// </summary>
        public RTFBuilder uw
        {
            get
            {
                this.text.Append(@"\ulw1");
                return this;
            }
        }

        /// <summary>
        /// End underline words only.
        /// </summary>
        public RTFBuilder euw
        {
            get
            {
                this.text.Append(@"\ulw0");
                return this;
            }
        }

        /// <summary>
        /// Begin wave underline.
        /// </summary>
        public RTFBuilder uwave
        {
            get
            {
                this.text.Append(@"\ulwave1");
                return this;
            }
        }

        /// <summary>
        /// End wave underline.
        /// </summary>
        public RTFBuilder euwave
        {
            get
            {
                this.text.Append(@"\ulwave0");
                return this;
            }
        }

        /// <summary>
        /// Begin dotted underline.
        /// </summary>
        public RTFBuilder ud
        {
            get
            {
                this.text.Append(@"\uld1");
                return this;
            }
        }

        /// <summary>
        /// End dotted underline.
        /// </summary>
        public RTFBuilder eud
        {
            get
            {
                this.text.Append(@"\uld0");
                return this;
            }
        }

        /// <summary>
        /// Begin dash underline.
        /// </summary>
        public RTFBuilder udash
        {
            get
            {
                this.text.Append(@"\uldash1");
                return this;
            }
        }

        /// <summary>
        /// End dash underline.
        /// </summary>
        public RTFBuilder eudash
        {
            get
            {
                this.text.Append(@"\uldash0");
                return this;
            }
        }

        /// <summary>
        /// Begin dash dot underline.
        /// </summary>
        public RTFBuilder udashd
        {
            get
            {
                this.text.Append(@"\uldashd1");
                return this;
            }
        }

        /// <summary>
        /// End dash dot underline.
        /// </summary>
        public RTFBuilder eudashd
        {
            get
            {
                this.text.Append(@"\uldashd0");
                return this;
            }
        }

        #endregion ===================================

        #region ==================== FONT COLORS ====================

        /// <summary>
        /// Font color default begins.
        /// </summary>
        public RTFBuilder defaultcolor
        {
            get
            {
                this.text.Append(@"\cf1");
                return this;
            }
        }

        /// <summary>
        /// Font color Red begins.
        /// </summary>
        public RTFBuilder red
        {
            get
            {
                this.text.Append(@"\cf1");
                return this;
            }
        }

        /// <summary>
        /// Font color Green begins.
        /// </summary>
        public RTFBuilder green
        {
            get
            {
                this.text.Append(@"\cf2");
                return this;
            }
        }

        /// <summary>
        /// Font color Blue begins.
        /// </summary>
        public RTFBuilder blue
        {
            get
            {
                this.text.Append(@"\cf3");
                return this;
            }
        }

        /// <summary>
        /// Font color Yellow begins.
        /// </summary>
        public RTFBuilder yellow
        {
            get
            {
                this.text.Append(@"\cf4");
                return this;
            }
        }

        /// <summary>
        /// Font color Black begins.
        /// </summary>
        public RTFBuilder black
        {
            get
            {
                this.text.Append(@"\cf5");
                return this;
            }
        }

        /// <summary>
        /// Font color White begins.
        /// </summary>
        public RTFBuilder white
        {
            get
            {
                this.text.Append(@"\cf6");
                return this;
            }
        }

        /// <summary>
        /// Font color Cyan begins.
        /// </summary>
        public RTFBuilder cyan
        {
            get
            {
                this.text.Append(@"\cf7");
                return this;
            }
        }

        /// <summary>
        /// Font color magenta begins.
        /// </summary>
        public RTFBuilder magenta
        {
            get
            {
                this.text.Append(@"\cf8");
                return this;
            }
        }

        /// <summary>
        /// Font color salmon begins.
        /// </summary>
        public RTFBuilder salmon
        {
            get
            {
                this.text.Append(@"\cf9");
                return this;
            }
        }

        #endregion ===================================

        #region ==================== TEXT FLOW ====================

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder p
        {
            get
            {
                this.text.Append("\n").Append(@"{\pard");
                this.text.Append("\n");

                return this;
            }
        }

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder pf(TEXTAlign a)
        {
            return pf(a, 0);
        }

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder pf(int fontSize)
        {
            return pf(TEXTAlign.NONE, fontSize);
        }

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder pf(TEXTAlign a, int fontSize)
        {
            this.text.Append("\n").Append(@"{\pard").Append(a);

            if (fontSize > 0)
            {
                this.text.Append(@"\fs").Append(fontSize * 2);
            }

            this.text.Append("\n");

            return this;
        }

        /// <summary>
        /// End of paragraph.
        /// </summary>
        public RTFBuilder ep
        {
            get
            {
                this.text.Append(@"\sb150\par}").Append("\n");
                return this;
            }
        }

        /// <summary>
        /// Add text to document body. Inserts a space at the end.
        /// </summary>
        public RTFBuilder t(string text)
        {
            this.text.Append(text).Append(" ");
            return this;
        }

        /// <summary>
        /// Add text to document body. Trim the text.
        /// </summary>
        public RTFBuilder ttrim(string text)
        {
            this.text.Append(text.Trim());
            return this;
        }

        /// <summary>
        /// Add text to document body. Trim the start of text.
        /// </summary>
        public RTFBuilder ttrims(string text)
        {
            this.text.Append(text.TrimStart());
            return this;
        }

        /// <summary>
        /// Add text to document body. Trim the end of text.
        /// </summary>
        public RTFBuilder ttrime(string text)
        {
            this.text.Append(text.TrimEnd());
            return this;
        }

        /// <summary>
        /// Format the text as software code.
        /// </summary>
        public RTFBuilder code(string text)
        {
            this.text.Append(@"{\f1 ").Append(text.TrimEnd()).Append(@" }");
            return this;
        }

        /// <summary>
        /// Insert a tab to text.
        /// </summary>
        public RTFBuilder tab
        {
            get
            {
                this.text.Append(@"\tab ");
                return this;
            }
        }

        /// <summary>
        /// An HTML like line break.
        /// </summary>
        public RTFBuilder br
        {
            get
            {
                this.text.Append(@"\line").Append("\n");
                return this;
            }
        }

        /// <summary>
        /// Page break.
        /// </summary>
        public RTFBuilder pgbr
        {
            get
            {
                this.text.Append(@"\page").Append("\n");
                return this;
            }
        }

        #endregion ===================================

        #region ==================== LIST ==================== 
        /// <summary>
        /// Open an unordered list./>
        /// </summary>
        public RTFBuilder ul
        {
            get
            {
                this.text.Append("\n").Append(@"\par{\pard{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}\fi-360\li720\sb150\sl276\slmult1").Append("\n");
                return this;
            }
        }

        /// <summary>
        /// Start a paragraph in an unordered list./>
        /// </summary>
        public RTFBuilder li
        {
            get
            {
                this.text.Append(@"{\pntext\'B7}");
                return this;
            }
        }

        /// <summary>
        /// Ends a paragraph in an unordered list./>
        /// </summary>
        public RTFBuilder eli
        {
            get
            {
                this.text.Append(@"\par");
                return this;
            }
        }

        /// <summary>
        /// Close an unordered list./>
        /// </summary>
        public RTFBuilder eul
        {
            get
            {
                this.text.Append("\n").Append(@"}");
                return this;
            }
        }

        #endregion ===================================

        #region ==================== TABLE ==================== 

        string rowHeader;

        /// <summary>
        /// Starts a table, defining where the columns start. These settings are kept
        /// until a new table is closed by calling <code>tablee()</code>.
        /// </summary>
        /// <param name = "b" > Border style</param>
        /// <param name = "startofcolumns_mm" > Distance between the left margin and the beginning
        /// of the column, in milimeters</param>
        public RTFBuilder table(TRAlignVertical a, TABLEBorderStyle b, params int[] startofcolumns_mm)
        {
            this.rowHeader = "";
            foreach (var item in startofcolumns_mm)
            {
                if (b != TABLEBorderStyle.NONE)
                {
                    this.rowHeader += @"\clbrdrt" + b
                        + @"\clbrdrl" + b
                        + @"\clbrdrb" + b
                        + @"\clbrdrr" + b;
                }

                int width = (int)Math.Round(item * MeasurementConstants.TWIPS_PER_MILIMETER);
                this.rowHeader += a + @"\cellx" + width;
            }

            // starts an enclosed paragraph for this table
            this.text.Append(@"{\pard").Append("\n");

            return this;
        }

        /// <summary>
        /// Ends a table.
        /// </summary>
        public RTFBuilder etable
        {
            get
            {
                this.text.Append(@"}").Append("\n");
                return this;
            }
        }

        /// <summary>
        /// Starts a table row.
        /// </summary>
        public RTFBuilder tr
        {
            get
            {
                this.text.Append(@"\trowd\trgaph180 ").Append("\n").Append(this.rowHeader).Append("\n");
                return this;
            }
        }

        /// <summary>
        /// Ends a table row.
        /// </summary>
        public RTFBuilder etr
        {
            get
            {
                this.text.Append(@"\row").Append("\n");
                return this;
            }
        }

        /// <summary>
        /// Starts a table cell.
        /// </summary>
        public RTFBuilder td
        {
            get
            {
                return tdf(TEXTAlign.NONE);
            }
        }

        /// <summary>
        /// Starts a table cell.
        /// </summary>
        public RTFBuilder tdf(TEXTAlign a)
        {
            this.text.Append(@"\pard\intbl").Append(a);
            return this;
        }

        /// <summary>
        /// Ends a table cell.
        /// </summary>
        public RTFBuilder etd
        {
            get
            {
                this.text.Append(@"\cell");
                return this;
            }
        }

        #endregion ===================================


        /// <summary>
        /// Do nothing. Only ends a partial command block.
        /// </summary>
        public void pack()
        {
        }

        /// <summary>
        /// A hard line break just to format text source code.
        /// </summary>
        public RTFBuilder hardbreak()
        {
            this.text.Append("\n");
            return this;
        }

        /// <summary>
        /// Create an hyperlink.
        /// </summary>
        public RTFBuilder href(string url, string caption)
        {
            this.text.Append("{\\field{\\*\\fldinst HYPERLINK \"").Append(url)
                .Append("\"}{\\fldrslt {\\ul ").Append(caption).Append(@"}}}");

            // A workaround due to a richtextbox bug
            this.linksCharsCount += 2 * url.Length;

            return this;
        }

        public override string ToString()
        {
            return GetRTFString();
        }

        public string GetRTFString()
        {
            return this.header.GetRTFString() + this.text.ToString() + "}";
        }

        public DialogResult Show()
        {
            if (this.showMessage != null)
            {
                // A workaround due to a richtextbox bug
                this.text.Append("".PadRight(this.linksCharsCount));
                
                return this.showMessage(GetRTFString());
            }
            else
            {
                Console.WriteLine(GetRTFString());
            }

            return DialogResult.Cancel;
        }
    }
}

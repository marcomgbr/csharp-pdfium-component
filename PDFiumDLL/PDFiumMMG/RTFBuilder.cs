using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MMG.CustomPresentation.RTF
{
    public class RTFBuilder
    {
        readonly StringBuilder text = new StringBuilder();

        public RTFHeader header;
        //public RTFTable table;

        public RTFBuilder()
        {
            this.header = new RTFHeader();
            //this.table = new RTFTable();
        }

        #region ==================== FONT TYPES ====================
        
        /// <summary>
        /// Start font Helvetica.
        /// </summary>
        public RTFBuilder fhelvetica()
        {
            this.text.Append(@"\f0");
            return this;
        }

        /// <summary>
        /// Start font Courier.
        /// </summary>
        public RTFBuilder fcourier()
        {
            this.text.Append(@"\f1");
            return this;
        }

        /// <summary>
        /// Start font Times.
        /// </summary>
        public RTFBuilder ftimes()
        {
            this.text.Append(@"\f2");
            return this;
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
        public RTFBuilder _fsize()
        {
            this.text.Append(@"}");
            return this;
        }

        /// <summary>
        /// Begin italics format.
        /// </summary>
        public RTFBuilder i()
        {
            this.text.Append(@"\i1");
            return this;
        }

        /// <summary>
        /// End italics format.
        /// </summary>
        public RTFBuilder _i()
        {
            this.text.Append(@"\i0");
            return this;
        }

        /// <summary>
        /// Begin bold text.
        /// </summary>
        public RTFBuilder b()
        {
            this.text.Append(@"\b1");
            return this;
        }

        /// <summary>
        /// End bold text.
        /// </summary>
        public RTFBuilder _b()
        {
            this.text.Append(@"\b0");
            return this;
        }

        /// <summary>
        /// Begin small caps.
        /// </summary>
        public RTFBuilder scaps()
        {
            this.text.Append(@"\scaps1");
            return this;
        }

        /// <summary>
        /// End small caps.
        /// </summary>
        public RTFBuilder _scaps()
        {
            this.text.Append(@"\scaps0");
            return this;
        }

        /// <summary>
        /// Begin all caps.
        /// </summary>
        public RTFBuilder caps()
        {
            this.text.Append(@"\caps1");
            return this;
        }

        /// <summary>
        /// End all caps.
        /// </summary>
        public RTFBuilder _caps()
        {
            this.text.Append(@"\caps0");
            return this;
        }

        /// <summary>
        /// Strike through.
        /// </summary>
        public RTFBuilder strike()
        {
            this.text.Append(@"\strike1");
            return this;
        }

        /// <summary>
        /// End strike through.
        /// </summary>
        public RTFBuilder _strike()
        {
            this.text.Append(@"\strike0");
            return this;
        }

        /// <summary>
        /// Begin outline.
        /// </summary>
        public RTFBuilder outl()
        {
            this.text.Append(@"\outl1");
            return this;
        }

        /// <summary>
        /// End outline.
        /// </summary>
        public RTFBuilder _outl()
        {
            this.text.Append(@"\outl0");
            return this;
        }

        /// <summary>
        /// Begin underline.
        /// </summary>
        public RTFBuilder u()
        {
            this.text.Append(@"\ul1");
            return this;
        }

        /// <summary>
        /// End underline.
        /// </summary>
        public RTFBuilder _u()
        {
            this.text.Append(@"\ul0");
            return this;
        }

        /// <summary>
        /// Begin double underline.
        /// </summary>
        public RTFBuilder udbl()
        {
            this.text.Append(@"\uldb1");
            return this;
        }

        /// <summary>
        /// End double underline.
        /// </summary>
        public RTFBuilder _udbl()
        {
            this.text.Append(@"\uldb0");
            return this;
        }

        /// <summary>
        /// Begin thick underline.
        /// </summary>
        public RTFBuilder uth()
        {
            this.text.Append(@"\ulth1");
            return this;
        }

        /// <summary>
        /// End thick underline.
        /// </summary>
        public RTFBuilder _uth()
        {
            this.text.Append(@"\ulth0");
            return this;
        }

        /// <summary>
        /// Begin underline words only.
        /// </summary>
        public RTFBuilder uw()
        {
            this.text.Append(@"\ulw1");
            return this;
        }

        /// <summary>
        /// End underline words only.
        /// </summary>
        public RTFBuilder _uw()
        {
            this.text.Append(@"\ulw0");
            return this;
        }

        /// <summary>
        /// Begin wave underline.
        /// </summary>
        public RTFBuilder uwave()
        {
            this.text.Append(@"\ulwave1");
            return this;
        }

        /// <summary>
        /// End wave underline.
        /// </summary>
        public RTFBuilder _uwave()
        {
            this.text.Append(@"\ulwave0");
            return this;
        }

        /// <summary>
        /// Begin dotted underline.
        /// </summary>
        public RTFBuilder ud()
        {
            this.text.Append(@"\uld1");
            return this;
        }

        /// <summary>
        /// End dotted underline.
        /// </summary>
        public RTFBuilder _ud()
        {
            this.text.Append(@"\uld0");
            return this;
        }

        /// <summary>
        /// Begin dash underline.
        /// </summary>
        public RTFBuilder udash()
        {
            this.text.Append(@"\uldash1");
            return this;
        }

        /// <summary>
        /// End dash underline.
        /// </summary>
        public RTFBuilder _udash()
        {
            this.text.Append(@"\uldash0");
            return this;
        }

        /// <summary>
        /// Begin dash dot underline.
        /// </summary>
        public RTFBuilder udashd()
        {
            this.text.Append(@"\uldashd1");
            return this;
        }

        /// <summary>
        /// End dash dot underline.
        /// </summary>
        public RTFBuilder _udashd()
        {
            this.text.Append(@"\uldashd0");
            return this;
        }

        #endregion ===================================

        #region ==================== FONT COLORS ====================

        /// <summary>
        /// Font color Red begins.
        /// </summary>
        public RTFBuilder red()
        {
            this.text.Append(@"\cf1");
            return this;
        }

        /// <summary>
        /// Font color Green begins.
        /// </summary>
        public RTFBuilder green()
        {
            this.text.Append(@"\cf2");
            return this;
        }

        /// <summary>
        /// Font color Blue begins.
        /// </summary>
        public RTFBuilder blue()
        {
            this.text.Append(@"\cf3");
            return this;
        }

        /// <summary>
        /// Font color Yellow begins.
        /// </summary>
        public RTFBuilder yellow()
        {
            this.text.Append(@"\cf4");
            return this;
        }

        /// <summary>
        /// Font color Black begins.
        /// </summary>
        public RTFBuilder black()
        {
            this.text.Append(@"\cf5");
            return this;
        }

        /// <summary>
        /// Font color White begins.
        /// </summary>
        public RTFBuilder white()
        {
            this.text.Append(@"\cf6");
            return this;
        }

        #endregion ===================================

        #region ==================== TEXT FLOW ====================

        /// <summary>
        /// Add text to document body.
        /// </summary>
        public RTFBuilder t(string text)
        {
            this.text.Append(text);
            return this;
        }

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder p()
        {
            return p(TEXTAlign.NONE, 0);
        }

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder p(TEXTAlign a)
        {
            return p(a, 0);
        }

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder p(int fontSize)
        {
            return p(TEXTAlign.NONE, fontSize);
        }

        /// <summary>
        /// Begins a paragraph.
        /// </summary>
        public RTFBuilder p(TEXTAlign a, int fontSize)
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
        public RTFBuilder _p()
        {
            this.text.Append(@"\sb150\par}").Append("\n");
            return this;
        }

        /// <summary>
        /// Insert a tab to text.
        /// </summary>
        public RTFBuilder tab()
        {
            this.text.Append(@"\tab ");
            return this;
        }

        /// <summary>
        /// An HTML like line break.
        /// </summary>
        public RTFBuilder br()
        {
            this.text.Append(@"\line").Append("\n");
            return this;
        }

        /// <summary>
        /// Page break.
        /// </summary>
        public RTFBuilder pgbr()
        {
            this.text.Append(@"\page").Append("\n");
            return this;
        }

        #endregion ===================================

        #region ==================== LIST ==================== 
        /// <summary>
        /// Open an unordered list./>
        /// </summary>
        public RTFBuilder ul()
        {
            this.text.Append("\n").Append(@"\par{\pard{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}\fi-360\li720\sb150\sl276\slmult1").Append("\n");
            return this;
        }

        /// <summary>
        /// Start a paragraph in an unordered list./>
        /// </summary>
        public RTFBuilder li()
        {
            this.text.Append(@"{\pntext\'B7}");
            return this;
        }

        /// <summary>
        /// Ends a paragraph in an unordered list./>
        /// </summary>
        public RTFBuilder _li()
        {
            this.text.Append(@"\par");
            return this;
        }

        /// <summary>
        /// Close an unordered list./>
        /// </summary>
        public RTFBuilder _ul()
        {
            this.text.Append("\n").Append(@"}");
            return this;
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
        public RTFBuilder _table()
        {
            this.text.Append(@"}").Append("\n");
            return this;
        }

        /// <summary>
        /// Starts a table row.
        /// </summary>
        public RTFBuilder tr()
        {
            this.text.Append(@"\trowd\trgaph180 ").Append("\n").Append(this.rowHeader).Append("\n");
            return this;
        }

        /// <summary>
        /// Ends a table row.
        /// </summary>
        public RTFBuilder _tr()
        {
            this.text.Append(@"\row").Append("\n");
            return this;
        }

        /// <summary>
        /// Starts a table cell.
        /// </summary>
        public RTFBuilder td()
        {
            return td(TEXTAlign.NONE);
        }

        /// <summary>
        /// Starts a table cell.
        /// </summary>
        public RTFBuilder td(TEXTAlign a)
        {
            this.text.Append(@"\pard\intbl").Append(a);
            return this;
        }

        /// <summary>
        /// Ends a table cell.
        /// </summary>
        public RTFBuilder _td()
        {
            this.text.Append(@"\cell");
            return this;
        }

        #endregion ===================================

        /// <summary>
        /// A hard line break just to format text source code.
        /// </summary>
        public RTFBuilder hardbr()
        {
            this.text.Append("\n");
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
    }
}

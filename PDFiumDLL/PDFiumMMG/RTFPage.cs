using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMG.CustomPresentation.RTF
{
    public class RTFPage
    {
        
        readonly StringBuilder text = new StringBuilder();

        public RTFPage()
        {
        }

        public RTFPage landscape()
        {
            this.text.Append(@"\landscape");
            return this;
        }

        public RTFPage portrait()
        {
            this.text.Append(@"\portrait");
            return this;
        }

        public RTFPage width_mm(double w)
        {
            int twips = (int)Math.Round(w * MeasurementConstants.TWIPS_PER_MILIMETER);
            this.text.Append(@"\paperw").Append(twips.ToString());
            return this;
        }

        public RTFPage height_mm(double h)
        {
            int twips = (int)Math.Round(h * MeasurementConstants.TWIPS_PER_MILIMETER);
            this.text.Append(@"\paperh").Append(twips.ToString());
            return this;
        }

        public RTFPage leftmargin_mm(double m)
        {
            int twips = (int)Math.Round(m * MeasurementConstants.TWIPS_PER_MILIMETER);
            this.text.Append(@"\margl").Append(twips.ToString());
            return this;
        }

        public RTFPage rightmargin_mm(double m)
        {
            int twips = (int)Math.Round(m * MeasurementConstants.TWIPS_PER_MILIMETER);
            this.text.Append(@"\margr").Append(twips.ToString());
            return this;
        }

        public RTFPage topmargin_mm(double m)
        {
            int twips = (int)Math.Round(m * MeasurementConstants.TWIPS_PER_MILIMETER);
            this.text.Append(@"\margt").Append(twips.ToString());
            return this;
        }

        public RTFPage bottommargin_mm(double m)
        {
            int twips = (int)Math.Round(m * MeasurementConstants.TWIPS_PER_MILIMETER);
            this.text.Append(@"\margb").Append(twips.ToString());
            return this;
        }

        /// <summary>
        /// Define each point where text starts after a "tab" tag is placed into the text body.
        /// </summary>
        public RTFPage tabstop_mm(double t)
        {
            int twips = (int)Math.Round(t * MeasurementConstants.TWIPS_PER_MILIMETER);
            this.text.Append(@"\tx").Append(twips.ToString());
            return this;
        }

        public override string ToString()
        {
            return GetRTFString();
        }

        public string GetRTFString()
        {
            return this.text.ToString();
        }
    }
}

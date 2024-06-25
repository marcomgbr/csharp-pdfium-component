using MMG.Utils;

namespace MMG.CustomPresentation.RTF
{
    public static class MeasurementConstants
    {
        public static readonly double TWIPS_PER_MILIMETER = 56.69291339;
    }

    public class TABLEBorderStyle : ConstantOfTypeString
    {
        private TABLEBorderStyle(string value) : base(value) {}

        public static readonly TABLEBorderStyle NONE = new TABLEBorderStyle(@"");
        public static readonly TABLEBorderStyle SIMPLE = new TABLEBorderStyle(@"\brdrw15\brdrs ");
        public static readonly TABLEBorderStyle DOTTED = new TABLEBorderStyle(@"\brdrw15\brdrdot");
        public static readonly TABLEBorderStyle DASHED = new TABLEBorderStyle(@"\brdrw15\brdrdash");
        public static readonly TABLEBorderStyle DOUBLE = new TABLEBorderStyle(@"\brdrw15\brdrdb");
    }

    public class TRAlignVertical : ConstantOfTypeString
    {
        private TRAlignVertical(string value) : base(value) { }

        public static readonly TRAlignVertical NONE = new TRAlignVertical(@"");
        public static readonly TRAlignVertical TOP = new TRAlignVertical(@"\clvertalt");
        public static readonly TRAlignVertical CENTER = new TRAlignVertical(@"\clvertalc");
        public static readonly TRAlignVertical BOTTOM = new TRAlignVertical(@"\clvertalb");
    }

    public class TEXTAlign : ConstantOfTypeString
    {
        private TEXTAlign(string value) : base(value) { }

        public static readonly TEXTAlign NONE = new TEXTAlign(@" ");
        public static readonly TEXTAlign LEFT = new TEXTAlign(@"\ql ");
        public static readonly TEXTAlign CENTER = new TEXTAlign(@"\qc ");
        public static readonly TEXTAlign RIGHT = new TEXTAlign(@"\qr ");
        public static readonly TEXTAlign JUSTIFY = new TEXTAlign(@"\qJ ");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMG.Utils
{
    /// <summary>
    /// A class to be inherited to create string constants like enums.
    /// </summary>
    public abstract class ConstantOfTypeString : IEquatable<ConstantOfTypeString>
    {
        private readonly string _value;

        public string Value { get { return _value; } }

        protected ConstantOfTypeString(string value)
        {
            _value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is ConstantOfTypeString p && Equals(p);
        }

        public override int GetHashCode()
        {
            return -1;
        }

        public bool Equals(ConstantOfTypeString other)
        {
            return _value == other._value;
        }

        public static bool operator ==(ConstantOfTypeString left, ConstantOfTypeString right) => Equals(left, right);

        public static bool operator !=(ConstantOfTypeString left, ConstantOfTypeString right) => !Equals(left, right);

        public static explicit operator string(ConstantOfTypeString value) => value.ToString();

        public override string ToString() => _value;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace KomdiagnostikaTest.UI.MarkupExtentions
{
    public class EnumValues : MarkupExtension
    {
        private readonly Type _enumType;

        public EnumValues(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");
            if (!enumType.IsEnum)
                throw new NotSupportedException(string.Format("{0} is not enum type", _enumType.FullName));
            _enumType = enumType;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _enumType.GetEnumValues();
        }
    }
}

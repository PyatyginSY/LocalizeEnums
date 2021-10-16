using System;
using System.Windows.Markup;

namespace LocalizeEnums.Extensions
{
    public class EnumBindingExtensions : MarkupExtension
    {
        public Type EnumType { get; private set; }

        public EnumBindingExtensions(Type enumType)
        {
            if (enumType is null || !enumType.IsEnum)
                throw new NullReferenceException($"{nameof(enumType)} must be of type Enum and must be not null.");
            EnumType = enumType;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}

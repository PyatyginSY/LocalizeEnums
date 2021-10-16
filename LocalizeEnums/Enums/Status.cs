using LocalizeEnums.Converter;
using LocalizeEnums.Extensions;
using LocalizeEnums.Properties;
using System.ComponentModel;

namespace LocalizeEnums.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {
        [Description("Описание1")]
        Horrible,
        [Description("Описание2")]
        Bad,
        SoSo,
        [DescriptionAttributeExtensions("Good", typeof(Resources))]
        Good,
        [DescriptionAttributeExtensions("Better", typeof(Resources))]
        Better,
        [DescriptionAttributeExtensions("Best", typeof(Resources))]
        Best
    }
}

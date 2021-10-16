using LocalizeEnums.Properties;
using System;
using System.ComponentModel;
using System.Resources;

namespace LocalizeEnums.Extensions
{
    public class DescriptionAttributeExtensions : DescriptionAttribute
    {
        ResourceManager _resourceManager;
        private readonly string _resourceKey;
        public DescriptionAttributeExtensions(string resourceKey, Type type )
        {
            _resourceManager = new ResourceManager(type);
            _resourceKey = resourceKey;
        }

        public override string Description
        {
            get 
            {
                string description = _resourceManager.GetString(_resourceKey);
                return string.IsNullOrWhiteSpace(description) ? $"[[{_resourceKey}]]" : description;
            }
        }
    }
}

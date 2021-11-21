// <copyright file="DescriptionAttributeExtensions.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using System;
using System.ComponentModel;
using System.Resources;

namespace LocalizeEnums.Extensions
{
    /// <summary>
    /// DescriptionAttributeExtensions.
    /// </summary>
    public class DescriptionAttributeExtensions : DescriptionAttribute
    {
        private readonly string _resourceKey;
        private readonly ResourceManager _resourceManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionAttributeExtensions"/> class.
        /// </summary>
        /// <param name="resourceKey">resourceKey.</param>
        /// <param name="type">type.</param>
        public DescriptionAttributeExtensions(string resourceKey, Type type)
        {
            _resourceManager = new ResourceManager(type);
            _resourceKey = resourceKey;
        }

        /// <inheritdoc/>
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

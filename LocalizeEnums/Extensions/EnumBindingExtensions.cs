// <copyright file="EnumBindingExtensions.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using System;
using System.Windows.Markup;

namespace LocalizeEnums.Extensions
{
    /// <summary>
    /// EnumBindingExtensions.
    /// </summary>
    public class EnumBindingExtensions : MarkupExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumBindingExtensions"/> class.
        /// </summary>
        /// <param name="enumType">enumType.</param>
        public EnumBindingExtensions(Type enumType)
        {
            if (enumType is null || !enumType.IsEnum)
            {
                throw new NullReferenceException($"{nameof(enumType)} must be of type Enum and must be not null.");
            }

            EnumType = enumType;
        }

        /// <summary>
        /// Gets.
        /// </summary>
        public Type EnumType { get; private set; }

        /// <inheritdoc/>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}

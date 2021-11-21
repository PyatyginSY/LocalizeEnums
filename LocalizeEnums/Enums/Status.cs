// <copyright file="Status.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using LocalizeEnums.Converter;
using LocalizeEnums.Extensions;
using LocalizeEnums.Properties;
using System.ComponentModel;

namespace LocalizeEnums.Enums
{
    /// <summary>
    /// Status.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {
        /// <summary>
        /// Horrible.
        /// </summary>
        [Description("Описание1")]
        Horrible,

        /// <summary>
        /// Bad.
        /// </summary>
        [Description("Описание2")]
        Bad,

        /// <summary>
        /// SoSo.
        /// </summary>
        SoSo,

        /// <summary>
        /// Good.
        /// </summary>
        [DescriptionAttributeExtensions("Good", typeof(Resources))]
        Good,

        /// <summary>
        /// Better.
        /// </summary>
        [DescriptionAttributeExtensions("Better", typeof(Resources))]
        Better,

        /// <summary>
        /// Best.
        /// </summary>
        [DescriptionAttributeExtensions("Best", typeof(Resources))]
        Best,
    }
}

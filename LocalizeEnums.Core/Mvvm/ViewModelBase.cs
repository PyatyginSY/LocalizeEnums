// <copyright file="ViewModelBase.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using Prism.Mvvm;
using Prism.Navigation;

namespace LocalizeEnums.Core.Mvvm
{
    /// <summary>
    /// ViewModelBase.
    /// </summary>
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase"/> class.
        /// </summary>
        protected ViewModelBase()
        {
        }

        /// <inheritdoc/>
        public virtual void Destroy()
        {
        }
    }
}

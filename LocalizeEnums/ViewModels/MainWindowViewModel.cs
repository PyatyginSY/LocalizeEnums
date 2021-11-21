// <copyright file="MainWindowViewModel.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using Prism.Mvvm;

namespace LocalizeEnums.ViewModels
{
    /// <summary>
    /// MainWindowViewModel.
    /// </summary>
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
        }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}

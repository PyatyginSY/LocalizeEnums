// <copyright file="MessageService.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using LocalizeEnums.Services.Interfaces;

namespace LocalizeEnums.Services
{
    /// <summary>
    /// MessageService.
    /// </summary>
    public class MessageService : IMessageService
    {
        /// <inheritdoc/>
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}

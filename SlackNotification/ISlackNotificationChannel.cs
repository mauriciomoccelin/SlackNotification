﻿using System.Threading.Tasks;

namespace SlackNotification
{
    public interface ISlackNotificationChannel
    {
        void Register(string token, string channel);
        Task SendNotificationAsync(string userName, string text);
    }
}

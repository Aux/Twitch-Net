﻿using System;
using System.Threading.Tasks;

namespace NTwitch.Chat
{
    public partial class TwitchChatClient
    {
        private readonly AsyncEvent<Func<LogMessage, Task>> _logEvent = new AsyncEvent<Func<LogMessage, Task>>();
        public event Func<LogMessage, Task> Log
        {
            add { _logEvent.Add(value); }
            remove { _logEvent.Remove(value); }
        }
    }
}

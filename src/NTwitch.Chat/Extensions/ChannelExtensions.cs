﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace NTwitch.Chat
{
    public static class ChannelExtensions
    {
        // Channels
        public static async Task JoinAsync(this ISimpleChannel channel, RequestOptions options = null)
        {
            var client = channel.Client as TwitchChatClient;
            if (client == null)
                return;

            await client.ApiClient.JoinChannelAsync(channel.Name, options).ConfigureAwait(false);
        }

        public static async Task LeaveAsync(this ISimpleChannel channel, RequestOptions options = null)
        {
            var client = channel.Client as TwitchChatClient;
            if (client == null)
                return;

            await client.ApiClient.LeaveChannelAsync(channel.Name, options).ConfigureAwait(false);
        }

        public static async Task HostAsync(this ISimpleChannel channel, RequestOptions options = null)
        {
            var client = channel.Client as TwitchChatClient;
            if (client == null)
                return;

            await client.ApiClient.HostChannelAsync(client.TokenInfo.Username, channel.Name, options);
        }

        // Messages
        public static async Task SendMessageAsync(this ISimpleChannel channel, string content, RequestOptions options = null)
        {
            var client = channel.Client as TwitchChatClient;
            if (client == null)
                return;

            await ChatChannelHelper.SendMessageAsync(client, channel, content, options).ConfigureAwait(false);
        }
    }
}

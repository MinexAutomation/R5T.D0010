﻿using System;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010
{
    public static class IMessageSinkExtensions
    {
        public static Task AddErrorMessageAsync(this IMessageSink messageSink, DateTime timestampUtc, string errorMessage)
        {
            var message = Message.NewError(timestampUtc, errorMessage);

            var task = messageSink.AddMessageAsync(message);
            return task;
        }

        public static Task AddOutputMessageAsync(this IMessageSink messageSink, DateTime timestampUtc, string outputMessage)
        {
            var message = Message.NewOutput(timestampUtc, outputMessage);

            var task = messageSink.AddMessageAsync(message);
            return task;
        }
    }
}

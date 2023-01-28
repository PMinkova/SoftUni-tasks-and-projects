using System;
using System.Collections.Generic;

namespace Exam.Discord
{
    using System.Linq;

    public class Discord : IDiscord
    {
        private Dictionary<string, Message> messagesById;
        private Dictionary<string, List<Message>> messagesByChannel;   

        public Discord()
        {
            this.messagesById = new Dictionary<string, Message>();
            this.messagesByChannel = new Dictionary<string, List<Message>>();
        }

        public int Count => this.messagesById.Count;

        public bool Contains(Message message)
        {
            return this.messagesById.ContainsKey(message.Id);
        }

        public void DeleteMessage(string messageId)
        {
            if (!this.messagesById.ContainsKey(messageId))
            {
                throw new ArgumentException();
            }

            var message = this.messagesById[messageId];

            this.messagesById.Remove(messageId);
            this.messagesByChannel[message.Channel].Remove(message);
        }

        public IEnumerable<Message> GetAllMessagesOrderedByCountOfReactionsThenByTimestampThenByLengthOfContent()
        {
            return this.messagesById.Values
                .OrderByDescending(m => m.Reactions.Count)
                .ThenBy(m => m.Timestamp)
                .ThenBy(m => m.Content.Length);
        }

        public IEnumerable<Message> GetChannelMessages(string channel)
        {
            var channelMessages = this.messagesById.Values.Where(m => m.Channel == channel).ToList();

            if (channelMessages.Count == 0)
            {
                throw new ArgumentException();
            }

            return channelMessages;
        }

        public Message GetMessage(string messageId)
        {
            if (!this.messagesById.ContainsKey(messageId))
            {
                throw new ArgumentException();
            }

            return this.messagesById[messageId];
        }

        public IEnumerable<Message> GetMessageInTimeRange(int lowerBound, int upperBound)
        {
            return this.messagesById.Values
                .Where(m => m.Timestamp >= lowerBound && m.Timestamp <= upperBound)
                .OrderByDescending(m => messagesByChannel[m.Channel].Count);
        }

        public IEnumerable<Message> GetMessagesByReactions(List<string> reactions)
        {
            return this.messagesById.Values
                .Where(m => reactions.All(r => m.Reactions.Contains(r)))
                .OrderByDescending(m => m.Reactions.Count)
                .ThenBy(m => m.Timestamp);
        }

        public IEnumerable<Message> GetTop3MostReactedMessages()
        {
            return this.messagesById.Values
                .OrderByDescending(m => m.Reactions.Count)
                .Take(3);
        }

        public void ReactToMessage(string messageId, string reaction)
        {
            if (!this.messagesById.ContainsKey(messageId))
            {
                throw new ArgumentException();
            }

            this.messagesById[messageId].Reactions.Add(reaction);
        }

        public void SendMessage(Message message)
        {
            if (!this.messagesByChannel.ContainsKey(message.Channel))
            {
                this.messagesByChannel.Add(message.Channel, new List<Message>());
            }

            this.messagesByChannel[message.Channel].Add(message);
            this.messagesById.Add(message.Id, message);
        }
    }
}

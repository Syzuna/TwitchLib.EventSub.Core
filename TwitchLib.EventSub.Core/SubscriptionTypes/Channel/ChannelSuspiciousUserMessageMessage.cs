using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

public sealed class SuspiciousUserMessage
{
    /// <summary>
    /// The UUID that identifies the message.
    /// </summary>
    public string MessageId { get; set; } = string.Empty;
    /// <summary>
    /// The chat message in plain text.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    /// <summary>
    /// Ordered list of chat message fragments.
    /// </summary>
    public MessageFragment[] Fragments { get; set; } = [];

    public sealed class MessageFragment
    {
        /// <summary>
        /// The type of message fragment. Possible values: -text -cheermote -emote
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// Message text in fragment.
        /// </summary>
        public string Text { get; set; } = string.Empty;
        /// <summary>
        /// Optional. Metadata pertaining to the cheermote.
        /// </summary>
        public FragmentCheermote Cheermote = new FragmentCheermote();
        /// <summary>
        /// Optional. Metadata pertaining to the emote.
        /// </summary>
        public FragmentEmote Emote { get; set; } = new FragmentEmote();

        public sealed class FragmentCheermote
        {
            /// <summary>
            /// The name portion of the Cheermote string that you use in chat to cheer Bits. The full Cheermote string is the concatenation of {prefix} + {number of Bits}.
            ///
            /// For example, if the prefix is “Cheer” and you want to cheer 100 Bits, the full Cheermote string is Cheer100.When the Cheermote string is entered in chat, Twitch converts it to the image associated with the Bits tier that was cheered.
            /// </summary>
            public string Prefix { get; set; } = string.Empty;
            /// <summary>
            /// The amount of bits cheered.
            /// </summary>
            public int Bits { get; set; } = 0;
            /// <summary>
            /// The tier level of the cheermote.
            /// </summary>
            public int Tier { get; set; } = 0;
        }

        public sealed class FragmentEmote
        {
            /// <summary>
            /// An ID that uniquely identifies this emote.
            /// </summary>
            public string Id { get; set; } = string.Empty;
            /// <summary>
            /// An ID that identifies the emote set that the emote belongs to.
            /// </summary>
            public string EmoteSetId { get; set; } = string.Empty;
        }
    }
}

namespace TwitchLib.EventSub.Core.Models.GuestStar
{
    public abstract class ChannelGuestStarBase
    {
        /// <summary>
        /// The broadcaster user ID
        /// </summary>
        public string BroadcasterUserId { get; set; } = string.Empty;
        /// <summary>
        /// The broadcaster display name
        /// </summary>
        public string BroadcasterUserName { get; set; } = string.Empty;
        /// <summary>
        /// The broadcaster login
        /// </summary>
        public string BroadcasterUserLogin { get; set; } = string.Empty;
        /// <summary>
        /// Unique ID representing the session.
        /// </summary>
        public string SessionId { get; set; } = string.Empty;
        /// <summary>
        /// The moderator user ID
        /// </summary>
        public string ModeratorUserId { get; set; } = string.Empty;
        /// <summary>
        /// The moderator display name
        /// </summary>
        public string ModeratorUserName { get; set; } = string.Empty;
        /// <summary>
        /// The moderator login
        /// </summary>
        public string ModeratorUserLogin { get; set; } = string.Empty;
        /// <summary>
        /// The user ID of the guest
        /// </summary>
        public string GuestStarUserId { get; set; } = string.Empty;
        /// <summary>
        /// The guest display name
        /// </summary>
        public string GuestStarUserName { get; set; } = string.Empty;
        /// <summary>
        /// The guest login
        /// </summary>
        public string GuestStarUserLogin { get; set; } = string.Empty;
        /// <summary>
        /// The ID of the slot assignment the guest is assigned to. null/empty if the guest is in the INVITED state.
        /// <para>or the ID of the slot where settings were updated.</para>
        /// </summary>
        public string SlotId { get; set; } = string.Empty;
    }
}
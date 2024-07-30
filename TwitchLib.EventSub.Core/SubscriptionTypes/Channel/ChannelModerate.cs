using System.Reflection;
using TwitchLib.EventSub.Core.Models.Moderate;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// <see href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate-v2">Twitch Documentation</see><br/>
/// When a moderator performs a moderation action in a channel.<br/>
/// Required Scopes: Check documenation for full list<br/>
/// </summary>
public sealed class ChannelModerate
{
	/// <summary>
	///The ID of the broadcaster.
	/// </summary>
	public string BroadcasterUserId { get; set; } = string.Empty;
	/// <summary>
	/// The user name of the broadcaster.
	/// </summary>
	public string BroadcasterUserName { get; set; } = string.Empty;
	/// <summary>
	///The login of the broadcaster. (Lowercase)
	/// </summary>
	public string BroadcasterUserLogin { get; set; } = string.Empty;
	///<summary>
	///The ID of the moderator who performed the action.
	///</summary>
	public string ModeratorUserId { get; set; } = string.Empty;
	///<summary>
	///The login of the moderator. (Lowercase)
	///</summary>
	public string ModeratorUserLogin { get; set; } = string.Empty;
	///<summary>
	///The user name of the moderator.
	///</summary>
	public string ModeratorUserName { get; set; } = string.Empty;
	///<summary>
	///The action performed.
	///</summary>
	public string Action { get; set; } = string.Empty;
	///<summary>
	///Optional. Metadata associated with the followers command.
	///</summary>
	public Followers? Followers { get; set; }
	///<summary>
	///Optional. Metadata associated with the slow command.
	///</summary>
	public Slow? Slow { get; set; }
	///<summary>
	///Optional. Metadata associated with the vip command.
	///</summary>
	public Vip? Vip { get; set; }
	///<summary>
	///Optional. Metadata associated with the vip command.
	///</summary>
	public Vip? Unvip { get; set; }
	///<summary>
	///Optional. Metadata associated with the mod command.
	///</summary>
	public Moderator? Mod { get; set; }
	///<summary>
	///Optional. Metadata associated with the unmod command.
	///</summary>
	public Moderator? Unmod { get; set; }
	///<summary>
	///Optional. Metadata associated with the ban command.
	///</summary>
	public Ban? Ban { get; set; }
	///<summary>
	///Optional. Metadata associated with the unban command.
	///</summary>
	public Unban? Unban { get; set; }
	///<summary>
	///Optional. Metadata associated with the timeout command.
	///</summary>
	public Timeout? Timeout { get; set; }
	///<summary>
	///Optional. Metadata associated with the untimeout command.
	///</summary>
	public Untimeout? Untimeout { get; set; }
	///<summary>
	///Optional. Metadata associated with the raid command.
	///</summary>
	public Raid? Raid { get; set; }
	///<summary>
	///Optional. Metadata associated with the unraid command.
	///</summary>
	public Unraid? Unraid { get; set; }
	///<summary>
	///Optional. Metadata associated with the delete command.
	///</summary>
	public Delete? Delete { get; set; }
	///<summary>
	///Optional. Metadata associated with the automod terms changes.
	///</summary>
	public AutomodTerms? AutomodTerms { get; set; }
	///<summary>
	///Optional. Metadata associated with an unban request.
	///</summary>
	public UnbanRequest? UnbanRequest { get; set; }
	///<summary>
	///Optional. Metadata associated with the warn command.
	///</summary>
	public Warn? Warn { get; set; }
}
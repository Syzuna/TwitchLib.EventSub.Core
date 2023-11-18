namespace TwitchLib.EventSub.Core.Models.Chat;

/// <summary>
/// Information about the pay it forward event. Null if notice_type is not pay_it_forward.
/// </summary>
public sealed class ChatPayItForward
{
    /// <summary>
    /// Whether the gift was given anonymously.
    /// </summary>
    public bool GifterIsAnonymous { get; set; }
    /// <summary>
    /// Optional. The user ID of the user who gifted the subscription. Null if anonymous.
    /// </summary>
    public string? GifterUserId { get; set; }
    /// <summary>
    /// Optional. The user name of the user who gifted the subscription. Null if anonymous.
    /// </summary>
    public string? GifterUserName { get; set; }
    /// <summary>
    /// Optional. The user login of the user who gifted the subscription. Null if anonymous.
    /// </summary>
    public string? GifterUserLogin { get; set; }
}
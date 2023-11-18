using TwitchLib.EventSub.Core.Models.Charity;

namespace TwitchLib.EventSub.Core.Models.Chat;

/// <summary>
/// Information about the charity donation event. Null if notice_type is not charity_donation.
/// </summary>
public sealed class ChatCharityDonation
{
    /// <summary>
    /// Name of the charity.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    public CharityAmount Amount { get; set; } = new();
}
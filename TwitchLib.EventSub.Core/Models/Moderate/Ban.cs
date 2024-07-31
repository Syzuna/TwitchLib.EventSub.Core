using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.EventSub.Core.Models.Moderate;

///<summary>
///Metadata associated with the ban command.
///</summary>
public class Ban
{
	///<summary>
	///The ID of the user being banned.
	///</summary>
	public string UserId { get; set; } = string.Empty;
	///<summary>
	///The login of the user being banned.
	///</summary>
	public string UserLogin { get; set; } = string.Empty;
	///<summary>
	///The user name of the user being banned.
	///</summary>
	public string UserName { get; set; } = string.Empty;
	///<summary>
	///Optional. Reason given for the ban.
	///</summary>
	public string Reason { get; set; } = string.Empty;
}

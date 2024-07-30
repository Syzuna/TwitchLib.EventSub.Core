using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.EventSub.Core.Models.Moderate;

///<summary>
///Metadata associated with the unban command.
///</summary>
public class Unban
{
	///<summary>
	///The ID of the user being unbanned.
	///</summary>
	public string UserId { get; set; } = string.Empty;
	///<summary>
	///The login of the user being unbanned.
	///</summary>
	public string UserLogin { get; set; } = string.Empty;
	///<summary>
	///The user name of the user being unbanned.
	///</summary>
	public string UserName { get; set; } = string.Empty;
}

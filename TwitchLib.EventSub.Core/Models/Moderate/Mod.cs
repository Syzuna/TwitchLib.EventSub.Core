using System;
using System.Collections.Generic;
using System.Text;
namespace TwitchLib.EventSub.Core.Models.Moderate;

///<summary>
///Optional. Metadata associated with the mod command.
///</summary>
public class Moderator
{
	///<summary>
	///The ID of the user gaining or losing mod status.
	///</summary>
	public string UserId { get; set; } = string.Empty;
	///<summary>
	///The login of the user gaining or losing mod status.
	///</summary>
	public string UserLogin { get; set; } = string.Empty;
	///<summary>
	///The user name of the user gaining or losing mod status.
	///</summary>
	public string UserName { get; set; } = string.Empty;
}
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.EventSub.Core.Models.Moderate;

///<summary>
///Metadata associated with the warn command.
///</summary>
public class Warn
{
	///<summary>
	///The ID of the user being warned.
	///</summary>
	public string UserId { get; set; } = string.Empty;
	///<summary>
	///The login of the user being warned.
	///</summary>
	public string UserLogin { get; set; } = string.Empty;
	///<summary>
	///The user name of the user being warned.
	///</summary>
	public string UserName { get; set; } = string.Empty;
	///<summary>
	///Optional. Reason given for the warning.
	///</summary>
	public string? Reason { get; set; } = string.Empty;
	///<summary>
	///Optional. Chat rules cited for the warning.
	///</summary>
	public string[] ChatRulesCited { get; set; } = Array.Empty<string>();
}

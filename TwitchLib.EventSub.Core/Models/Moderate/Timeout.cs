using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.EventSub.Core.Models.Moderate;

///<summary>
///Metadata associated with the timeout command.
///</summary>
public class Timeout
{    
	//<summary>
	///The ID of the user being timed out.
	///</summary>
	public string UserId { get; set; } = string.Empty;
	///<summary>
	///The login of the user being timed out.
	///</summary>
	public string UserLogin { get; set; } = string.Empty;
	///<summary>
	///The user name of the user being timed out.
	///</summary>
	public string UserName { get; set; } = string.Empty;
	///<summary>
	///Optional. The reason given for the timeout.
	///</summary>
	public string Reason { get; set; } = string.Empty;
	///<summary>
	///The time at which the timeout ends.</br>
	///(Converted to DateTimeOffset)
	///</summary>
	public DateTimeOffset ExpiresAt { get; set; } = DateTimeOffset.MinValue;
}

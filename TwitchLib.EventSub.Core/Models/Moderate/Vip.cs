using System;
using System.Collections.Generic;
using System.Text;
namespace TwitchLib.EventSub.Core.Models.Moderate;

///<summary>
///Metadata associated with the vip command.
///</summary>
public class Vip
{
	///<summary>
	///The ID of the user gaining or losing VIP status.
	///</summary>
	public string UserId { get; set; } = string.Empty;
	///<summary>
	///The login of the user gaining or losing VIP status.
	///</summary>
	public string UserLogin { get; set; } = string.Empty;
	///<summary>
	///The user name of the user gaining or losing VIP status.
	///</summary>
	public string UserName { get; set; } = string.Empty;
}
using System;
using System.Collections.Generic;
using System.Text;
namespace TwitchLib.EventSub.Core.Models.Moderate;

///<summary>
///Metadata associated with the slow command.
///</summary>
public class Slow
{
	///<summary>
	///The amount of time, in seconds, that users need to wait between sending messages.
	///</summary>
	public int WaitTimeSeconds { get; set; }
}

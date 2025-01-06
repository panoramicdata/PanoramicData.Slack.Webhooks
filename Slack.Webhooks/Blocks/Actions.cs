using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Blocks;

/// <summary>
/// A block that is used to hold interactive <see cref="IActionElement"/>s.
/// </summary>
public class Actions() : Block(BlockType.Actions)
{
	/// <summary>
	/// An array of interactive element objects - <see cref="Elements.Button"/>, <see cref="Elements.Select"/> menus, <see cref="Elements.Overflow"/> menus, or <see cref="Elements.DatePicker"/>. 
	/// There is a maximum of 5 elements in each action block.
	/// </summary>
	/// <seealso cref="IActionElement"/>
	/// <seealso cref="Elements.Button"/>
	/// <seealso cref="Elements.SelectUsers"/>
	/// <seealso cref="Elements.SelectChannels"/>
	/// <seealso cref="Elements.SelectConversations"/>
	/// <seealso cref="Elements.SelectStatic"/>
	/// <seealso cref="Elements.SelectExternal"/>
	/// <seealso cref="Elements.Overflow"/>
	/// <seealso cref="Elements.DatePicker"/>
	public IList<IActionElement>? Elements { get; set; }
}
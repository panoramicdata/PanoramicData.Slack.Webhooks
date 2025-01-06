using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This multi-select menu will populate its options with a list of public and private channels, DMs, and MPIMs visible to the current user in the active workspace.
/// </summary>
public class MultiSelectConversations() : Select(ElementType.MultiSelectConversations), IInputElement
{
	/// <summary>
	/// An array of one or more IDs of any valid conversations to be pre-selected when the menu loads.
	/// </summary>
	public IList<string>? InitialConversations { get; set; }
}

using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This multi-select menu will populate its options with a list of public channels visible to the current user in the active workspace.
/// </summary>
public class MultiSelectChannels() : Select(ElementType.MultiSelectChannels), IInputElement
{
	/// <summary>
	/// An array of one or more IDs of any valid public channel to be pre-selected when the menu loads.
	/// </summary>
	public IList<string>? InitialChannels { get; set; }
}
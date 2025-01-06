using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This multi-select menu will populate its options with a list of Slack users visible to the current user in the active workspace.
/// </summary>
public class MultiSelectUsers() : Select(ElementType.MultiSelectUsers), IInputElement
{
	/// <summary>
	/// An array of user IDs of any valid users to be pre-selected when the menu loads.
	/// </summary>
	public IList<string>? InitialUsers { get; set; }
}

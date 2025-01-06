using PanoramicData.Slack.Webhooks.Interfaces;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/>, <see cref="Blocks.Actions"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This select menu will populate its options with a list of public channels visible to the current user in the active workspace.
/// </summary>
public class SelectChannels() : Select(ElementType.SelectChannels), IActionElement, IInputElement
{
	/// <summary>
	/// The ID of any valid public channel to be pre-selected when the menu loads.
	/// </summary>
	public string? InitialChannel { get; set; }
}
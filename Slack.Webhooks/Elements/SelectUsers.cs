using PanoramicData.Slack.Webhooks.Interfaces;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/>, <see cref="Blocks.Actions"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This select menu will populate its options with a list of Slack users visible to the current user in the active workspace.
/// </summary>
public class SelectUsers() : Select(ElementType.SelectUsers), IActionElement, IInputElement
{
	/// <summary>
	/// The user ID of any valid user to be pre-selected when the menu loads.
	/// </summary>
	public string? InitialUser { get; set; }
}

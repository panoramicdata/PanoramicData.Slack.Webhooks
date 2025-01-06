using PanoramicData.Slack.Webhooks.Interfaces;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/>, <see cref="Blocks.Actions"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This select menu will populate its options with a list of public and private channels, DMs, and MPIMs visible to the current user in the active workspace.
/// </summary>
public class SelectConversations() : Select(ElementType.SelectConversations), IActionElement, IInputElement
{
	/// <summary>
	/// The ID of any valid conversation to be pre-selected when the menu loads.
	/// </summary>
	public string? InitialConversation { get; set; }
}

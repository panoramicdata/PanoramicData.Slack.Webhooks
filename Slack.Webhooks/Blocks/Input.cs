using PanoramicData.Slack.Webhooks.Elements;
using PanoramicData.Slack.Webhooks.Interfaces;

namespace PanoramicData.Slack.Webhooks.Blocks;

/// <summary>
/// A block that collects information from users - it can hold a <see cref="PlainTextInput"/> element, 
/// a <see cref="Select"/> menu element, a multi-select menu element, or a <see cref="DatePicker"/>.
/// 
/// Read our guide to using modals to learn how input blocks pass information to your app.
/// https://api.slack.com/surfaces/modals/using#gathering_input
/// </summary>
/// <seealso cref="IInputElement"/>
/// <seealso cref="PlainTextInput"/>
/// <seealso cref="SelectUsers"/>
/// <seealso cref="SelectChannels"/>
/// <seealso cref="SelectConversations"/>
/// <seealso cref="SelectStatic"/>
/// <seealso cref="SelectExternal"/>
/// <seealso cref="MultiSelectUsers"/>
/// <seealso cref="MultiSelectChannels"/>
/// <seealso cref="MultiSelectConversations"/>
/// <seealso cref="MultiSelectStatic"/>
/// <seealso cref="MultiSelectExternal"/>
/// <seealso cref="DatePicker"/>
public class Input() : Block(BlockType.Input)
{
	/// <summary>
	/// A label that appears above an <see cref="Input"/> element in the form of a <see cref="TextObject"/> that can only be of <see cref="TextObject.TextType.PlainText"/>. 
	/// Maximum length for the text in this field is 2000 characters.
	/// </summary>
	public TextObject? Label { get; set; }

	/// <summary>
	/// An optional hint that appears below an input element in a lighter grey. It must be a <see cref="TextObject"/> that can only be of <see cref="TextObject.TextType.PlainText"/>. 
	/// Maximum length for the text in this field is 2000 characters.
	/// </summary>
	public TextObject? Hint { get; set; }

	/// <summary>
	/// A boolean that indicates whether the input element may be empty when a user submits the modal. Defaults to false.
	/// </summary>
	public bool Optional { get; set; }

	/// <summary>
	/// An <see cref="PlainTextInput"/> element, a <see cref="Select"/> menu element, a multi-select menu element, or a <see cref="DatePicker"/>.
	/// </summary>
	public IInputElement? Element { get; set; }
}
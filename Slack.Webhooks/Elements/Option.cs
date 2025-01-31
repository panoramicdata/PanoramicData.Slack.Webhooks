namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// An object that represents a single selectable item in a <see cref="Select"/> menu, multi-select menu, <see cref="RadioButtons"/> group, or <see cref="Overflow"/> menu.
/// </summary>
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
/// <seealso cref="Overflow"/>
/// <seealso cref="RadioButtons"/>
public class Option
{
	/// <summary>
	/// A <see cref="TextObject.TextType.PlainText"/> only <see cref="TextObject"/> that defines the text shown in the option on the menu. Maximum length for the text in this field is 75 characters.
	/// </summary>
	public TextObject? Text { get; set; }

	/// <summary>
	/// The string value that will be passed to your app when this option is chosen. Maximum length for this field is 75 characters.
	/// </summary>
	public string? Value { get; set; }

	/// <summary>
	/// A URL to load in the user's browser when the option is clicked. The url attribute is only available in <see cref="Overflow"/> menus. 
	/// Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.
	///
	/// https://api.slack.com/interactivity/handling#payloads
	/// https://api.slack.com/interactivity/handling#acknowledgment_response
	/// </summary>
	public string? Url { get; set; }
}
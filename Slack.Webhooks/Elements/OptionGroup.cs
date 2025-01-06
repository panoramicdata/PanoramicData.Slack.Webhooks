using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Provides a way to group options in a <see cref="Select"/>  menu or multi-select menu.
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
public class OptionGroup
{
	/// <summary>
	/// A <see cref="TextObject.TextType.PlainText"/> only <see cref="TextObject"/> that defines the label shown above this group of options.
	/// Maximum length for the <see cref="TextObject.Text"/> in this field is 75 characters.
	/// </summary>
	public TextObject? Label { get; set; }
	/// <summary>
	/// An array of <see cref="Option"/> objects that belong to this specific group. Maximum of 100 items.
	/// </summary>
	public IList<Option>? Options { get; set; }
}
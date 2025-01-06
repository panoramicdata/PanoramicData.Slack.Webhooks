using PanoramicData.Slack.Webhooks.Elements;

namespace PanoramicData.Slack.Webhooks.Blocks;

/// <summary>
/// A <see cref="Header"/> is a plain-text block that displays in a larger, bold font.
/// Use it to delineate between different groups of content in your app's surfaces.
/// </summary>
public class Header() : Block(BlockType.Header)
{
	/// <summary>
	/// The <see cref="Text"/> for the block, in the form of a <see cref="TextObject"/>.
	/// Maximum length for the <c>text</c> in this field is 150 characters.
	/// </summary>
	public TextObject? Text { get; set; }
}

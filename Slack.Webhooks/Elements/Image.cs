using PanoramicData.Slack.Webhooks.Interfaces;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/> and <see cref="Blocks.Context"/> blocks.
/// 
/// An element to insert an image as part of a larger block of content. If you want a block with only an image in it, you're looking for the <see cref="Blocks.Image"/> block.
/// </summary>
public class Image() : Element(ElementType.Image), IContextElement
{
	/// <summary>
	/// The URL of the image to be displayed.
	/// </summary>
	public string? ImageUrl { get; set; }

	/// <summary>
	/// A plain-text summary of the image. This should not contain any markup.
	/// </summary>
	public string? AltText { get; set; }
}
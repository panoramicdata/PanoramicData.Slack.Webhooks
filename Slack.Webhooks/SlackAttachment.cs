﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks;

/// <summary>
/// Slack message attachment. A message can have zero or more attachments.
/// </summary>
public class SlackAttachment
{

	/// <summary>
	/// Required text summary of the attachment that is shown by clients that understand attachments but choose not to show them.
	/// </summary>
	public string? Fallback { get; set; }

	/// <summary>
	/// The provided string will act as a unique identifier for the collection of buttons within the attachment. It will be sent 
	/// back to your message button action URL with each invoked action. This field is required when the attachment contains 
	/// message buttons. It is key to identifying the interaction you're working with.
	/// </summary>
	public string? CallbackId { get; set; }

	/// <summary>
	/// Optional text that should appear within the attachment
	/// </summary>
	public string? Text { get; set; }

	/// <summary>
	/// Optional text that should appear above the formatted data
	/// </summary>
	public string? Pretext { get; set; }

	/// <summary>
	/// Can either be one of 'good', 'warning', 'danger', or any hex color code
	/// </summary>
	public string? Color { get; set; }

	/// <summary>
	/// Small text used to display the author's name.
	/// </summary>
	public string? AuthorName { get; set; }

	/// <summary>
	/// A valid URL that will hyperlink the AuthorName. 
	/// Will only work if author_name is present.
	/// </summary>
	public string? AuthorLink { get; set; }

	/// <summary>
	/// A valid URL that displays a small 16x16px image to the left of the AuthorName.
	/// Will only work if AuthorName is present.
	/// </summary>
	public string? AuthorIcon { get; set; }
	/// <summary>
	/// Optional title, displayed in bold near the top of the message attachment.
	/// </summary>
	public string? Title { get; set; }

	/// <summary>
	/// Optional link applied to the Title if present
	/// </summary>
	public string? TitleLink { get; set; }

	/// <summary>
	/// A valid URL to an image file that will be displayed inside a message attachment.
	/// Currently GIF, JPEG, PNG and BMP formats are supported
	/// </summary>
	public string? ImageUrl { get; set; }

	/// <summary>
	/// A valid URL to an image file that will be displayed as a thumbnail on the right 
	/// side of a message attachment. We currently support the following formats: 
	/// GIF, JPEG, PNG, and BMP.
	/// 
	/// The thumbnail's longest dimension will be scaled down to 75px while maintaining 
	/// the aspect ratio of the image. The file size of the image must also be less than 500 KB.
	/// </summary>
	public string? ThumbUrl { get; set; }

	/// <summary>
	/// Fields are displayed in a table on the message
	/// </summary>
	public List<SlackField>? Fields { get; set; }

	/// <summary>
	/// Optional list of properties where markdown syntax will be parsed
	/// applicable to fields, title, and pretext
	/// </summary>
	[JsonProperty(PropertyName = "mrkdwn_in")]
	public List<string>? MarkdownIn { get; set; }

	/// <summary>
	/// Add some brief text to help contextualize and identify an attachment. Limited to 300 characters, and may be truncated further when displayed to users in environments with limited screen real estate.
	/// </summary>
	public string? Footer { get; set; }
	/// <summary>
	/// To render a small icon beside your footer text, provide a publicly accessible URL string in the footer_icon field. You must also provide a footer for the field to be recognized.
	/// We'll render what you provide at 16px by 16px. It's best to use an image that is similarly sized.
	/// Example: "https://platform.slack-edge.com/img/default_application_icon.png"
	/// </summary>
	public string? FooterIcon { get; set; }

	/// <summary>
	/// Does your attachment relate to something happening at a specific time?
	/// By providing the ts field with an integer value in "epoch time", the attachment will display an additional timestamp value as part of the attachment's footer.
	/// Use ts when referencing articles or happenings. Your message will have its own timestamp when published.
	/// Example: Providing 123456789 would result in a rendered timestamp of Nov 29th, 1973.
	/// </summary>
	[JsonProperty(PropertyName = "ts")]
	public int Timestamp { get; set; }

	/// <summary>
	/// The actions you provide will be rendered as message buttons or menus to users.
	/// </summary>
	public List<SlackAction>? Actions { get; set; }

	/// <summary>
	/// Optional collection of <see cref="Block"/>
	/// </summary>
	/// <seealso cref="Actions" />
	/// <seealso cref="Context" />
	/// <seealso cref="Divider" />
	/// <seealso cref="File" />
	/// <seealso cref="Image" />
	/// <seealso cref="Input" />
	/// <seealso cref="Section" />
	public List<Block>? Blocks { get; set; }

	public bool ShouldSerializeTimestamp() => Timestamp != 0;
}

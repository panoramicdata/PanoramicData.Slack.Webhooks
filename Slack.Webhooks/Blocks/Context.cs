using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Blocks;

/// <summary>
/// Displays message context, which can include both images and text.
/// </summary>
public class Context() : Block(BlockType.Context)
{
	/// <summary>
	/// 	An array of <see cref="Elements.Image"/> elements and <see cref="Elements.TextObject"/>s. Maximum number of items is 10.
	/// </summary>
	public List<IContextElement>? Elements { get; set; }
}
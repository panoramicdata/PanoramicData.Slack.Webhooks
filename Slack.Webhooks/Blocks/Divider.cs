namespace PanoramicData.Slack.Webhooks.Blocks;

/// <summary>
/// A content divider, like an &lt;hr&gt;, to split up different blocks inside of a message.
/// The divider block is nice and neat, requiring only a <see cref="Block.Type"/>.
/// </summary>
public class Divider() : Block(BlockType.Divider)
{
}

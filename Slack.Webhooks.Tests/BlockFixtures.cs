using FluentAssertions;
using PanoramicData.Slack.Webhooks.Blocks;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class BlockFixtures
{
	[Theory]
	[MemberData(nameof(GetData))]
	public void ShouldHaveBlockTypeAndBlockId(Block block, string expectedType, string expectedBlockId)
	{
		// arrange/act
		var payload = SlackClient.SerializeObject(block);

		// assert
		payload.Should().Contain($"\"type\":\"{expectedType}\"");
		payload.Should().Contain($"\"block_id\":\"{expectedBlockId}\"");
	}

	public static TheoryData<Block, string, string> GetData() =>
		new()
		{
			{ new Divider { BlockId = "0001" }, "divider", "0001" },
			{ new Image { BlockId = "0002" }, "image", "0002" },
			{ new Section { BlockId = "0003" }, "section", "0003" },
			{ new Context { BlockId = "0004" }, "context", "0004" },
			{ new File { BlockId = "0005" }, "file", "0005" },
			{ new Actions { BlockId = "0006" }, "actions", "0006" },
			{ new Input { BlockId = "0007" }, "input", "0007" },
			{ new Header { BlockId = "0008" }, "header", "0008" }
		};
}

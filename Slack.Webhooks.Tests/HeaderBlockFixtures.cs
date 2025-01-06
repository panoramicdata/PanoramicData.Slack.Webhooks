using FluentAssertions;
using PanoramicData.Slack.Webhooks.Elements;
using PanoramicData.Slack.Webhooks.Blocks;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class HeaderBlockFixtures
{
	[Fact]
	public void ShouldSerializeText()
	{
		// arrange
		var textObject = new TextObject { Text = "This is text", Type = TextObject.TextType.PlainText };
		var header = new Header { Text = textObject };

		// act
		var textPayload = SlackClient.SerializeObject(textObject);
		var payload = SlackClient.SerializeObject(header);

		// assert
		payload.Should().Contain($"\"text\":{textPayload}");
	}
}

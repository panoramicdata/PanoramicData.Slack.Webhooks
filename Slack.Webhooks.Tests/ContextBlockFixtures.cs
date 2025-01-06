using FluentAssertions;
using PanoramicData.Slack.Webhooks.Blocks;
using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class ContextBlockFixtures
{
	[Fact]
	public void ShouldBeAbleToContainImageElements()
	{
		// arrange
		var context = new Context
		{
			Elements = [new Blocks.Image()]
		};

		// act
		var payload = SlackClient.SerializeObject(context);

		// assert
		payload.Should().Contain("\"elements\":["); // bleeugh
	}

	[Fact]
	public void ShouldBeAbleToContainTextElements()
	{
		// arrange
		var context = new Context
		{
			Elements = [new TextObject()]
		};

		// act
		var payload = SlackClient.SerializeObject(context);

		// assert
		payload.Should().Contain("\"elements\":["); // bleeugh
	}
}
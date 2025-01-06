using FluentAssertions;
using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class SelectExternalElementFixtures
{
	[Fact]
	public void ShouldSerializeMinQueryLength()
	{
		// arrange
		var select = new SelectExternal { MinQueryLength = 5 };

		// act
		var payload = SlackClient.SerializeObject(select);

		// assert
		payload.Should().Contain($"\"min_query_length\":5");
	}

	[Fact]
	public void ShouldSerializeInitialOption()
	{
		// arrange
		var option = new Option { Value = "Value123" };
		var select = new SelectExternal { InitialOption = option };

		// act
		var optionsPayload = SlackClient.SerializeObject(option);
		var payload = SlackClient.SerializeObject(select);

		// assert
		payload.Should().Contain($"\"initial_option\":{optionsPayload}");
	}
}
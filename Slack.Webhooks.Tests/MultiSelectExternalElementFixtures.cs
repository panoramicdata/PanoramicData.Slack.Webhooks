using System.Collections.Generic;
using FluentAssertions;
using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class MultiSelectExternalElementFixtures
{
	[Fact]
	public void ShouldSerializeMinQueryLength()
	{
		// arrange
		var select = new MultiSelectExternal { MinQueryLength = 5 };

		// act
		var payload = SlackClient.SerializeObject(select);

		// assert
		payload.Should().Contain($"\"min_query_length\":5");
	}

	[Fact]
	public void ShouldSerializeInitialOptions()
	{
		// arrange
		var options = new List<Option> { new Option { Value = "Value123" } };
		var select = new MultiSelectExternal { InitialOptions = options };

		// act
		var optionsPayload = SlackClient.SerializeObject(options);
		var payload = SlackClient.SerializeObject(select);

		// assert
		payload.Should().Contain($"\"initial_options\":{optionsPayload}");
	}
}
using System.Collections.Generic;
using FluentAssertions;
using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class OverflowElementFixtures
{
	[Fact]
	public void ShouldSerializeType()
	{
		// arrange
		var overflow = new Overflow();

		// act
		var payload = SlackClient.SerializeObject(overflow);

		// assert
		payload.Should().Contain("\"type\":\"overflow\"");
	}


	[Fact]
	public void ShouldSerializeActionId()
	{
		// arrange
		var overflow = new Overflow { ActionId = "Action123" };

		// act
		var payload = SlackClient.SerializeObject(overflow);

		// assert
		payload.Should().Contain("\"action_id\":\"Action123\"");
	}


	[Fact]
	public void ShouldSerializeConfirm()
	{
		// arrange
		var confirm = new Confirmation();
		var overflow = new Overflow { Confirm = confirm };

		// act
		var confirmPayload = SlackClient.SerializeObject(confirm);
		var payload = SlackClient.SerializeObject(overflow);

		// assert
		payload.Should().Contain($"\"confirm\":{confirmPayload}");
	}

	[Fact]
	public void ShouldSerializeOptions()
	{
		// arrange
		var options = new List<Option> { new Option { Value = "Value123" } };
		var overflow = new Overflow { Options = options };

		// act
		var optionsPayload = SlackClient.SerializeObject(options);
		var payload = SlackClient.SerializeObject(overflow);

		// assert
		payload.Should().Contain($"\"options\":{optionsPayload}");
	}

}
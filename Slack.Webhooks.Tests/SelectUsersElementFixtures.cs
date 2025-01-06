using FluentAssertions;
using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class SelectUsersElementFixtures
{
	[Fact]
	public void ShouldSerializeInitialUser()
	{
		// arrange
		var option = "User321";
		var select = new SelectUsers { InitialUser = option };

		// act
		var optionsPayload = SlackClient.SerializeObject(option);
		var payload = SlackClient.SerializeObject(select);

		// assert
		payload.Should().Contain($"\"initial_user\":{optionsPayload}");
	}
}

public class SelectConversationsElementFixtures
{
	[Fact]
	public void ShouldSerializeInitialConversation()
	{
		// arrange
		var option = "Convo321";
		var select = new SelectConversations { InitialConversation = option };

		// act
		var optionsPayload = SlackClient.SerializeObject(option);
		var payload = SlackClient.SerializeObject(select);

		// assert
		payload.Should().Contain($"\"initial_conversation\":{optionsPayload}");
	}
}

public class SelectChannelsElementFixtures
{
	[Fact]
	public void ShouldSerializeInitialChannel()
	{
		// arrange
		var option = "Convo321";
		var select = new SelectChannels { InitialChannel = option };

		// act
		var optionsPayload = SlackClient.SerializeObject(option);
		var payload = SlackClient.SerializeObject(select);

		// assert
		payload.Should().Contain($"\"initial_channel\":{optionsPayload}");
	}
}
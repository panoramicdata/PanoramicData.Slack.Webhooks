using FluentAssertions;
using PanoramicData.Slack.Webhooks.Blocks;
using PanoramicData.Slack.Webhooks.Elements;
using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class ActionsBlockFixtures
{
	[Fact]
	public void ShouldSerializeActionElements()
	{
		// arrange 
		var elementList = new List<IActionElement>
			{
				new Button(),
				new SelectChannels(),
				new SelectConversations(),
				new SelectExternal(),
				new SelectStatic(),
				new SelectUsers(),
				new Overflow(),
				new DatePicker()
			};
		var actions = new Actions { Elements = elementList };

		// act
		var elementListPayload = SlackClient.SerializeObject(elementList);
		var payload = SlackClient.SerializeObject(actions);

		// assert
		payload.Should().Contain($"\"elements\":{elementListPayload}");
	}
}
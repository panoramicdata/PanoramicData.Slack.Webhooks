using System.Collections.Generic;
using FluentAssertions;
using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class ElementFixtures
{
	[Theory]
	[MemberData(nameof(GetData))]
	public void ShouldHaveBlockTypeAndBlockId(Element element, string expectedType)
	{
		// arrange/act
		var payload = SlackClient.SerializeObject(element);

		// assert
		payload.Should().Contain($"\"type\":\"{expectedType}\"");
	}

	public static IEnumerable<object[]> GetData() =>
			[
				[new Button(), "button"],
				[new DatePicker(), "datepicker"],
				[new Image(), "image"],
				[new MultiSelectChannels(), "multi_channels_select"],
				[new MultiSelectConversations(), "multi_conversations_select"],
				[new MultiSelectExternal(), "multi_external_select"],
				[new MultiSelectStatic(), "multi_static_select"],
				[new MultiSelectUsers(), "multi_users_select"],
				[new Overflow(), "overflow"],
				[new PlainTextInput(), "plain_text_input"],
				[new RadioButtons(), "radio_buttons"],
				[new SelectChannels(), "channels_select"],
				[new SelectConversations(), "conversations_select"],
				[new SelectExternal(), "external_select"],
				[new SelectStatic(), "static_select"],
				[new SelectUsers(), "users_select"]
			];
}
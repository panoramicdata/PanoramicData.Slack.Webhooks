using System.Collections.Generic;
using FluentAssertions;
using PanoramicData.Slack.Webhooks.Interfaces;
using PanoramicData.Slack.Webhooks.Blocks;
using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class InputBlockFixtures
{
	[Fact]
	public void ShouldSerializeLabel()
	{
		// arrange
		var textObject = new TextObject { Text = "Test label" };
		var input = new Input { Label = textObject };

		// act
		var textPayload = SlackClient.SerializeObject(textObject);
		var payload = SlackClient.SerializeObject(input);

		// assert
		payload.Should().Contain($"\"label\":{textPayload}");
	}

	[Fact]
	public void ShouldSerializeHint()
	{
		// arrange
		var textObject = new TextObject { Text = "Test hint" };
		var input = new Input { Hint = textObject };

		// act
		var textPayload = SlackClient.SerializeObject(textObject);
		var payload = SlackClient.SerializeObject(input);

		// assert
		payload.Should().Contain($"\"hint\":{textPayload}");
	}

	[Fact]
	public void ShouldSerializeOptional()
	{
		// arrange
		var input = new Input { Optional = true };

		// act
		var payload = SlackClient.SerializeObject(input);

		// assert
		payload.Should().Contain("\"optional\":true");
	}

	[Theory]
	[MemberData(nameof(GetInputElementData))]
	public void ShouldSerializeInputElementTypes(object element)
	{
		// arrange
		var input = new Input { Element = (IInputElement)element };

		// act
		var elementPayload = SlackClient.SerializeObject(element);
		var payload = SlackClient.SerializeObject(input);

		// arrange
		payload.Should().Contain($"\"element\":{elementPayload}");
	}

	public static IEnumerable<object[]> GetInputElementData() =>
			[
				[new PlainTextInput()],
				[new SelectChannels()],
				[new SelectUsers()],
				[new SelectConversations()],
				[new SelectStatic()],
				[new SelectExternal()],
				[new MultiSelectChannels()],
				[new MultiSelectUsers()],
				[new MultiSelectConversations()],
				[new MultiSelectStatic()],
				[new MultiSelectExternal()],
				[new DatePicker()]
			];
}
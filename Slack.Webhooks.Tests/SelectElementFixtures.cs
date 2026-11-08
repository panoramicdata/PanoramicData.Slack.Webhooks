using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class SelectElementFixtures
{
	[Theory]
	[InlineData(ElementType.MultiSelectStatic, "multi_static_select")]
	[InlineData(ElementType.MultiSelectExternal, "multi_external_select")]
	[InlineData(ElementType.MultiSelectUsers, "multi_users_select")]
	[InlineData(ElementType.MultiSelectConversations, "multi_conversations_select")]
	[InlineData(ElementType.MultiSelectChannels, "multi_channels_select")]
	[InlineData(ElementType.SelectStatic, "static_select")]
	[InlineData(ElementType.SelectExternal, "external_select")]
	[InlineData(ElementType.SelectUsers, "users_select")]
	[InlineData(ElementType.SelectConversations, "conversations_select")]
	[InlineData(ElementType.SelectChannels, "channels_select")]
	public void ShouldSerializeType(ElementType elementType, string expected)
		=> SerializationAssert.ContainsProperty(new Select(elementType), "type", expected);

	[Fact]
	public void ShouldSerializeActionId()
		=> SerializationAssert.ContainsProperty(new Select(ElementType.MultiSelectStatic) { ActionId = "Action123" }, "action_id", "Action123");

	[Fact]
	public void ShouldSerializePlaceholder()
	{
		var text = new TextObject();
		SerializationAssert.ContainsProperty(new Select(ElementType.MultiSelectStatic) { Placeholder = text }, "placeholder", text);
	}

	[Fact]
	public void ShouldSerializeConfirm()
	{
		var confirm = new Confirmation();
		SerializationAssert.ContainsProperty(new Select(ElementType.MultiSelectStatic) { Confirm = confirm }, "confirm", confirm);
	}
}

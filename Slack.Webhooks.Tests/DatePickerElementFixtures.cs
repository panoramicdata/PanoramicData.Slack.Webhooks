using PanoramicData.Slack.Webhooks.Elements;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class DatePickerElementFixtures
{
	[Fact]
	public void ShouldSerializeType()
		=> SerializationAssert.ContainsProperty(new DatePicker(), "type", "datepicker");

	[Fact]
	public void ShouldSerializeActionId()
		=> SerializationAssert.ContainsProperty(new DatePicker { ActionId = "Action123" }, "action_id", "Action123");

	[Fact]
	public void ShouldSerializeInitialDate()
		=> SerializationAssert.ContainsProperty(new DatePicker { InitialDate = "2019-11-01" }, "initial_date", "2019-11-01");

	[Fact]
	public void ShouldSerializePlaceholder()
	{
		var text = new TextObject();
		SerializationAssert.ContainsProperty(new DatePicker { Placeholder = text }, "placeholder", text);
	}

	[Fact]
	public void ShouldSerializeConfirm()
	{
		var confirm = new Confirmation();
		SerializationAssert.ContainsProperty(new DatePicker { Confirm = confirm }, "confirm", confirm);
	}
}

using AwesomeAssertions;

namespace PanoramicData.Slack.Webhooks.Tests;

internal static class SerializationAssert
{
	/// <summary>Asserts that the serialized element contains the property with the serialized value.</summary>
	public static void ContainsProperty(object element, string propertyName, object value)
	{
		var valuePayload = SlackClient.SerializeObject(value);

		SlackClient.SerializeObject(element).Should().Contain($"\"{propertyName}\":{valuePayload}");
	}
}

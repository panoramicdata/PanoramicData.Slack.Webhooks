using PanoramicData.Slack.Webhooks.Elements;
using System.Collections.Generic;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class MultiSelectStaticElementFixtures
{
	private static List<Option> CreateOptions() => [new Option { Value = "Value123" }];

	[Fact]
	public void ShouldSerializeOptions()
	{
		var options = CreateOptions();
		SerializationAssert.ContainsProperty(new MultiSelectStatic { Options = options }, "options", options);
	}

	[Fact]
	public void ShouldSerializeInitialOptions()
	{
		var options = CreateOptions();
		SerializationAssert.ContainsProperty(new MultiSelectStatic { InitialOptions = options }, "initial_options", options);
	}

	[Fact]
	public void ShouldSerializeInitialOptionGroup()
	{
		var groups = new List<OptionGroup> { new() { Options = CreateOptions() } };
		SerializationAssert.ContainsProperty(new MultiSelectStatic { OptionGroups = groups }, "option_groups", groups);
	}
}

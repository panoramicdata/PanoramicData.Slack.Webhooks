using PanoramicData.Slack.Webhooks.Elements;
using System.Collections.Generic;
using Xunit;

namespace PanoramicData.Slack.Webhooks.Tests;

public class SelectStaticElementFixtures
{
	[Fact]
	public void ShouldSerializeOptions()
	{
		List<Option> options = [new Option { Value = "Value123" }];
		SerializationAssert.ContainsProperty(new SelectStatic { Options = options }, "options", options);
	}

	[Fact]
	public void ShouldSerializeInitialOption()
	{
		var option = new Option { Value = "Value123" };
		SerializationAssert.ContainsProperty(new SelectStatic { InitialOption = option }, "initial_option", option);
	}

	[Fact]
	public void ShouldSerializeInitialOptionGroup()
	{
		List<OptionGroup> groups = [new OptionGroup { Options = [new Option { Value = "Value123" }] }];
		SerializationAssert.ContainsProperty(new SelectStatic { OptionGroups = groups }, "option_groups", groups);
	}
}

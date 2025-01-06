using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/>, <see cref="Blocks.Actions"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This is the simplest form of select menu, with a static list of options passed in when defining the element.
/// </summary>
public class SelectStatic() : Select(ElementType.SelectStatic), IActionElement, IInputElement
{
	/// <summary>
	///	An array of <see cref="Option"/> objects. 
	/// Maximum number of options is 100. 
	/// If <see cref="OptionGroups"/> is specified, this field should not be.
	/// </summary>
	public List<Option>? Options { get; set; }

	/// <summary>
	///	An array of <see cref="OptionGroups"/> objects. 
	/// Maximum number of options is 100. 
	/// If <see cref="Option"/> is specified, this field should not be.
	/// </summary>
	public List<OptionGroup>? OptionGroups { get; set; }

	/// <summary>
	///	A single <see cref="Option"/> that exactly match one 
	/// of the options within <see cref="Options"/> or <see cref="OptionGroups"/>. 
	/// This option will be selected when the menu initially loads.
	/// </summary>
	public Option? InitialOption { get; set; }
}

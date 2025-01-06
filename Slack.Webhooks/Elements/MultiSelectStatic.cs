using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This is the simplest form of select menu, with a static list of options passed in when defining the element.
/// </summary>
public class MultiSelectStatic() : Select(ElementType.MultiSelectStatic), IInputElement
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
	///	An array of <see cref="Option"/> objects that exactly match one or 
	/// more of the options within <see cref="Options"/> or <see cref="OptionGroups"/>. 
	/// These options will be selected when the menu initially loads.
	/// </summary>
	public List<Option>? InitialOptions { get; set; }
}
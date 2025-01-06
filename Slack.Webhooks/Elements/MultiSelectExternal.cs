using PanoramicData.Slack.Webhooks.Interfaces;
using System.Collections.Generic;

namespace PanoramicData.Slack.Webhooks.Elements;

/// <summary>
/// Works with <see cref="Blocks.Section"/> and <see cref="Blocks.Input"/> blocks.
/// 
/// This menu will load its options from an external data source, allowing for a dynamic list of options.
/// 
/// Setup
/// To use this menu type, you'll need to configure your app first:
/// 
/// Goto your app's settings page and choose the Interactive Components feature menu.
/// Add a URL to the Options Load URL under Select Menus.
/// Save changes.
/// Each time a menu of this type is opened or the user starts typing in the typeahead field, we'll send a request to your specified URL. Your app should return an HTTP 200 OK response, along with an application/json post body with an object containing either an options array, or an option_groups array.
/// </summary>
public class MultiSelectExternal() : Select(ElementType.MultiSelectExternal), IInputElement
{
	/// <summary>
	/// When the type-ahead field is used, a request will be sent on every 
	/// character change. If you prefer fewer requests or more fully ideated queries, 
	/// use the <see cref="MinQueryLength"/> attribute to tell Slack the fewest 
	/// number of typed characters required before dispatch.
	/// </summary>
	public int MinQueryLength { get; set; }

	/// <summary>
	///	An array of <see cref="Option"/> objects that exactly match one or 
	/// more of the options within <see cref="Options"/> or <see cref="OptionGroups"/>. 
	/// These options will be selected when the menu initially loads.
	/// </summary>
	public IList<Option>? InitialOptions { get; set; }
}

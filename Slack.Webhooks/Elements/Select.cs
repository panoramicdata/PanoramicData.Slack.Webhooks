namespace PanoramicData.Slack.Webhooks.Elements;

public class Select(ElementType elementType) : Element(elementType)
{
	/// <summary>
	/// An identifier for the action triggered when a menu option is selected. 
	/// You can use this when you receive an interaction payload to identify the source of the action. 
	/// Should be unique among all other <see cref="ActionId"/>s used elsewhere by your app. 
	/// Maximum length for this field is 255 characters.
	/// </summary>
	public string? ActionId { get; set; }

	/// <summary>
	/// A <see cref="TextObject.TextType.PlainText"/> only <see cref="TextObject"/> that defines the placeholder text shown on the menu. 
	/// Maximum length for the text in this field is 150 characters.
	/// </summary>
	public TextObject? Placeholder { get; set; }

	/// <summary>
	/// A <see cref="Confirmation"/> object that defines an optional confirmation dialog that appears before the choice(s) are submitted
	/// </summary>
	public Confirmation? Confirm { get; set; }
}
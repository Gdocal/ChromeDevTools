using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightRect)]
	[SupportedBy("Chrome")]
	public class HighlightRectCommand
	{
		/// <summary>
		/// Gets or sets X coordinate
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets Rectangle width
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Rectangle height
		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Gets or sets The highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBA Color { get; set; }
		/// <summary>
		/// Gets or sets The highlight outline color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBA OutlineColor { get; set; }
	}
}

using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Returns metadata of the entry.
	/// </summary>
	[Command(ProtocolName.FileSystem.RequestMetadata)]
	[SupportedBy("Chrome")]
	public class RequestMetadataCommand
	{
		/// <summary>
		/// Gets or sets URL of the entry that the frontend is requesting to get metadata from.
		/// </summary>
		public string Url { get; set; }
	}
}

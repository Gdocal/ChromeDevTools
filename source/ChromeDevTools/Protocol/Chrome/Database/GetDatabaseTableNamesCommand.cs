using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("Chrome")]
	public class GetDatabaseTableNamesCommand
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class MetaDetailedOnly {
		public JsonNode Features { get; set; }
		public string ProxyAccountName { get; set; }
		public bool RequireSetup { get; set; }
		public bool CacheRemoteFiles { get; set; }
		public bool CacheRemoteSensitiveFiles { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetaDetailedOnly: {\n");
			sb.Append($"  features: {this.Features}\n");
			sb.Append($"  proxyAccountName: {this.ProxyAccountName}\n");
			sb.Append($"  requireSetup: {this.RequireSetup}\n");
			sb.Append($"  cacheRemoteFiles: {this.CacheRemoteFiles}\n");
			sb.Append($"  cacheRemoteSensitiveFiles: {this.CacheRemoteSensitiveFiles}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

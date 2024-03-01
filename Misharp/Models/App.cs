using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class App {
		public string Id { get; set; }
		public string Name { get; set; }
		public string CallbackUrl { get; set; }
		public List<string> Permission { get; set; }
		public string Secret { get; set; }
		public bool IsAuthorized { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class App: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  callbackUrl: {this.CallbackUrl}\n");
			sb.Append("  permission: {\n");
			if (this.Permission != null && this.Permission.Count > 0) this.Permission.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  secret: {this.Secret}\n");
			sb.Append($"  isAuthorized: {this.IsAuthorized}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

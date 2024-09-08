using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Signin {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Ip { get; set; }
		public JsonNode Headers { get; set; }
		public bool Success { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Signin: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  ip: {this.Ip}\n");
			var sbHeaders = new StringBuilder();
			sbHeaders.Append("  headers: [\n");
			if (this.Headers != null)
			{
				sbHeaders.Append(this.Headers);
				sbHeaders.Replace("\n", "\n    ");
				sbHeaders.Append("\n");
			}
			sbHeaders.Append("  ]\n");
			sb.Append(sbHeaders);
			sb.Append($"  success: {this.Success}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

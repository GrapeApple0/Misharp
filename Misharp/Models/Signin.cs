using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class Signin {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Ip { get; set; }
		public object Headers { get; set; }
		public bool Success { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Signin: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  ip: {this.Ip}\n");
			sb.Append($"  headers: {this.Headers}\n");
			sb.Append($"  success: {this.Success}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

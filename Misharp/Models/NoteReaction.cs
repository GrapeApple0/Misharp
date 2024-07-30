using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class NoteReaction {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public UserLite User { get; set; }
		public string Type { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NoteReaction: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			var sbUser = new StringBuilder();
			sbUser.Append("  user: [\n");
			if (this.User != null)
			{
				sbUser.Append(this.User);
				sbUser.Replace("\n", "\n    ");
				sbUser.Append("\n");
			}
			sbUser.Append("  ]\n");
			sb.Append(sbUser);
			sb.Append($"  type: {this.Type}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

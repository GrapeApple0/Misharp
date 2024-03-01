using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RenoteMuting {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string MuteeId { get; set; }
		public UserDetailedNotMe Mutee { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RenoteMuting: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  muteeId: {this.MuteeId}\n");
			var sbmutee = new StringBuilder();
			sbmutee.Append("  mutee: {\n");
			if (this.Mutee != null)
			{
				sbmutee.Append(this.Mutee);
				sbmutee.Replace("\n", "\n    ");
				sbmutee.Append("\n");
			}
			sbmutee.Append("  }\n");
			sb.Append(sbmutee);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

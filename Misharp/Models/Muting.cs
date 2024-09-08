using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Muting {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? ExpiresAt { get; set; }
		public string MuteeId { get; set; }
		public UserDetailedNotMe Mutee { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Muting: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  expiresAt: {this.ExpiresAt}\n");
			sb.Append($"  muteeId: {this.MuteeId}\n");
			var sbMutee = new StringBuilder();
			sbMutee.Append("  mutee: [\n");
			if (this.Mutee != null)
			{
				sbMutee.Append(this.Mutee);
				sbMutee.Replace("\n", "\n    ");
				sbMutee.Append("\n");
			}
			sbMutee.Append("  ]\n");
			sb.Append(sbMutee);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

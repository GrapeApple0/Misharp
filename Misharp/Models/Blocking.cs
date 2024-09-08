using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Blocking {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string BlockeeId { get; set; }
		public UserDetailedNotMe Blockee { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Blocking: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  blockeeId: {this.BlockeeId}\n");
			var sbBlockee = new StringBuilder();
			sbBlockee.Append("  blockee: [\n");
			if (this.Blockee != null)
			{
				sbBlockee.Append(this.Blockee);
				sbBlockee.Replace("\n", "\n    ");
				sbBlockee.Append("\n");
			}
			sbBlockee.Append("  ]\n");
			sb.Append(sbBlockee);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

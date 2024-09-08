using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class InviteCode {
		public string Id { get; set; }
		public string Code { get; set; }
		public DateTime? ExpiresAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public UserLite? CreatedBy { get; set; }
		public UserLite? UsedBy { get; set; }
		public DateTime? UsedAt { get; set; }
		public bool Used { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InviteCode: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  code: {this.Code}\n");
			sb.Append($"  expiresAt: {this.ExpiresAt}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			var sbCreatedBy = new StringBuilder();
			sbCreatedBy.Append("  createdBy: [\n");
			if (this.CreatedBy != null)
			{
				sbCreatedBy.Append(this.CreatedBy);
				sbCreatedBy.Replace("\n", "\n    ");
				sbCreatedBy.Append("\n");
			}
			sbCreatedBy.Append("  ]\n");
			sb.Append(sbCreatedBy);
			var sbUsedBy = new StringBuilder();
			sbUsedBy.Append("  usedBy: [\n");
			if (this.UsedBy != null)
			{
				sbUsedBy.Append(this.UsedBy);
				sbUsedBy.Replace("\n", "\n    ");
				sbUsedBy.Append("\n");
			}
			sbUsedBy.Append("  ]\n");
			sb.Append(sbUsedBy);
			sb.Append($"  usedAt: {this.UsedAt}\n");
			sb.Append($"  used: {this.Used}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

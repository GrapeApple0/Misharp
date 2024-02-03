using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class InviteCode {
		public string Id { get; set; }
		public string Code { get; set; }
		public DateTime ExpiresAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public object CreatedBy { get; set; }
		public object UsedBy { get; set; }
		public DateTime UsedAt { get; set; }
		public bool Used { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InviteCode: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  code: {this.Code}\n");
			sb.Append($"  expiresAt: {this.ExpiresAt}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  createdBy: {this.CreatedBy}\n");
			sb.Append($"  usedBy: {this.UsedBy}\n");
			sb.Append($"  usedAt: {this.UsedAt}\n");
			sb.Append($"  used: {this.Used}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class AbuseReportNotificationRecipient {
		public string Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string Name { get; set; }
		public string Method { get; set; }
		public string UserId { get; set; }
		public UserLite User { get; set; }
		public string SystemWebhookId { get; set; }
		public SystemWebhook SystemWebhook { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AbuseReportNotificationRecipient: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  isActive: {this.IsActive}\n");
			sb.Append($"  updatedAt: {this.UpdatedAt}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  method: {this.Method}\n");
			sb.Append($"  userId: {this.UserId}\n");
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
			sb.Append($"  systemWebhookId: {this.SystemWebhookId}\n");
			var sbSystemWebhook = new StringBuilder();
			sbSystemWebhook.Append("  systemWebhook: [\n");
			if (this.SystemWebhook != null)
			{
				sbSystemWebhook.Append(this.SystemWebhook);
				sbSystemWebhook.Replace("\n", "\n    ");
				sbSystemWebhook.Append("\n");
			}
			sbSystemWebhook.Append("  ]\n");
			sb.Append(sbSystemWebhook);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

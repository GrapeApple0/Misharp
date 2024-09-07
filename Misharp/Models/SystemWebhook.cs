using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class SystemWebhook {
		public string Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime UpdatedAt { get; set; }
		public DateTime? LatestSentAt { get; set; }
		public decimal? LatestStatus { get; set; }
		public string Name { get; set; }
		public List<string> On { get; set; }
		public string Url { get; set; }
		public string Secret { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SystemWebhook: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  isActive: {this.IsActive}\n");
			sb.Append($"  updatedAt: {this.UpdatedAt}\n");
			sb.Append($"  latestSentAt: {this.LatestSentAt}\n");
			sb.Append($"  latestStatus: {this.LatestStatus}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append("  on: [\n");
			if (this.On != null && this.On.Count > 0)
			{
				var sbOn = new StringBuilder();
				sbOn.Append("    ");
				this.On.ForEach(item => sbOn.Append(item).Append(",\n"));
				sbOn.Replace("\n", "\n    ");
				sbOn.Length -= 4;
				sb.Append(sbOn);
			}
			sb.Append("  ]\n");
			sb.Append($"  url: {this.Url}\n");
			sb.Append($"  secret: {this.Secret}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

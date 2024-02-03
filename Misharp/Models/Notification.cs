using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class Notification {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Type { get; set; }
		public object User { get; set; }
		public string UserId { get; set; }
		public object Note { get; set; }
		public string Reaction { get; set; }
		public string Achievement { get; set; }
		public string Body { get; set; }
		public string Header { get; set; }
		public string Icon { get; set; }
		public class ReactionsItemType {
			public object Reactions { get; set; }
		}
		public List<ReactionsItemType> Reactions { get; set; }
		public List<UserLite> Users { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Notification: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  type: {this.Type}\n");
			sb.Append($"  user: {this.User}\n");
			sb.Append($"  userId: {this.UserId}\n");
			sb.Append($"  note: {this.Note}\n");
			sb.Append($"  reaction: {this.Reaction}\n");
			sb.Append($"  achievement: {this.Achievement}\n");
			sb.Append($"  body: {this.Body}\n");
			sb.Append($"  header: {this.Header}\n");
			sb.Append($"  icon: {this.Icon}\n");
			sb.Append("  reactions: {\n");
			if (this.Reactions != null && this.Reactions.Count > 0) this.Reactions.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  users: {\n");
			if (this.Users != null && this.Users.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.Users.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.Users.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  }\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

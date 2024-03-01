using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Hashtag {
		public string Tag { get; set; }
		public decimal MentionedUsersCount { get; set; }
		public decimal MentionedLocalUsersCount { get; set; }
		public decimal MentionedRemoteUsersCount { get; set; }
		public decimal AttachedUsersCount { get; set; }
		public decimal AttachedLocalUsersCount { get; set; }
		public decimal AttachedRemoteUsersCount { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Hashtag: {\n");
			sb.Append($"  tag: {this.Tag}\n");
			sb.Append($"  mentionedUsersCount: {this.MentionedUsersCount}\n");
			sb.Append($"  mentionedLocalUsersCount: {this.MentionedLocalUsersCount}\n");
			sb.Append($"  mentionedRemoteUsersCount: {this.MentionedRemoteUsersCount}\n");
			sb.Append($"  attachedUsersCount: {this.AttachedUsersCount}\n");
			sb.Append($"  attachedLocalUsersCount: {this.AttachedLocalUsersCount}\n");
			sb.Append($"  attachedRemoteUsersCount: {this.AttachedRemoteUsersCount}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Antenna {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Name { get; set; }
		public List<List<string>> Keywords { get; set; }
		public List<List<string>> ExcludeKeywords { get; set; }
		public string Src { get; set; }
		public string? UserListId { get; set; }
		public List<string> Users { get; set; }
		public bool CaseSensitive { get; set; }
		public bool LocalOnly { get; set; }
		public bool ExcludeBots { get; set; }
		public bool WithReplies { get; set; }
		public bool WithFile { get; set; }
		public bool IsActive { get; set; }
		public bool HasUnreadNote { get; set; }
		public bool Notify { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Antenna: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append("  keywords: [\n");
			if (this.Keywords != null && this.Keywords.Count > 0)
			{
				var sbKeywords = new StringBuilder();
				sbKeywords.Append("    ");
				this.Keywords.ForEach(item => sbKeywords.Append(item).Append(",\n"));
				sbKeywords.Replace("\n", "\n    ");
				sbKeywords.Length -= 4;
				sb.Append(sbKeywords);
			}
			sb.Append("  ]\n");
			sb.Append("  excludeKeywords: [\n");
			if (this.ExcludeKeywords != null && this.ExcludeKeywords.Count > 0)
			{
				var sbExcludeKeywords = new StringBuilder();
				sbExcludeKeywords.Append("    ");
				this.ExcludeKeywords.ForEach(item => sbExcludeKeywords.Append(item).Append(",\n"));
				sbExcludeKeywords.Replace("\n", "\n    ");
				sbExcludeKeywords.Length -= 4;
				sb.Append(sbExcludeKeywords);
			}
			sb.Append("  ]\n");
			sb.Append($"  src: {this.Src}\n");
			sb.Append($"  userListId: {this.UserListId}\n");
			sb.Append("  users: [\n");
			if (this.Users != null && this.Users.Count > 0)
			{
				var sbUsers = new StringBuilder();
				sbUsers.Append("    ");
				this.Users.ForEach(item => sbUsers.Append(item).Append(",\n"));
				sbUsers.Replace("\n", "\n    ");
				sbUsers.Length -= 4;
				sb.Append(sbUsers);
			}
			sb.Append("  ]\n");
			sb.Append($"  caseSensitive: {this.CaseSensitive}\n");
			sb.Append($"  localOnly: {this.LocalOnly}\n");
			sb.Append($"  excludeBots: {this.ExcludeBots}\n");
			sb.Append($"  withReplies: {this.WithReplies}\n");
			sb.Append($"  withFile: {this.WithFile}\n");
			sb.Append($"  isActive: {this.IsActive}\n");
			sb.Append($"  hasUnreadNote: {this.HasUnreadNote}\n");
			sb.Append($"  notify: {this.Notify}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

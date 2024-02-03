using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class Antenna {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Name { get; set; }
		public class KeywordsItemsItemType {
			public string Keywords { get; set; }
		}
		public List<List<KeywordsItemsItemType>> Keywords { get; set; }
		public class ExcludeKeywordsItemsItemType {
			public string ExcludeKeywords { get; set; }
		}
		public List<List<ExcludeKeywordsItemsItemType>> ExcludeKeywords { get; set; }
		public string Src { get; set; }
		public string UserListId { get; set; }
		public List<string> Users { get; set; }
		public bool CaseSensitive { get; set; }
		public bool LocalOnly { get; set; }
		public bool Notify { get; set; }
		public bool WithReplies { get; set; }
		public bool WithFile { get; set; }
		public bool IsActive { get; set; }
		public bool HasUnreadNote { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Antenna: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append("  keywords: {\n");
			if (this.Keywords != null && this.Keywords.Count > 0) this.Keywords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  excludeKeywords: {\n");
			if (this.ExcludeKeywords != null && this.ExcludeKeywords.Count > 0) this.ExcludeKeywords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  src: {this.Src}\n");
			sb.Append($"  userListId: {this.UserListId}\n");
			sb.Append("  users: {\n");
			if (this.Users != null && this.Users.Count > 0) this.Users.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  caseSensitive: {this.CaseSensitive}\n");
			sb.Append($"  localOnly: {this.LocalOnly}\n");
			sb.Append($"  notify: {this.Notify}\n");
			sb.Append($"  withReplies: {this.WithReplies}\n");
			sb.Append($"  withFile: {this.WithFile}\n");
			sb.Append($"  isActive: {this.IsActive}\n");
			sb.Append($"  hasUnreadNote: {this.HasUnreadNote}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

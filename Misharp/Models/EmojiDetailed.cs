using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class EmojiDetailed {
		public string Id { get; set; }
		public List<string> Aliases { get; set; }
		public string Name { get; set; }
		public string? Category { get; set; }
		public string? Host { get; set; }
		public string Url { get; set; }
		public string? License { get; set; }
		public bool IsSensitive { get; set; }
		public bool LocalOnly { get; set; }
		public List<string> RoleIdsThatCanBeUsedThisEmojiAsReaction { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EmojiDetailed: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append("  aliases: [\n");
			if (this.Aliases != null && this.Aliases.Count > 0)
			{
				var sbAliases = new StringBuilder();
				sbAliases.Append("    ");
				this.Aliases.ForEach(item => sbAliases.Append(item).Append(",\n"));
				sbAliases.Replace("\n", "\n    ");
				sbAliases.Length -= 4;
				sb.Append(sbAliases);
			}
			sb.Append("  ]\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  category: {this.Category}\n");
			sb.Append($"  host: {this.Host}\n");
			sb.Append($"  url: {this.Url}\n");
			sb.Append($"  license: {this.License}\n");
			sb.Append($"  isSensitive: {this.IsSensitive}\n");
			sb.Append($"  localOnly: {this.LocalOnly}\n");
			sb.Append("  roleIdsThatCanBeUsedThisEmojiAsReaction: [\n");
			if (this.RoleIdsThatCanBeUsedThisEmojiAsReaction != null && this.RoleIdsThatCanBeUsedThisEmojiAsReaction.Count > 0)
			{
				var sbRoleIdsThatCanBeUsedThisEmojiAsReaction = new StringBuilder();
				sbRoleIdsThatCanBeUsedThisEmojiAsReaction.Append("    ");
				this.RoleIdsThatCanBeUsedThisEmojiAsReaction.ForEach(item => sbRoleIdsThatCanBeUsedThisEmojiAsReaction.Append(item).Append(",\n"));
				sbRoleIdsThatCanBeUsedThisEmojiAsReaction.Replace("\n", "\n    ");
				sbRoleIdsThatCanBeUsedThisEmojiAsReaction.Length -= 4;
				sb.Append(sbRoleIdsThatCanBeUsedThisEmojiAsReaction);
			}
			sb.Append("  ]\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

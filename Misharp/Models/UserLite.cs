using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class UserLite {
		public string Id { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public string Host { get; set; }
		public string AvatarUrl { get; set; }
		public string AvatarBlurhash { get; set; }
		public List<object> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public class UserLiteInstanceObject {
			public string Name { get; set; }
			public string SoftwareName { get; set; }
			public string SoftwareVersion { get; set; }
			public string IconUrl { get; set; }
			public string FaviconUrl { get; set; }
			public string ThemeColor { get; set; }
		}
		public UserLiteInstanceObject Instance { get; set; }
		public JsonNode Emojis { get; set; }
		public string OnlineStatus { get; set; }
		public List<object> BadgeRoles { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserLite: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  username: {this.Username}\n");
			sb.Append($"  host: {this.Host}\n");
			sb.Append($"  avatarUrl: {this.AvatarUrl}\n");
			sb.Append($"  avatarBlurhash: {this.AvatarBlurhash}\n");
			sb.Append("  avatarDecorations: {\n");
			if (this.AvatarDecorations != null && this.AvatarDecorations.Count > 0) this.AvatarDecorations.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  isBot: {this.IsBot}\n");
			sb.Append($"  isCat: {this.IsCat}\n");
			sb.Append($"  instance: {this.Instance}\n");
			sb.Append($"  emojis: {this.Emojis}\n");
			sb.Append($"  onlineStatus: {this.OnlineStatus}\n");
			sb.Append("  badgeRoles: {\n");
			if (this.BadgeRoles != null && this.BadgeRoles.Count > 0) this.BadgeRoles.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

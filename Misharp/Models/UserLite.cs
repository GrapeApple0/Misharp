using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class UserLite {
		public string Id { get; set; }
		public string? Name { get; set; }
		public string Username { get; set; }
		public string? Host { get; set; }
		public string? AvatarUrl { get; set; }
		public string? AvatarBlurhash { get; set; }
		public class UserLiteAvatarDecorationsPropertyType {
			public string Id { get; set; }
			public decimal Angle { get; set; }
			public bool FlipH { get; set; }
			public string Url { get; set; }
			public decimal OffsetX { get; set; }
			public decimal OffsetY { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserLiteAvatarDecorationsPropertyType: {\n");
				sb.Append($"  id: {this.Id}\n");
				sb.Append($"  angle: {this.Angle}\n");
				sb.Append($"  flipH: {this.FlipH}\n");
				sb.Append($"  url: {this.Url}\n");
				sb.Append($"  offsetX: {this.OffsetX}\n");
				sb.Append($"  offsetY: {this.OffsetY}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<UserLiteAvatarDecorationsPropertyType> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public class UserLiteInstanceObject {
			public string? Name { get; set; }
			public string? SoftwareName { get; set; }
			public string? SoftwareVersion { get; set; }
			public string? IconUrl { get; set; }
			public string? FaviconUrl { get; set; }
			public string? ThemeColor { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserLiteInstanceObject: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  softwareName: {this.SoftwareName}\n");
				sb.Append($"  softwareVersion: {this.SoftwareVersion}\n");
				sb.Append($"  iconUrl: {this.IconUrl}\n");
				sb.Append($"  faviconUrl: {this.FaviconUrl}\n");
				sb.Append($"  themeColor: {this.ThemeColor}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public UserLiteInstanceObject Instance { get; set; }
		public JsonNode Emojis { get; set; }
		public string OnlineStatus { get; set; }
		public class UserLiteBadgeRolesPropertyType {
			public string Name { get; set; }
			public string? IconUrl { get; set; }
			public decimal DisplayOrder { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserLiteBadgeRolesPropertyType: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  iconUrl: {this.IconUrl}\n");
				sb.Append($"  displayOrder: {this.DisplayOrder}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<UserLiteBadgeRolesPropertyType> BadgeRoles { get; set; }
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
			sb.Append("  avatarDecorations: [\n");
			if (this.AvatarDecorations != null && this.AvatarDecorations.Count > 0)
			{
				var sbAvatarDecorations = new StringBuilder();
				sbAvatarDecorations.Append("    ");
				this.AvatarDecorations.ForEach(item => sbAvatarDecorations.Append(item).Append(",\n"));
				sbAvatarDecorations.Replace("\n", "\n    ");
				sbAvatarDecorations.Length -= 4;
				sb.Append(sbAvatarDecorations);
			}
			sb.Append("  ]\n");
			sb.Append($"  isBot: {this.IsBot}\n");
			sb.Append($"  isCat: {this.IsCat}\n");
			var sbInstance = new StringBuilder();
			sbInstance.Append("  instance: [\n");
			if (this.Instance != null)
			{
				sbInstance.Append(this.Instance);
				sbInstance.Replace("\n", "\n    ");
				sbInstance.Append("\n");
			}
			sbInstance.Append("  ]\n");
			sb.Append(sbInstance);
			var sbEmojis = new StringBuilder();
			sbEmojis.Append("  emojis: [\n");
			if (this.Emojis != null)
			{
				sbEmojis.Append(this.Emojis);
				sbEmojis.Replace("\n", "\n    ");
				sbEmojis.Append("\n");
			}
			sbEmojis.Append("  ]\n");
			sb.Append(sbEmojis);
			sb.Append($"  onlineStatus: {this.OnlineStatus}\n");
			sb.Append("  badgeRoles: [\n");
			if (this.BadgeRoles != null && this.BadgeRoles.Count > 0)
			{
				var sbBadgeRoles = new StringBuilder();
				sbBadgeRoles.Append("    ");
				this.BadgeRoles.ForEach(item => sbBadgeRoles.Append(item).Append(",\n"));
				sbBadgeRoles.Replace("\n", "\n    ");
				sbBadgeRoles.Length -= 4;
				sb.Append(sbBadgeRoles);
			}
			sb.Append("  ]\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

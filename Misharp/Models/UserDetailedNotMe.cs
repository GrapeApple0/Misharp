using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class UserDetailedNotMe {
		public string Id { get; set; }
		public string? Name { get; set; }
		public string Username { get; set; }
		public string? Host { get; set; }
		public string? AvatarUrl { get; set; }
		public string? AvatarBlurhash { get; set; }
		public class UserDetailedNotMeAvatarDecorationsPropertyType {
			public string Id { get; set; }
			public decimal Angle { get; set; }
			public bool FlipH { get; set; }
			public string Url { get; set; }
			public decimal OffsetX { get; set; }
			public decimal OffsetY { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserDetailedNotMeAvatarDecorationsPropertyType: {\n");
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
		public List<UserDetailedNotMeAvatarDecorationsPropertyType> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public class UserDetailedNotMeInstanceObject {
			public string? Name { get; set; }
			public string? SoftwareName { get; set; }
			public string? SoftwareVersion { get; set; }
			public string? IconUrl { get; set; }
			public string? FaviconUrl { get; set; }
			public string? ThemeColor { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserDetailedNotMeInstanceObject: {\n");
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
		public UserDetailedNotMeInstanceObject Instance { get; set; }
		public JsonNode Emojis { get; set; }
		public string OnlineStatus { get; set; }
		public class UserDetailedNotMeBadgeRolesPropertyType {
			public string Name { get; set; }
			public string? IconUrl { get; set; }
			public decimal DisplayOrder { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserDetailedNotMeBadgeRolesPropertyType: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  iconUrl: {this.IconUrl}\n");
				sb.Append($"  displayOrder: {this.DisplayOrder}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<UserDetailedNotMeBadgeRolesPropertyType> BadgeRoles { get; set; }
		public string? Url { get; set; }
		public string? Uri { get; set; }
		public string? MovedTo { get; set; }
		public List<string>? AlsoKnownAs { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? LastFetchedAt { get; set; }
		public string? BannerUrl { get; set; }
		public string? BannerBlurhash { get; set; }
		public bool IsLocked { get; set; }
		public bool IsSilenced { get; set; }
		public bool IsSuspended { get; set; }
		public string? Description { get; set; }
		public string? Location { get; set; }
		public string? Birthday { get; set; }
		public string? Lang { get; set; }
		public class UserDetailedNotMeFieldsPropertyType {
			public string Name { get; set; }
			public string Value { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserDetailedNotMeFieldsPropertyType: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  value: {this.Value}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<UserDetailedNotMeFieldsPropertyType> Fields { get; set; }
		public List<string> VerifiedLinks { get; set; }
		public decimal FollowersCount { get; set; }
		public decimal FollowingCount { get; set; }
		public decimal NotesCount { get; set; }
		public List<string> PinnedNoteIds { get; set; }
		public List<Note> PinnedNotes { get; set; }
		public string? PinnedPageId { get; set; }
		public Page? PinnedPage { get; set; }
		public bool PublicReactions { get; set; }
		public string FollowingVisibility { get; set; }
		public string FollowersVisibility { get; set; }
		public bool TwoFactorEnabled { get; set; }
		public bool UsePasswordLessLogin { get; set; }
		public bool SecurityKeys { get; set; }
		public List<RoleLite> Roles { get; set; }
		public string? Memo { get; set; }
		public string ModerationNote { get; set; }
		public bool IsFollowing { get; set; }
		public bool IsFollowed { get; set; }
		public bool HasPendingFollowRequestFromYou { get; set; }
		public bool HasPendingFollowRequestToYou { get; set; }
		public bool IsBlocking { get; set; }
		public bool IsBlocked { get; set; }
		public bool IsMuted { get; set; }
		public bool IsRenoteMuted { get; set; }
		public string Notify { get; set; }
		public bool WithReplies { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserDetailedNotMe: {\n");
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
			sb.Append($"  url: {this.Url}\n");
			sb.Append($"  uri: {this.Uri}\n");
			sb.Append($"  movedTo: {this.MovedTo}\n");
			sb.Append("  alsoKnownAs: [\n");
			if (this.AlsoKnownAs != null && this.AlsoKnownAs.Count > 0)
			{
				var sbAlsoKnownAs = new StringBuilder();
				sbAlsoKnownAs.Append("    ");
				this.AlsoKnownAs.ForEach(item => sbAlsoKnownAs.Append(item).Append(",\n"));
				sbAlsoKnownAs.Replace("\n", "\n    ");
				sbAlsoKnownAs.Length -= 4;
				sb.Append(sbAlsoKnownAs);
			}
			sb.Append("  ]\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  updatedAt: {this.UpdatedAt}\n");
			sb.Append($"  lastFetchedAt: {this.LastFetchedAt}\n");
			sb.Append($"  bannerUrl: {this.BannerUrl}\n");
			sb.Append($"  bannerBlurhash: {this.BannerBlurhash}\n");
			sb.Append($"  isLocked: {this.IsLocked}\n");
			sb.Append($"  isSilenced: {this.IsSilenced}\n");
			sb.Append($"  isSuspended: {this.IsSuspended}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append($"  location: {this.Location}\n");
			sb.Append($"  birthday: {this.Birthday}\n");
			sb.Append($"  lang: {this.Lang}\n");
			sb.Append("  fields: [\n");
			if (this.Fields != null && this.Fields.Count > 0)
			{
				var sbFields = new StringBuilder();
				sbFields.Append("    ");
				this.Fields.ForEach(item => sbFields.Append(item).Append(",\n"));
				sbFields.Replace("\n", "\n    ");
				sbFields.Length -= 4;
				sb.Append(sbFields);
			}
			sb.Append("  ]\n");
			sb.Append("  verifiedLinks: [\n");
			if (this.VerifiedLinks != null && this.VerifiedLinks.Count > 0)
			{
				var sbVerifiedLinks = new StringBuilder();
				sbVerifiedLinks.Append("    ");
				this.VerifiedLinks.ForEach(item => sbVerifiedLinks.Append(item).Append(",\n"));
				sbVerifiedLinks.Replace("\n", "\n    ");
				sbVerifiedLinks.Length -= 4;
				sb.Append(sbVerifiedLinks);
			}
			sb.Append("  ]\n");
			sb.Append($"  followersCount: {this.FollowersCount}\n");
			sb.Append($"  followingCount: {this.FollowingCount}\n");
			sb.Append($"  notesCount: {this.NotesCount}\n");
			sb.Append("  pinnedNoteIds: [\n");
			if (this.PinnedNoteIds != null && this.PinnedNoteIds.Count > 0)
			{
				var sbPinnedNoteIds = new StringBuilder();
				sbPinnedNoteIds.Append("    ");
				this.PinnedNoteIds.ForEach(item => sbPinnedNoteIds.Append(item).Append(",\n"));
				sbPinnedNoteIds.Replace("\n", "\n    ");
				sbPinnedNoteIds.Length -= 4;
				sb.Append(sbPinnedNoteIds);
			}
			sb.Append("  ]\n");
			sb.Append("  pinnedNotes: [\n");
			if (this.PinnedNotes != null && this.PinnedNotes.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.PinnedNotes.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.PinnedNotes.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  ]\n");
			sb.Append($"  pinnedPageId: {this.PinnedPageId}\n");
			var sbPinnedPage = new StringBuilder();
			sbPinnedPage.Append("  pinnedPage: [\n");
			if (this.PinnedPage != null)
			{
				sbPinnedPage.Append(this.PinnedPage);
				sbPinnedPage.Replace("\n", "\n    ");
				sbPinnedPage.Append("\n");
			}
			sbPinnedPage.Append("  ]\n");
			sb.Append(sbPinnedPage);
			sb.Append($"  publicReactions: {this.PublicReactions}\n");
			sb.Append($"  followingVisibility: {this.FollowingVisibility}\n");
			sb.Append($"  followersVisibility: {this.FollowersVisibility}\n");
			sb.Append($"  twoFactorEnabled: {this.TwoFactorEnabled}\n");
			sb.Append($"  usePasswordLessLogin: {this.UsePasswordLessLogin}\n");
			sb.Append($"  securityKeys: {this.SecurityKeys}\n");
			sb.Append("  roles: [\n");
			if (this.Roles != null && this.Roles.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.Roles.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.Roles.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  ]\n");
			sb.Append($"  memo: {this.Memo}\n");
			sb.Append($"  moderationNote: {this.ModerationNote}\n");
			sb.Append($"  isFollowing: {this.IsFollowing}\n");
			sb.Append($"  isFollowed: {this.IsFollowed}\n");
			sb.Append($"  hasPendingFollowRequestFromYou: {this.HasPendingFollowRequestFromYou}\n");
			sb.Append($"  hasPendingFollowRequestToYou: {this.HasPendingFollowRequestToYou}\n");
			sb.Append($"  isBlocking: {this.IsBlocking}\n");
			sb.Append($"  isBlocked: {this.IsBlocked}\n");
			sb.Append($"  isMuted: {this.IsMuted}\n");
			sb.Append($"  isRenoteMuted: {this.IsRenoteMuted}\n");
			sb.Append($"  notify: {this.Notify}\n");
			sb.Append($"  withReplies: {this.WithReplies}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

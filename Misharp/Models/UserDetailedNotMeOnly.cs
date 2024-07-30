using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class UserDetailedNotMeOnly {
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
		public class UserDetailedNotMeOnlyFieldsPropertyType {
			public string Name { get; set; }
			public string Value { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class UserDetailedNotMeOnlyFieldsPropertyType: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  value: {this.Value}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<UserDetailedNotMeOnlyFieldsPropertyType> Fields { get; set; }
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
			sb.Append("class UserDetailedNotMeOnly: {\n");
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

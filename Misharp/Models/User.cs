using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class User {
		public string Id { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public string Host { get; set; }
		public string AvatarUrl { get; set; }
		public string AvatarBlurhash { get; set; }
		public List<object> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public class UserInstanceObject {
			public string Name { get; set; }
			public string SoftwareName { get; set; }
			public string SoftwareVersion { get; set; }
			public string IconUrl { get; set; }
			public string FaviconUrl { get; set; }
			public string ThemeColor { get; set; }
		}
		public UserInstanceObject Instance { get; set; }
		public JsonNode Emojis { get; set; }
		public string OnlineStatus { get; set; }
		public List<object> BadgeRoles { get; set; }
		public string Url { get; set; }
		public string Uri { get; set; }
		public string MovedTo { get; set; }
		public List<string> AlsoKnownAs { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public DateTime LastFetchedAt { get; set; }
		public string BannerUrl { get; set; }
		public string BannerBlurhash { get; set; }
		public bool IsLocked { get; set; }
		public bool IsSilenced { get; set; }
		public bool IsSuspended { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public string Birthday { get; set; }
		public string Lang { get; set; }
		public List<object> Fields { get; set; }
		public List<string> VerifiedLinks { get; set; }
		public decimal FollowersCount { get; set; }
		public decimal FollowingCount { get; set; }
		public decimal NotesCount { get; set; }
		public List<string> PinnedNoteIds { get; set; }
		public List<object> PinnedNotes { get; set; }
		public string PinnedPageId { get; set; }
		public Page PinnedPage { get; set; }
		public bool PublicReactions { get; set; }
		public string FollowingVisibility { get; set; }
		public string FollowersVisibility { get; set; }
		public bool TwoFactorEnabled { get; set; }
		public bool UsePasswordLessLogin { get; set; }
		public bool SecurityKeys { get; set; }
		public List<object> Roles { get; set; }
		public string Memo { get; set; }
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
		public string AvatarId { get; set; }
		public string BannerId { get; set; }
		public bool IsModerator { get; set; }
		public bool IsAdmin { get; set; }
		public bool InjectFeaturedNote { get; set; }
		public bool ReceiveAnnouncementEmail { get; set; }
		public bool AlwaysMarkNsfw { get; set; }
		public bool AutoSensitive { get; set; }
		public bool CarefulBot { get; set; }
		public bool AutoAcceptFollowed { get; set; }
		public bool NoCrawle { get; set; }
		public bool PreventAiLearning { get; set; }
		public bool IsExplorable { get; set; }
		public bool IsDeleted { get; set; }
		public string TwoFactorBackupCodesStock { get; set; }
		public bool HideOnlineStatus { get; set; }
		public bool HasUnreadSpecifiedNotes { get; set; }
		public bool HasUnreadMentions { get; set; }
		public bool HasUnreadAnnouncement { get; set; }
		public List<object> UnreadAnnouncements { get; set; }
		public bool HasUnreadAntenna { get; set; }
		public bool HasUnreadChannel { get; set; }
		public bool HasUnreadNotification { get; set; }
		public bool HasPendingReceivedFollowRequest { get; set; }
		public decimal UnreadNotificationsCount { get; set; }
		public List<List<string>> MutedWords { get; set; }
		public List<List<string>> HardMutedWords { get; set; }
		public List<string> MutedInstances { get; set; }
		public class UserNotificationRecieveConfigObject {
			public JsonNode Note { get; set; }
			public JsonNode Follow { get; set; }
			public JsonNode Mention { get; set; }
			public JsonNode Reply { get; set; }
			public JsonNode Renote { get; set; }
			public JsonNode Quote { get; set; }
			public JsonNode Reaction { get; set; }
			public JsonNode PollEnded { get; set; }
			public JsonNode ReceiveFollowRequest { get; set; }
			public JsonNode FollowRequestAccepted { get; set; }
			public JsonNode RoleAssigned { get; set; }
			public JsonNode AchievementEarned { get; set; }
			public JsonNode App { get; set; }
			public JsonNode Test { get; set; }
		}
		public UserNotificationRecieveConfigObject NotificationRecieveConfig { get; set; }
		public List<string> EmailNotificationTypes { get; set; }
		public List<object> Achievements { get; set; }
		public decimal LoggedInDays { get; set; }
		public RolePolicies Policies { get; set; }
		public string Email { get; set; }
		public bool EmailVerified { get; set; }
		public List<object> SecurityKeysList { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class User: {\n");
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
			sb.Append($"  url: {this.Url}\n");
			sb.Append($"  uri: {this.Uri}\n");
			sb.Append($"  movedTo: {this.MovedTo}\n");
			sb.Append("  alsoKnownAs: {\n");
			if (this.AlsoKnownAs != null && this.AlsoKnownAs.Count > 0) this.AlsoKnownAs.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
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
			sb.Append("  fields: {\n");
			if (this.Fields != null && this.Fields.Count > 0) this.Fields.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  verifiedLinks: {\n");
			if (this.VerifiedLinks != null && this.VerifiedLinks.Count > 0) this.VerifiedLinks.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  followersCount: {this.FollowersCount}\n");
			sb.Append($"  followingCount: {this.FollowingCount}\n");
			sb.Append($"  notesCount: {this.NotesCount}\n");
			sb.Append("  pinnedNoteIds: {\n");
			if (this.PinnedNoteIds != null && this.PinnedNoteIds.Count > 0) this.PinnedNoteIds.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  pinnedNotes: {\n");
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
			sb.Append("  }\n");
			sb.Append($"  pinnedPageId: {this.PinnedPageId}\n");
			sb.Append($"  pinnedPage: {this.PinnedPage}\n");
			sb.Append($"  publicReactions: {this.PublicReactions}\n");
			sb.Append($"  followingVisibility: {this.FollowingVisibility}\n");
			sb.Append($"  followersVisibility: {this.FollowersVisibility}\n");
			sb.Append($"  twoFactorEnabled: {this.TwoFactorEnabled}\n");
			sb.Append($"  usePasswordLessLogin: {this.UsePasswordLessLogin}\n");
			sb.Append($"  securityKeys: {this.SecurityKeys}\n");
			sb.Append("  roles: {\n");
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
			sb.Append("  }\n");
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
			sb.Append($"  avatarId: {this.AvatarId}\n");
			sb.Append($"  bannerId: {this.BannerId}\n");
			sb.Append($"  isModerator: {this.IsModerator}\n");
			sb.Append($"  isAdmin: {this.IsAdmin}\n");
			sb.Append($"  injectFeaturedNote: {this.InjectFeaturedNote}\n");
			sb.Append($"  receiveAnnouncementEmail: {this.ReceiveAnnouncementEmail}\n");
			sb.Append($"  alwaysMarkNsfw: {this.AlwaysMarkNsfw}\n");
			sb.Append($"  autoSensitive: {this.AutoSensitive}\n");
			sb.Append($"  carefulBot: {this.CarefulBot}\n");
			sb.Append($"  autoAcceptFollowed: {this.AutoAcceptFollowed}\n");
			sb.Append($"  noCrawle: {this.NoCrawle}\n");
			sb.Append($"  preventAiLearning: {this.PreventAiLearning}\n");
			sb.Append($"  isExplorable: {this.IsExplorable}\n");
			sb.Append($"  isDeleted: {this.IsDeleted}\n");
			sb.Append($"  twoFactorBackupCodesStock: {this.TwoFactorBackupCodesStock}\n");
			sb.Append($"  hideOnlineStatus: {this.HideOnlineStatus}\n");
			sb.Append($"  hasUnreadSpecifiedNotes: {this.HasUnreadSpecifiedNotes}\n");
			sb.Append($"  hasUnreadMentions: {this.HasUnreadMentions}\n");
			sb.Append($"  hasUnreadAnnouncement: {this.HasUnreadAnnouncement}\n");
			sb.Append("  unreadAnnouncements: {\n");
			if (this.UnreadAnnouncements != null && this.UnreadAnnouncements.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.UnreadAnnouncements.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.UnreadAnnouncements.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  }\n");
			sb.Append($"  hasUnreadAntenna: {this.HasUnreadAntenna}\n");
			sb.Append($"  hasUnreadChannel: {this.HasUnreadChannel}\n");
			sb.Append($"  hasUnreadNotification: {this.HasUnreadNotification}\n");
			sb.Append($"  hasPendingReceivedFollowRequest: {this.HasPendingReceivedFollowRequest}\n");
			sb.Append($"  unreadNotificationsCount: {this.UnreadNotificationsCount}\n");
			sb.Append("  mutedWords: {\n");
			if (this.MutedWords != null && this.MutedWords.Count > 0) this.MutedWords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  hardMutedWords: {\n");
			if (this.HardMutedWords != null && this.HardMutedWords.Count > 0) this.HardMutedWords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  mutedInstances: {\n");
			if (this.MutedInstances != null && this.MutedInstances.Count > 0) this.MutedInstances.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  notificationRecieveConfig: {this.NotificationRecieveConfig}\n");
			sb.Append("  emailNotificationTypes: {\n");
			if (this.EmailNotificationTypes != null && this.EmailNotificationTypes.Count > 0) this.EmailNotificationTypes.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  achievements: {\n");
			if (this.Achievements != null && this.Achievements.Count > 0) this.Achievements.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  loggedInDays: {this.LoggedInDays}\n");
			var sbpolicies = new StringBuilder();
			sbpolicies.Append("  policies: {\n");
			if (this.Policies != null)
			{
				sbpolicies.Append(this.Policies);
				sbpolicies.Replace("\n", "\n    ");
				sbpolicies.Append("\n");
			}
			sbpolicies.Append("  }\n");
			sb.Append(sbpolicies);
			sb.Append($"  email: {this.Email}\n");
			sb.Append($"  emailVerified: {this.EmailVerified}\n");
			sb.Append("  securityKeysList: {\n");
			if (this.SecurityKeysList != null && this.SecurityKeysList.Count > 0) this.SecurityKeysList.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class MeDetailed {
		public string Id { get; set; }
		public string? Name { get; set; }
		public string Username { get; set; }
		public string? Host { get; set; }
		public string? AvatarUrl { get; set; }
		public string? AvatarBlurhash { get; set; }
		public class MeDetailedAvatarDecorationsPropertyType {
			public string Id { get; set; }
			public decimal Angle { get; set; }
			public bool FlipH { get; set; }
			public string Url { get; set; }
			public decimal OffsetX { get; set; }
			public decimal OffsetY { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MeDetailedAvatarDecorationsPropertyType: {\n");
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
		public List<MeDetailedAvatarDecorationsPropertyType> AvatarDecorations { get; set; }
		public bool IsBot { get; set; }
		public bool IsCat { get; set; }
		public class MeDetailedInstanceObject {
			public string? Name { get; set; }
			public string? SoftwareName { get; set; }
			public string? SoftwareVersion { get; set; }
			public string? IconUrl { get; set; }
			public string? FaviconUrl { get; set; }
			public string? ThemeColor { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MeDetailedInstanceObject: {\n");
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
		public MeDetailedInstanceObject Instance { get; set; }
		public Dictionary<string, string> Emojis { get; set; }
		public string OnlineStatus { get; set; }
		public class MeDetailedBadgeRolesPropertyType {
			public string Name { get; set; }
			public string? IconUrl { get; set; }
			public decimal DisplayOrder { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MeDetailedBadgeRolesPropertyType: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  iconUrl: {this.IconUrl}\n");
				sb.Append($"  displayOrder: {this.DisplayOrder}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<MeDetailedBadgeRolesPropertyType> BadgeRoles { get; set; }
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
		public class MeDetailedFieldsPropertyType {
			public string Name { get; set; }
			public string Value { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MeDetailedFieldsPropertyType: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  value: {this.Value}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<MeDetailedFieldsPropertyType> Fields { get; set; }
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
		public string? AvatarId { get; set; }
		public string? BannerId { get; set; }
		public bool? IsModerator { get; set; }
		public bool? IsAdmin { get; set; }
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
		public List<Announcement> UnreadAnnouncements { get; set; }
		public bool HasUnreadAntenna { get; set; }
		public bool HasUnreadChannel { get; set; }
		public bool HasUnreadNotification { get; set; }
		public bool HasPendingReceivedFollowRequest { get; set; }
		public decimal UnreadNotificationsCount { get; set; }
		public List<List<string>> MutedWords { get; set; }
		public List<List<string>> HardMutedWords { get; set; }
		public List<string>? MutedInstances { get; set; }
		public class MeDetailedNotificationRecieveConfigObject {
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
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MeDetailedNotificationRecieveConfigObject: {\n");
				var sbNote = new StringBuilder();
				sbNote.Append("  note: [\n");
				if (this.Note != null)
				{
					sbNote.Append(this.Note);
					sbNote.Replace("\n", "\n    ");
					sbNote.Append("\n");
				}
				sbNote.Append("  ]\n");
				sb.Append(sbNote);
				var sbFollow = new StringBuilder();
				sbFollow.Append("  follow: [\n");
				if (this.Follow != null)
				{
					sbFollow.Append(this.Follow);
					sbFollow.Replace("\n", "\n    ");
					sbFollow.Append("\n");
				}
				sbFollow.Append("  ]\n");
				sb.Append(sbFollow);
				var sbMention = new StringBuilder();
				sbMention.Append("  mention: [\n");
				if (this.Mention != null)
				{
					sbMention.Append(this.Mention);
					sbMention.Replace("\n", "\n    ");
					sbMention.Append("\n");
				}
				sbMention.Append("  ]\n");
				sb.Append(sbMention);
				var sbReply = new StringBuilder();
				sbReply.Append("  reply: [\n");
				if (this.Reply != null)
				{
					sbReply.Append(this.Reply);
					sbReply.Replace("\n", "\n    ");
					sbReply.Append("\n");
				}
				sbReply.Append("  ]\n");
				sb.Append(sbReply);
				var sbRenote = new StringBuilder();
				sbRenote.Append("  renote: [\n");
				if (this.Renote != null)
				{
					sbRenote.Append(this.Renote);
					sbRenote.Replace("\n", "\n    ");
					sbRenote.Append("\n");
				}
				sbRenote.Append("  ]\n");
				sb.Append(sbRenote);
				var sbQuote = new StringBuilder();
				sbQuote.Append("  quote: [\n");
				if (this.Quote != null)
				{
					sbQuote.Append(this.Quote);
					sbQuote.Replace("\n", "\n    ");
					sbQuote.Append("\n");
				}
				sbQuote.Append("  ]\n");
				sb.Append(sbQuote);
				var sbReaction = new StringBuilder();
				sbReaction.Append("  reaction: [\n");
				if (this.Reaction != null)
				{
					sbReaction.Append(this.Reaction);
					sbReaction.Replace("\n", "\n    ");
					sbReaction.Append("\n");
				}
				sbReaction.Append("  ]\n");
				sb.Append(sbReaction);
				var sbPollEnded = new StringBuilder();
				sbPollEnded.Append("  pollEnded: [\n");
				if (this.PollEnded != null)
				{
					sbPollEnded.Append(this.PollEnded);
					sbPollEnded.Replace("\n", "\n    ");
					sbPollEnded.Append("\n");
				}
				sbPollEnded.Append("  ]\n");
				sb.Append(sbPollEnded);
				var sbReceiveFollowRequest = new StringBuilder();
				sbReceiveFollowRequest.Append("  receiveFollowRequest: [\n");
				if (this.ReceiveFollowRequest != null)
				{
					sbReceiveFollowRequest.Append(this.ReceiveFollowRequest);
					sbReceiveFollowRequest.Replace("\n", "\n    ");
					sbReceiveFollowRequest.Append("\n");
				}
				sbReceiveFollowRequest.Append("  ]\n");
				sb.Append(sbReceiveFollowRequest);
				var sbFollowRequestAccepted = new StringBuilder();
				sbFollowRequestAccepted.Append("  followRequestAccepted: [\n");
				if (this.FollowRequestAccepted != null)
				{
					sbFollowRequestAccepted.Append(this.FollowRequestAccepted);
					sbFollowRequestAccepted.Replace("\n", "\n    ");
					sbFollowRequestAccepted.Append("\n");
				}
				sbFollowRequestAccepted.Append("  ]\n");
				sb.Append(sbFollowRequestAccepted);
				var sbRoleAssigned = new StringBuilder();
				sbRoleAssigned.Append("  roleAssigned: [\n");
				if (this.RoleAssigned != null)
				{
					sbRoleAssigned.Append(this.RoleAssigned);
					sbRoleAssigned.Replace("\n", "\n    ");
					sbRoleAssigned.Append("\n");
				}
				sbRoleAssigned.Append("  ]\n");
				sb.Append(sbRoleAssigned);
				var sbAchievementEarned = new StringBuilder();
				sbAchievementEarned.Append("  achievementEarned: [\n");
				if (this.AchievementEarned != null)
				{
					sbAchievementEarned.Append(this.AchievementEarned);
					sbAchievementEarned.Replace("\n", "\n    ");
					sbAchievementEarned.Append("\n");
				}
				sbAchievementEarned.Append("  ]\n");
				sb.Append(sbAchievementEarned);
				var sbApp = new StringBuilder();
				sbApp.Append("  app: [\n");
				if (this.App != null)
				{
					sbApp.Append(this.App);
					sbApp.Replace("\n", "\n    ");
					sbApp.Append("\n");
				}
				sbApp.Append("  ]\n");
				sb.Append(sbApp);
				var sbTest = new StringBuilder();
				sbTest.Append("  test: [\n");
				if (this.Test != null)
				{
					sbTest.Append(this.Test);
					sbTest.Replace("\n", "\n    ");
					sbTest.Append("\n");
				}
				sbTest.Append("  ]\n");
				sb.Append(sbTest);
				sb.Append("}");
				return sb.ToString();
			}
		}
		public MeDetailedNotificationRecieveConfigObject NotificationRecieveConfig { get; set; }
		public List<string> EmailNotificationTypes { get; set; }
		public class MeDetailedAchievementsPropertyType {
			public string Name { get; set; }
			public decimal UnlockedAt { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MeDetailedAchievementsPropertyType: {\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  unlockedAt: {this.UnlockedAt}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<MeDetailedAchievementsPropertyType> Achievements { get; set; }
		public decimal LoggedInDays { get; set; }
		public RolePolicies Policies { get; set; }
		public string? Email { get; set; }
		public bool? EmailVerified { get; set; }
		public class MeDetailedSecurityKeysListPropertyType {
			public string Id { get; set; }
			public string Name { get; set; }
			public DateTime LastUsed { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MeDetailedSecurityKeysListPropertyType: {\n");
				sb.Append($"  id: {this.Id}\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append($"  lastUsed: {this.LastUsed}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<MeDetailedSecurityKeysListPropertyType> SecurityKeysList { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MeDetailed: {\n");
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
			sb.Append("  unreadAnnouncements: [\n");
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
			sb.Append("  ]\n");
			sb.Append($"  hasUnreadAntenna: {this.HasUnreadAntenna}\n");
			sb.Append($"  hasUnreadChannel: {this.HasUnreadChannel}\n");
			sb.Append($"  hasUnreadNotification: {this.HasUnreadNotification}\n");
			sb.Append($"  hasPendingReceivedFollowRequest: {this.HasPendingReceivedFollowRequest}\n");
			sb.Append($"  unreadNotificationsCount: {this.UnreadNotificationsCount}\n");
			sb.Append("  mutedWords: [\n");
			if (this.MutedWords != null && this.MutedWords.Count > 0)
			{
				var sbMutedWords = new StringBuilder();
				sbMutedWords.Append("    ");
				this.MutedWords.ForEach(item => sbMutedWords.Append(item).Append(",\n"));
				sbMutedWords.Replace("\n", "\n    ");
				sbMutedWords.Length -= 4;
				sb.Append(sbMutedWords);
			}
			sb.Append("  ]\n");
			sb.Append("  hardMutedWords: [\n");
			if (this.HardMutedWords != null && this.HardMutedWords.Count > 0)
			{
				var sbHardMutedWords = new StringBuilder();
				sbHardMutedWords.Append("    ");
				this.HardMutedWords.ForEach(item => sbHardMutedWords.Append(item).Append(",\n"));
				sbHardMutedWords.Replace("\n", "\n    ");
				sbHardMutedWords.Length -= 4;
				sb.Append(sbHardMutedWords);
			}
			sb.Append("  ]\n");
			sb.Append("  mutedInstances: [\n");
			if (this.MutedInstances != null && this.MutedInstances.Count > 0)
			{
				var sbMutedInstances = new StringBuilder();
				sbMutedInstances.Append("    ");
				this.MutedInstances.ForEach(item => sbMutedInstances.Append(item).Append(",\n"));
				sbMutedInstances.Replace("\n", "\n    ");
				sbMutedInstances.Length -= 4;
				sb.Append(sbMutedInstances);
			}
			sb.Append("  ]\n");
			var sbNotificationRecieveConfig = new StringBuilder();
			sbNotificationRecieveConfig.Append("  notificationRecieveConfig: [\n");
			if (this.NotificationRecieveConfig != null)
			{
				sbNotificationRecieveConfig.Append(this.NotificationRecieveConfig);
				sbNotificationRecieveConfig.Replace("\n", "\n    ");
				sbNotificationRecieveConfig.Append("\n");
			}
			sbNotificationRecieveConfig.Append("  ]\n");
			sb.Append(sbNotificationRecieveConfig);
			sb.Append("  emailNotificationTypes: [\n");
			if (this.EmailNotificationTypes != null && this.EmailNotificationTypes.Count > 0)
			{
				var sbEmailNotificationTypes = new StringBuilder();
				sbEmailNotificationTypes.Append("    ");
				this.EmailNotificationTypes.ForEach(item => sbEmailNotificationTypes.Append(item).Append(",\n"));
				sbEmailNotificationTypes.Replace("\n", "\n    ");
				sbEmailNotificationTypes.Length -= 4;
				sb.Append(sbEmailNotificationTypes);
			}
			sb.Append("  ]\n");
			sb.Append("  achievements: [\n");
			if (this.Achievements != null && this.Achievements.Count > 0)
			{
				var sbAchievements = new StringBuilder();
				sbAchievements.Append("    ");
				this.Achievements.ForEach(item => sbAchievements.Append(item).Append(",\n"));
				sbAchievements.Replace("\n", "\n    ");
				sbAchievements.Length -= 4;
				sb.Append(sbAchievements);
			}
			sb.Append("  ]\n");
			sb.Append($"  loggedInDays: {this.LoggedInDays}\n");
			var sbPolicies = new StringBuilder();
			sbPolicies.Append("  policies: [\n");
			if (this.Policies != null)
			{
				sbPolicies.Append(this.Policies);
				sbPolicies.Replace("\n", "\n    ");
				sbPolicies.Append("\n");
			}
			sbPolicies.Append("  ]\n");
			sb.Append(sbPolicies);
			sb.Append($"  email: {this.Email}\n");
			sb.Append($"  emailVerified: {this.EmailVerified}\n");
			sb.Append("  securityKeysList: [\n");
			if (this.SecurityKeysList != null && this.SecurityKeysList.Count > 0)
			{
				var sbSecurityKeysList = new StringBuilder();
				sbSecurityKeysList.Append("    ");
				this.SecurityKeysList.ForEach(item => sbSecurityKeysList.Append(item).Append(",\n"));
				sbSecurityKeysList.Replace("\n", "\n    ");
				sbSecurityKeysList.Length -= 4;
				sb.Append(sbSecurityKeysList);
			}
			sb.Append("  ]\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

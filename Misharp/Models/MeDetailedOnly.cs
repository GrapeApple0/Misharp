using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class MeDetailedOnly {
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
		public List<Model.Announcement> UnreadAnnouncements { get; set; }
		public bool HasUnreadAntenna { get; set; }
		public bool HasUnreadChannel { get; set; }
		public bool HasUnreadNotification { get; set; }
		public bool HasPendingReceivedFollowRequest { get; set; }
		public decimal UnreadNotificationsCount { get; set; }
		public List<List<string>> MutedWords { get; set; }
		public List<List<string>> HardMutedWords { get; set; }
		public List<string>? MutedInstances { get; set; }
		public class MeDetailedOnlyNotificationRecieveConfigObject {
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
					sb.Append("class MeDetailedOnlyNotificationRecieveConfigObject: {\n");
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
		public MeDetailedOnlyNotificationRecieveConfigObject NotificationRecieveConfig { get; set; }
		public List<string> EmailNotificationTypes { get; set; }
		public class MeDetailedOnlyAchievementsPropertyType {
			public string Name { get; set; }
			public decimal UnlockedAt { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class MeDetailedOnlyAchievementsPropertyType: {\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  unlockedAt: {this.UnlockedAt}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public List<MeDetailedOnlyAchievementsPropertyType> Achievements { get; set; }
		public decimal LoggedInDays { get; set; }
		public Model.RolePolicies Policies { get; set; }
		public string? Email { get; set; }
		public bool? EmailVerified { get; set; }
		public class MeDetailedOnlySecurityKeysListPropertyType {
			public string Id { get; set; }
			public string Name { get; set; }
			public DateTime LastUsed { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class MeDetailedOnlySecurityKeysListPropertyType: {\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  lastUsed: {this.LastUsed}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public List<MeDetailedOnlySecurityKeysListPropertyType> SecurityKeysList { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MeDetailedOnly: {\n");
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

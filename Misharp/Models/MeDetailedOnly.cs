using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class MeDetailedOnly {
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
		public List<Announcement> UnreadAnnouncements { get; set; }
		public bool HasUnreadAntenna { get; set; }
		public bool HasUnreadChannel { get; set; }
		public bool HasUnreadNotification { get; set; }
		public bool HasPendingReceivedFollowRequest { get; set; }
		public decimal UnreadNotificationsCount { get; set; }
		public class MutedWordsItemsItemType {
			public string MutedWords { get; set; }
		}
		public List<List<MutedWordsItemsItemType>> MutedWords { get; set; }
		public class HardMutedWordsItemsItemType {
			public string HardMutedWords { get; set; }
		}
		public List<List<HardMutedWordsItemsItemType>> HardMutedWords { get; set; }
		public List<string> MutedInstances { get; set; }
		public object NotificationRecieveConfig { get; set; }
		public List<string> EmailNotificationTypes { get; set; }
		public class AchievementsItemType {
			public object Achievements { get; set; }
		}
		public List<AchievementsItemType> Achievements { get; set; }
		public decimal LoggedInDays { get; set; }
		public object Policies { get; set; }
		public string Email { get; set; }
		public bool EmailVerified { get; set; }
		public class SecurityKeysListItemType {
			public object SecurityKeysList { get; set; }
		}
		public List<SecurityKeysListItemType> SecurityKeysList { get; set; }
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
			sb.Append($"  policies: {this.Policies}\n");
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

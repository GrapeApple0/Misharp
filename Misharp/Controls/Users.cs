using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class UsersApi {
		private Misharp.App _app;
		public Users.GalleryApi GalleryApi;
		public Users.ListsApi ListsApi;
		public UsersApi(Misharp.App app)
		{
			_app = app;
			GalleryApi = new Users.GalleryApi(_app);
			ListsApi = new Users.ListsApi(_app);
		}
		public async Task<Response<List<Model.UserDetailed>>> Users(UsersSortEnum sort,int limit = 10,int offset = 0,UsersStateEnum state = UsersStateEnum.All,UsersOriginEnum origin = UsersOriginEnum.Local,string? hostname = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "offset", offset },
				{ "sort", sort },
				{ "state", state },
				{ "origin", origin },
				{ "hostname", hostname },
			};
			Response<List<Model.UserDetailed>> result = await _app.Request<List<Model.UserDetailed>>("users", param, useToken: false);
			return result;
		}
		public enum UsersSortEnum {
			[StringValue("+follower")]
			Plusfollower,
			[StringValue("-follower")]
			Minusfollower,
			[StringValue("+createdAt")]
			PluscreatedAt,
			[StringValue("-createdAt")]
			MinuscreatedAt,
			[StringValue("+updatedAt")]
			PlusupdatedAt,
			[StringValue("-updatedAt")]
			MinusupdatedAt,
		}
		public enum UsersStateEnum {
			[StringValue("all")]
			All,
			[StringValue("alive")]
			Alive,
		}
		public enum UsersOriginEnum {
			[StringValue("combined")]
			Combined,
			[StringValue("local")]
			Local,
			[StringValue("remote")]
			Remote,
		}
		public async Task<Response<List<Model.Clip>>> Clips(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Clip>> result = await _app.Request<List<Model.Clip>>("users/clips", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Following>>> Followers(string userId,string username,string? sinceId = null,string? untilId = null,int limit = 10,string? host = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "userId", userId },
				{ "username", username },
				{ "host", host },
			};
			Response<List<Model.Following>> result = await _app.Request<List<Model.Following>>("users/followers", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Following>>> Following(string userId,string username,string? sinceId = null,string? untilId = null,int limit = 10,string? host = null,string? birthday = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "userId", userId },
				{ "username", username },
				{ "host", host },
				{ "birthday", birthday },
			};
			Response<List<Model.Following>> result = await _app.Request<List<Model.Following>>("users/following", param, useToken: false);
			return result;
		}
		public async Task<Response<List<object>>> GetFrequentlyRepliedUsers(string userId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "limit", limit },
			};
			Response<List<object>> result = await _app.Request<List<object>>("users/get-frequently-replied-users", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> FeaturedNotes(string userId,int limit = 10,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "untilId", untilId },
				{ "userId", userId },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("users/featured-notes", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Notes(string userId,bool withReplies = false,bool withRenotes = true,bool withChannelNotes = false,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool withFiles = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "withReplies", withReplies },
				{ "withRenotes", withRenotes },
				{ "withChannelNotes", withChannelNotes },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "withFiles", withFiles },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("users/notes", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Page>>> Pages(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Page>> result = await _app.Request<List<Model.Page>>("users/pages", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Flash>>> Flashs(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Flash>> result = await _app.Request<List<Model.Flash>>("users/flashs", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.NoteReaction>>> Reactions(string userId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			Response<List<Model.NoteReaction>> result = await _app.Request<List<Model.NoteReaction>>("users/reactions", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.UserDetailed>>> Recommendation(int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "offset", offset },
			};
			Response<List<Model.UserDetailed>> result = await _app.Request<List<Model.UserDetailed>>("users/recommendation", param, useToken: true);
			return result;
		}
		public class UsersRelationResponse {
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<UsersRelationResponse>> Relation(JsonNode userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			Response<UsersRelationResponse> result = await _app.Request<UsersRelationResponse>("users/relation", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ReportAbuse(string userId,string comment)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "comment", comment },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/report-abuse", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.User>>> SearchByUsernameAndHost(int limit = 10,bool detail = true,string? username = null,string? host = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "detail", detail },
				{ "username", username },
				{ "host", host },
			};
			Response<List<Model.User>> result = await _app.Request<List<Model.User>>("users/search-by-username-and-host", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.User>>> Search(string query,int offset = 0,int limit = 10,SearchOriginEnum origin = SearchOriginEnum.Combined,bool detail = true)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "query", query },
				{ "offset", offset },
				{ "limit", limit },
				{ "origin", origin },
				{ "detail", detail },
			};
			Response<List<Model.User>> result = await _app.Request<List<Model.User>>("users/search", param, useToken: false);
			return result;
		}
		public enum SearchOriginEnum {
			[StringValue("local")]
			Local,
			[StringValue("remote")]
			Remote,
			[StringValue("combined")]
			Combined,
		}
		public class UsersShowResponse {
			public string Id { get; set; }
			public string? Name { get; set; }
			public string Username { get; set; }
			public string? Host { get; set; }
			public string? AvatarUrl { get; set; }
			public string? AvatarBlurhash { get; set; }
			public class AvatarDecorationsItemsProperty {
				public string Id { get; set; }
				public decimal Angle { get; set; }
				public bool FlipH { get; set; }
				public string Url { get; set; }
				public decimal OffsetX { get; set; }
				public decimal OffsetY { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("{\n");
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
			public List<AvatarDecorationsItemsProperty> AvatarDecorations { get; set; }
			public bool IsBot { get; set; }
			public bool IsCat { get; set; }
		public class InstanceProperty {
			public string? Name { get; set; }
			public string? SoftwareName { get; set; }
			public string? SoftwareVersion { get; set; }
			public string? IconUrl { get; set; }
			public string? FaviconUrl { get; set; }
			public string? ThemeColor { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
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
			public InstanceProperty Instance { get; set; }
			public object Emojis { get; set; }
			public string OnlineStatus { get; set; }
			public class BadgeRolesItemsProperty {
				public string Name { get; set; }
				public string? IconUrl { get; set; }
				public decimal DisplayOrder { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("{\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  iconUrl: {this.IconUrl}\n");
					sb.Append($"  displayOrder: {this.DisplayOrder}\n");
					sb.Append("}");
					return sb.ToString();
				}
			}
			public List<BadgeRolesItemsProperty> BadgeRoles { get; set; }
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
			public class FieldsItemsProperty {
				public string Name { get; set; }
				public string Value { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("{\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  value: {this.Value}\n");
					sb.Append("}");
					return sb.ToString();
				}
			}
			public List<FieldsItemsProperty> Fields { get; set; }
			public List<string> VerifiedLinks { get; set; }
			public decimal FollowersCount { get; set; }
			public decimal FollowingCount { get; set; }
			public decimal NotesCount { get; set; }
			public List<string> PinnedNoteIds { get; set; }
			public List<Model.Note> PinnedNotes { get; set; }
			public string? PinnedPageId { get; set; }
			public object? PinnedPage { get; set; }
			public bool PublicReactions { get; set; }
			public string FollowingVisibility { get; set; }
			public string FollowersVisibility { get; set; }
			public bool TwoFactorEnabled { get; set; }
			public bool UsePasswordLessLogin { get; set; }
			public bool SecurityKeys { get; set; }
			public List<Model.RoleLite> Roles { get; set; }
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
			public List<Model.Announcement> UnreadAnnouncements { get; set; }
			public bool HasUnreadAntenna { get; set; }
			public bool HasUnreadChannel { get; set; }
			public bool HasUnreadNotification { get; set; }
			public bool HasPendingReceivedFollowRequest { get; set; }
			public decimal UnreadNotificationsCount { get; set; }
			public List<List<string>> MutedWords { get; set; }
			public List<List<string>> HardMutedWords { get; set; }
			public List<string>? MutedInstances { get; set; }
		public class NotificationRecieveConfigProperty {
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
				sb.Append("{\n");
				var sbnote = new StringBuilder();
				sbnote.Append("  note: {\n");
				if (this.Note != null)
				{
					sbnote.Append(this.Note);
					sbnote.Replace("\n", "\n  ");
					sbnote.Append("\n");
				}
				sbnote.Append("  }\n");
				sb.Append(sbnote);
				var sbfollow = new StringBuilder();
				sbfollow.Append("  follow: {\n");
				if (this.Follow != null)
				{
					sbfollow.Append(this.Follow);
					sbfollow.Replace("\n", "\n  ");
					sbfollow.Append("\n");
				}
				sbfollow.Append("  }\n");
				sb.Append(sbfollow);
				var sbmention = new StringBuilder();
				sbmention.Append("  mention: {\n");
				if (this.Mention != null)
				{
					sbmention.Append(this.Mention);
					sbmention.Replace("\n", "\n  ");
					sbmention.Append("\n");
				}
				sbmention.Append("  }\n");
				sb.Append(sbmention);
				var sbreply = new StringBuilder();
				sbreply.Append("  reply: {\n");
				if (this.Reply != null)
				{
					sbreply.Append(this.Reply);
					sbreply.Replace("\n", "\n  ");
					sbreply.Append("\n");
				}
				sbreply.Append("  }\n");
				sb.Append(sbreply);
				var sbrenote = new StringBuilder();
				sbrenote.Append("  renote: {\n");
				if (this.Renote != null)
				{
					sbrenote.Append(this.Renote);
					sbrenote.Replace("\n", "\n  ");
					sbrenote.Append("\n");
				}
				sbrenote.Append("  }\n");
				sb.Append(sbrenote);
				var sbquote = new StringBuilder();
				sbquote.Append("  quote: {\n");
				if (this.Quote != null)
				{
					sbquote.Append(this.Quote);
					sbquote.Replace("\n", "\n  ");
					sbquote.Append("\n");
				}
				sbquote.Append("  }\n");
				sb.Append(sbquote);
				var sbreaction = new StringBuilder();
				sbreaction.Append("  reaction: {\n");
				if (this.Reaction != null)
				{
					sbreaction.Append(this.Reaction);
					sbreaction.Replace("\n", "\n  ");
					sbreaction.Append("\n");
				}
				sbreaction.Append("  }\n");
				sb.Append(sbreaction);
				var sbpollEnded = new StringBuilder();
				sbpollEnded.Append("  pollEnded: {\n");
				if (this.PollEnded != null)
				{
					sbpollEnded.Append(this.PollEnded);
					sbpollEnded.Replace("\n", "\n  ");
					sbpollEnded.Append("\n");
				}
				sbpollEnded.Append("  }\n");
				sb.Append(sbpollEnded);
				var sbreceiveFollowRequest = new StringBuilder();
				sbreceiveFollowRequest.Append("  receiveFollowRequest: {\n");
				if (this.ReceiveFollowRequest != null)
				{
					sbreceiveFollowRequest.Append(this.ReceiveFollowRequest);
					sbreceiveFollowRequest.Replace("\n", "\n  ");
					sbreceiveFollowRequest.Append("\n");
				}
				sbreceiveFollowRequest.Append("  }\n");
				sb.Append(sbreceiveFollowRequest);
				var sbfollowRequestAccepted = new StringBuilder();
				sbfollowRequestAccepted.Append("  followRequestAccepted: {\n");
				if (this.FollowRequestAccepted != null)
				{
					sbfollowRequestAccepted.Append(this.FollowRequestAccepted);
					sbfollowRequestAccepted.Replace("\n", "\n  ");
					sbfollowRequestAccepted.Append("\n");
				}
				sbfollowRequestAccepted.Append("  }\n");
				sb.Append(sbfollowRequestAccepted);
				var sbroleAssigned = new StringBuilder();
				sbroleAssigned.Append("  roleAssigned: {\n");
				if (this.RoleAssigned != null)
				{
					sbroleAssigned.Append(this.RoleAssigned);
					sbroleAssigned.Replace("\n", "\n  ");
					sbroleAssigned.Append("\n");
				}
				sbroleAssigned.Append("  }\n");
				sb.Append(sbroleAssigned);
				var sbachievementEarned = new StringBuilder();
				sbachievementEarned.Append("  achievementEarned: {\n");
				if (this.AchievementEarned != null)
				{
					sbachievementEarned.Append(this.AchievementEarned);
					sbachievementEarned.Replace("\n", "\n  ");
					sbachievementEarned.Append("\n");
				}
				sbachievementEarned.Append("  }\n");
				sb.Append(sbachievementEarned);
				var sbapp = new StringBuilder();
				sbapp.Append("  app: {\n");
				if (this.App != null)
				{
					sbapp.Append(this.App);
					sbapp.Replace("\n", "\n  ");
					sbapp.Append("\n");
				}
				sbapp.Append("  }\n");
				sb.Append(sbapp);
				var sbtest = new StringBuilder();
				sbtest.Append("  test: {\n");
				if (this.Test != null)
				{
					sbtest.Append(this.Test);
					sbtest.Replace("\n", "\n  ");
					sbtest.Append("\n");
				}
				sbtest.Append("  }\n");
				sb.Append(sbtest);
				sb.Append("}");
				return sb.ToString();
			}
		}
			public NotificationRecieveConfigProperty NotificationRecieveConfig { get; set; }
			public List<string> EmailNotificationTypes { get; set; }
			public class AchievementsItemsProperty {
				public string Name { get; set; }
				public decimal UnlockedAt { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("{\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  unlockedAt: {this.UnlockedAt}\n");
					sb.Append("}");
					return sb.ToString();
				}
			}
			public List<AchievementsItemsProperty> Achievements { get; set; }
			public decimal LoggedInDays { get; set; }
			public Model.RolePolicies Policies { get; set; }
			public string? Email { get; set; }
			public bool? EmailVerified { get; set; }
			public class SecurityKeysListItemsProperty {
				public string Id { get; set; }
				public string Name { get; set; }
				public DateTime LastUsed { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("{\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  lastUsed: {this.LastUsed}\n");
					sb.Append("}");
					return sb.ToString();
				}
			}
			public List<SecurityKeysListItemsProperty> SecurityKeysList { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
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
				var sbinstance = new StringBuilder();
				sbinstance.Append("  instance: {\n");
				if (this.Instance != null)
				{
					sbinstance.Append(this.Instance);
					sbinstance.Replace("\n", "\n  ");
					sbinstance.Append("\n");
				}
				sbinstance.Append("  }\n");
				sb.Append(sbinstance);
				var sbemojis = new StringBuilder();
				sbemojis.Append("  emojis: {\n");
				if (this.Emojis != null)
				{
					sbemojis.Append(this.Emojis);
					sbemojis.Replace("\n", "\n  ");
					sbemojis.Append("\n");
				}
				sbemojis.Append("  }\n");
				sb.Append(sbemojis);
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
				var sbpinnedPage = new StringBuilder();
				sbpinnedPage.Append("  pinnedPage: {\n");
				if (this.PinnedPage != null)
				{
					sbpinnedPage.Append(this.PinnedPage);
					sbpinnedPage.Replace("\n", "\n  ");
					sbpinnedPage.Append("\n");
				}
				sbpinnedPage.Append("  }\n");
				sb.Append(sbpinnedPage);
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
				var sbnotificationRecieveConfig = new StringBuilder();
				sbnotificationRecieveConfig.Append("  notificationRecieveConfig: {\n");
				if (this.NotificationRecieveConfig != null)
				{
					sbnotificationRecieveConfig.Append(this.NotificationRecieveConfig);
					sbnotificationRecieveConfig.Replace("\n", "\n  ");
					sbnotificationRecieveConfig.Append("\n");
				}
				sbnotificationRecieveConfig.Append("  }\n");
				sb.Append(sbnotificationRecieveConfig);
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
					sbpolicies.Replace("\n", "\n  ");
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
		public async Task<Response<UsersShowResponse>> Show(string userId,string username,List<string>? userIds = null,string? host = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "userIds", userIds },
				{ "username", username },
				{ "host", host },
			};
			Response<UsersShowResponse> result = await _app.Request<UsersShowResponse>("users/show", param, useToken: false);
			return result;
		}
		public async Task<Response<List<object>>> Achievements(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			Response<List<object>> result = await _app.Request<List<object>>("users/achievements", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> UpdateMemo(string userId,string? memo = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "memo", memo },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/update-memo", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
namespace Misharp.Controls.Users {
	public class GalleryApi
	{
		private Misharp.App _app;
		public GalleryApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.GalleryPost>>> Posts(string userId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Model.GalleryPost>>("users/gallery/posts", param, useToken: false);
			return result;
		}
	}
	public class ListsApi
	{
		private Misharp.App _app;
		public ListsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.UserList>> Create(string name)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
			};
			var result = await _app.Request<Model.UserList>("users/lists/create", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string listId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/lists/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.UserList>>> List(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<List<Model.UserList>>("users/lists/list", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Pull(string listId,string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/lists/pull", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Push(string listId,string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/lists/push", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserList>> Show(string listId,bool forPublic = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "forPublic", forPublic },
			};
			var result = await _app.Request<Model.UserList>("users/lists/show", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Favorite(string listId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/lists/favorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unfavorite(string listId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/lists/unfavorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserList>> Update(string listId,string name,bool isPublic)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "name", name },
				{ "isPublic", isPublic },
			};
			var result = await _app.Request<Model.UserList>("users/lists/update", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserList>> CreateFromPublic(string name,string listId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "listId", listId },
			};
			var result = await _app.Request<Model.UserList>("users/lists/create-from-public", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> UpdateMembership(string listId,string userId,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "userId", userId },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<Model.EmptyResponse>("users/lists/update-membership", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<object>>> GetMemberships(string listId,bool forPublic = false,int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "forPublic", forPublic },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<object>>("users/lists/get-memberships", param, useToken: false);
			return result;
		}
	}
}
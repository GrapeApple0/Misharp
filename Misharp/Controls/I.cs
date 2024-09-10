using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class IApi {
		private Misharp.App _app;
		public I.GalleryApi GalleryApi;
		public I.RegistryApi RegistryApi;
		public I.WebhooksApi WebhooksApi;
		public IApi(Misharp.App app)
		{
			_app = app;
			GalleryApi = new I.GalleryApi(_app);
			RegistryApi = new I.RegistryApi(_app);
			WebhooksApi = new I.WebhooksApi(_app);
		}
		public async Task<Response<Model.MeDetailed>> I()
		{
			var result = await _app.Request<Model.MeDetailed>("i", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class AppsItemResponseObject {
			public string Id { get; set; }
			public string Name { get; set; }
			public DateTime CreatedAt { get; set; }
			public DateTime LastUsedAt { get; set; }
			public UniqueList<string> Permission { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class AppsItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  createdAt: {this.CreatedAt}\n");
					sb.Append($"  lastUsedAt: {this.LastUsedAt}\n");
					sb.Append("  permission: [\n");
					if (this.Permission != null && this.Permission.Count > 0)
					{
						var sbPermission = new StringBuilder();
						sbPermission.Append("    ");
						this.Permission.ForEach(item => sbPermission.Append(item).Append(",\n"));
						sbPermission.Replace("\n", "\n    ");
						sbPermission.Length -= 4;
						sb.Append(sbPermission);
					}
					sb.Append("  ]\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<AppsItemResponseObject>>> Apps(AppsSortEnum sort)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sort", sort },
			};
			var result = await _app.Request<List<AppsItemResponseObject>>("i/apps", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum AppsSortEnum {
			[StringValue("+createdAt")]
			PluscreatedAt,
			[StringValue("-createdAt")]
			MinuscreatedAt,
			[StringValue("+lastUsedAt")]
			PluslastUsedAt,
			[StringValue("-lastUsedAt")]
			MinuslastUsedAt,
		}
		public class AuthorizedAppsItemResponseObject {
			public string Id { get; set; }
			public string Name { get; set; }
			public string? CallbackUrl { get; set; }
			public UniqueList<string> Permission { get; set; }
			public bool IsAuthorized { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class AuthorizedAppsItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  callbackUrl: {this.CallbackUrl}\n");
					sb.Append("  permission: [\n");
					if (this.Permission != null && this.Permission.Count > 0)
					{
						var sbPermission = new StringBuilder();
						sbPermission.Append("    ");
						this.Permission.ForEach(item => sbPermission.Append(item).Append(",\n"));
						sbPermission.Replace("\n", "\n    ");
						sbPermission.Length -= 4;
						sb.Append(sbPermission);
					}
					sb.Append("  ]\n");
					sb.Append($"  isAuthorized: {this.IsAuthorized}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<AuthorizedAppsItemResponseObject>>> AuthorizedApps(int limit = 10,int offset = 0,AuthorizedAppsSortEnum sort = AuthorizedAppsSortEnum.Desc)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "offset", offset },
				{ "sort", sort },
			};
			var result = await _app.Request<List<AuthorizedAppsItemResponseObject>>("i/authorized-apps", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum AuthorizedAppsSortEnum {
			[StringValue("desc")]
			Desc,
			[StringValue("asc")]
			Asc,
		}
		public async Task<Response<Model.EmptyResponse>> ClaimAchievement(ClaimAchievementNameEnum name)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/claim-achievement", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum ClaimAchievementNameEnum {
			[StringValue("notes1")]
			Notes1,
			[StringValue("notes10")]
			Notes10,
			[StringValue("notes100")]
			Notes100,
			[StringValue("notes500")]
			Notes500,
			[StringValue("notes1000")]
			Notes1000,
			[StringValue("notes5000")]
			Notes5000,
			[StringValue("notes10000")]
			Notes10000,
			[StringValue("notes20000")]
			Notes20000,
			[StringValue("notes30000")]
			Notes30000,
			[StringValue("notes40000")]
			Notes40000,
			[StringValue("notes50000")]
			Notes50000,
			[StringValue("notes60000")]
			Notes60000,
			[StringValue("notes70000")]
			Notes70000,
			[StringValue("notes80000")]
			Notes80000,
			[StringValue("notes90000")]
			Notes90000,
			[StringValue("notes100000")]
			Notes100000,
			[StringValue("login3")]
			Login3,
			[StringValue("login7")]
			Login7,
			[StringValue("login15")]
			Login15,
			[StringValue("login30")]
			Login30,
			[StringValue("login60")]
			Login60,
			[StringValue("login100")]
			Login100,
			[StringValue("login200")]
			Login200,
			[StringValue("login300")]
			Login300,
			[StringValue("login400")]
			Login400,
			[StringValue("login500")]
			Login500,
			[StringValue("login600")]
			Login600,
			[StringValue("login700")]
			Login700,
			[StringValue("login800")]
			Login800,
			[StringValue("login900")]
			Login900,
			[StringValue("login1000")]
			Login1000,
			[StringValue("passedSinceAccountCreated1")]
			PassedSinceAccountCreated1,
			[StringValue("passedSinceAccountCreated2")]
			PassedSinceAccountCreated2,
			[StringValue("passedSinceAccountCreated3")]
			PassedSinceAccountCreated3,
			[StringValue("loggedInOnBirthday")]
			LoggedInOnBirthday,
			[StringValue("loggedInOnNewYearsDay")]
			LoggedInOnNewYearsDay,
			[StringValue("noteClipped1")]
			NoteClipped1,
			[StringValue("noteFavorited1")]
			NoteFavorited1,
			[StringValue("myNoteFavorited1")]
			MyNoteFavorited1,
			[StringValue("profileFilled")]
			ProfileFilled,
			[StringValue("markedAsCat")]
			MarkedAsCat,
			[StringValue("following1")]
			Following1,
			[StringValue("following10")]
			Following10,
			[StringValue("following50")]
			Following50,
			[StringValue("following100")]
			Following100,
			[StringValue("following300")]
			Following300,
			[StringValue("followers1")]
			Followers1,
			[StringValue("followers10")]
			Followers10,
			[StringValue("followers50")]
			Followers50,
			[StringValue("followers100")]
			Followers100,
			[StringValue("followers300")]
			Followers300,
			[StringValue("followers500")]
			Followers500,
			[StringValue("followers1000")]
			Followers1000,
			[StringValue("collectAchievements30")]
			CollectAchievements30,
			[StringValue("viewAchievements3min")]
			ViewAchievements3min,
			[StringValue("iLoveMisskey")]
			ILoveMisskey,
			[StringValue("foundTreasure")]
			FoundTreasure,
			[StringValue("client30min")]
			Client30min,
			[StringValue("client60min")]
			Client60min,
			[StringValue("noteDeletedWithin1min")]
			NoteDeletedWithin1min,
			[StringValue("postedAtLateNight")]
			PostedAtLateNight,
			[StringValue("postedAt0min0sec")]
			PostedAt0min0sec,
			[StringValue("selfQuote")]
			SelfQuote,
			[StringValue("htl20npm")]
			Htl20npm,
			[StringValue("viewInstanceChart")]
			ViewInstanceChart,
			[StringValue("outputHelloWorldOnScratchpad")]
			OutputHelloWorldOnScratchpad,
			[StringValue("open3windows")]
			Open3windows,
			[StringValue("driveFolderCircularReference")]
			DriveFolderCircularReference,
			[StringValue("reactWithoutRead")]
			ReactWithoutRead,
			[StringValue("clickedClickHere")]
			ClickedClickHere,
			[StringValue("justPlainLucky")]
			JustPlainLucky,
			[StringValue("setNameToSyuilo")]
			SetNameToSyuilo,
			[StringValue("cookieClicked")]
			CookieClicked,
			[StringValue("brainDiver")]
			BrainDiver,
			[StringValue("smashTestNotificationButton")]
			SmashTestNotificationButton,
			[StringValue("tutorialCompleted")]
			TutorialCompleted,
			[StringValue("bubbleGameExplodingHead")]
			BubbleGameExplodingHead,
			[StringValue("bubbleGameDoubleExplodingHead")]
			BubbleGameDoubleExplodingHead,
		}
		public async Task<Response<Model.EmptyResponse>> ChangePassword(string currentPassword,string newPassword,string? token = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "currentPassword", currentPassword },
				{ "newPassword", newPassword },
				{ "token", token },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/change-password", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> DeleteAccount(string password,string? token = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "password", password },
				{ "token", token },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/delete-account", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportBlocking()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/export-blocking", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportFollowing(bool excludeMuting = false,bool excludeInactive = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "excludeMuting", excludeMuting },
				{ "excludeInactive", excludeInactive },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/export-following", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportMute()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/export-mute", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportNotes()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/export-notes", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportClips()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/export-clips", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportFavorites()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/export-favorites", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportUserLists()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/export-user-lists", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ExportAntennas()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/export-antennas", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.NoteFavorite>>> Favorites(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Model.NoteFavorite>>("i/favorites", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ImportBlocking(string fileId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/import-blocking", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ImportFollowing(string fileId,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/import-following", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ImportMuting(string fileId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/import-muting", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ImportUserLists(string fileId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/import-user-lists", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ImportAntennas(string fileId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "fileId", fileId },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/import-antennas", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Notification>>> Notifications(int limit = 10,string? sinceId = null,string? untilId = null,bool markAsRead = true,List<string>? includeTypes = null,List<string>? excludeTypes = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "markAsRead", markAsRead },
				{ "includeTypes", includeTypes },
				{ "excludeTypes", excludeTypes },
			};
			var result = await _app.Request<List<Model.Notification>>("i/notifications", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Notification>>> NotificationsGrouped(int limit = 10,string? sinceId = null,string? untilId = null,bool markAsRead = true,List<string>? includeTypes = null,List<string>? excludeTypes = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "markAsRead", markAsRead },
				{ "includeTypes", includeTypes },
				{ "excludeTypes", excludeTypes },
			};
			var result = await _app.Request<List<Model.Notification>>("i/notifications-grouped", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class PageLikesItemResponseObject {
			public string Id { get; set; }
			public Model.Page Page { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class PageLikesItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					var sbPage = new StringBuilder();
					sbPage.Append("  page: [\n");
					if (this.Page != null)
					{
						sbPage.Append(this.Page);
						sbPage.Replace("\n", "\n    ");
						sbPage.Append("\n");
					}
					sbPage.Append("  ]\n");
					sb.Append(sbPage);
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<PageLikesItemResponseObject>>> PageLikes(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<PageLikesItemResponseObject>>("i/page-likes", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Page>>> Pages(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Model.Page>>("i/pages", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.MeDetailed>> Pin(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.MeDetailed>("i/pin", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ReadAllUnreadNotes()
		{
			var result = await _app.Request<Model.EmptyResponse>("i/read-all-unread-notes", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> ReadAnnouncement(string announcementId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "announcementId", announcementId },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/read-announcement", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> RegenerateToken(string password)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "password", password },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/regenerate-token", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> RevokeToken(string tokenId,string? token = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "tokenId", tokenId },
				{ "token", token },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/revoke-token", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Signin>>> SigninHistory(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Model.Signin>>("i/signin-history", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.MeDetailed>> Unpin(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.MeDetailed>("i/unpin", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.MeDetailed>> UpdateEmail(string password,string? email = null,string? token = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "password", password },
				{ "email", email },
				{ "token", token },
			};
			var result = await _app.Request<Model.MeDetailed>("i/update-email", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class AvatarDecorationsPropertyType {
			public string Id { get; set; }
			public decimal? Angle { get; set; }
			public bool? FlipH { get; set; }
			public decimal? OffsetX { get; set; }
			public decimal? OffsetY { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class AvatarDecorationsPropertyType: {\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  angle: {this.Angle}\n");
					sb.Append($"  flipH: {this.FlipH}\n");
					sb.Append($"  offsetX: {this.OffsetX}\n");
					sb.Append($"  offsetY: {this.OffsetY}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public class FieldsPropertyType {
			public string Name { get; set; }
			public string Value { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class FieldsPropertyType: {\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  value: {this.Value}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public class NotificationRecieveConfigObject {
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
					sb.Append("class NotificationRecieveConfigObject: {\n");
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
		public async Task<Response<Model.MeDetailed>> Update(bool isLocked,bool isExplorable,bool hideOnlineStatus,bool publicReactions,bool carefulBot,bool autoAcceptFollowed,bool noCrawle,bool preventAiLearning,bool isBot,bool isCat,bool injectFeaturedNote,bool receiveAnnouncementEmail,bool alwaysMarkNsfw,bool autoSensitive,UpdateFollowingVisibilityEnum followingVisibility,UpdateFollowersVisibilityEnum followersVisibility,UpdateNotificationRecieveConfigParamObject notificationRecieveConfig,string? name = null,string? description = null,string? location = null,string? birthday = null,UpdateLangEnum? lang = null,string? avatarId = null,List<object>? avatarDecorations = null,string? bannerId = null,List<object>? fields = null,string? pinnedPageId = null,List<JsonNode>? mutedWords = null,List<JsonNode>? hardMutedWords = null,List<string>? mutedInstances = null,List<string>? emailNotificationTypes = null,List<string>? alsoKnownAs = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "description", description },
				{ "location", location },
				{ "birthday", birthday },
				{ "lang", lang },
				{ "avatarId", avatarId },
				{ "avatarDecorations", avatarDecorations },
				{ "bannerId", bannerId },
				{ "fields", fields },
				{ "isLocked", isLocked },
				{ "isExplorable", isExplorable },
				{ "hideOnlineStatus", hideOnlineStatus },
				{ "publicReactions", publicReactions },
				{ "carefulBot", carefulBot },
				{ "autoAcceptFollowed", autoAcceptFollowed },
				{ "noCrawle", noCrawle },
				{ "preventAiLearning", preventAiLearning },
				{ "isBot", isBot },
				{ "isCat", isCat },
				{ "injectFeaturedNote", injectFeaturedNote },
				{ "receiveAnnouncementEmail", receiveAnnouncementEmail },
				{ "alwaysMarkNsfw", alwaysMarkNsfw },
				{ "autoSensitive", autoSensitive },
				{ "followingVisibility", followingVisibility },
				{ "followersVisibility", followersVisibility },
				{ "pinnedPageId", pinnedPageId },
				{ "mutedWords", mutedWords },
				{ "hardMutedWords", hardMutedWords },
				{ "mutedInstances", mutedInstances },
				{ "notificationRecieveConfig", notificationRecieveConfig },
				{ "emailNotificationTypes", emailNotificationTypes },
				{ "alsoKnownAs", alsoKnownAs },
			};
			var result = await _app.Request<Model.MeDetailed>("i/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class UpdateNotificationRecieveConfigParamObject {
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
		public enum UpdateFollowingVisibilityEnum {
			[StringValue("public")]
			Public,
			[StringValue("followers")]
			Followers,
			[StringValue("private")]
			Private,
		}
		public enum UpdateFollowersVisibilityEnum {
			[StringValue("public")]
			Public,
			[StringValue("followers")]
			Followers,
			[StringValue("private")]
			Private,
		}
		public enum UpdateLangEnum {
			[StringValue("ach")]
			Ach,
			[StringValue("ady")]
			Ady,
			[StringValue("af")]
			Af,
			[StringValue("af-NA")]
			AfNA,
			[StringValue("af-ZA")]
			AfZA,
			[StringValue("ak")]
			Ak,
			[StringValue("ar")]
			Ar,
			[StringValue("ar-AR")]
			ArAR,
			[StringValue("ar-MA")]
			ArMA,
			[StringValue("ar-SA")]
			ArSA,
			[StringValue("ay-BO")]
			AyBO,
			[StringValue("az")]
			Az,
			[StringValue("az-AZ")]
			AzAZ,
			[StringValue("be-BY")]
			BeBY,
			[StringValue("bg")]
			Bg,
			[StringValue("bg-BG")]
			BgBG,
			[StringValue("bn")]
			Bn,
			[StringValue("bn-IN")]
			BnIN,
			[StringValue("bn-BD")]
			BnBD,
			[StringValue("br")]
			Br,
			[StringValue("bs-BA")]
			BsBA,
			[StringValue("ca")]
			Ca,
			[StringValue("ca-ES")]
			CaES,
			[StringValue("cak")]
			Cak,
			[StringValue("ck-US")]
			CkUS,
			[StringValue("cs")]
			Cs,
			[StringValue("cs-CZ")]
			CsCZ,
			[StringValue("cy")]
			Cy,
			[StringValue("cy-GB")]
			CyGB,
			[StringValue("da")]
			Da,
			[StringValue("da-DK")]
			DaDK,
			[StringValue("de")]
			De,
			[StringValue("de-AT")]
			DeAT,
			[StringValue("de-DE")]
			DeDE,
			[StringValue("de-CH")]
			DeCH,
			[StringValue("dsb")]
			Dsb,
			[StringValue("el")]
			El,
			[StringValue("el-GR")]
			ElGR,
			[StringValue("en")]
			En,
			[StringValue("en-GB")]
			EnGB,
			[StringValue("en-AU")]
			EnAU,
			[StringValue("en-CA")]
			EnCA,
			[StringValue("en-IE")]
			EnIE,
			[StringValue("en-IN")]
			EnIN,
			[StringValue("en-PI")]
			EnPI,
			[StringValue("en-SG")]
			EnSG,
			[StringValue("en-UD")]
			EnUD,
			[StringValue("en-US")]
			EnUS,
			[StringValue("en-ZA")]
			EnZA,
			[StringValue("en@pirate")]
			EnAtpirate,
			[StringValue("eo")]
			Eo,
			[StringValue("eo-EO")]
			EoEO,
			[StringValue("es")]
			Es,
			[StringValue("es-AR")]
			EsAR,
			[StringValue("es-419")]
			Es419,
			[StringValue("es-CL")]
			EsCL,
			[StringValue("es-CO")]
			EsCO,
			[StringValue("es-EC")]
			EsEC,
			[StringValue("es-ES")]
			EsES,
			[StringValue("es-LA")]
			EsLA,
			[StringValue("es-NI")]
			EsNI,
			[StringValue("es-MX")]
			EsMX,
			[StringValue("es-US")]
			EsUS,
			[StringValue("es-VE")]
			EsVE,
			[StringValue("et")]
			Et,
			[StringValue("et-EE")]
			EtEE,
			[StringValue("eu")]
			Eu,
			[StringValue("eu-ES")]
			EuES,
			[StringValue("fa")]
			Fa,
			[StringValue("fa-IR")]
			FaIR,
			[StringValue("fb-LT")]
			FbLT,
			[StringValue("ff")]
			Ff,
			[StringValue("fi")]
			Fi,
			[StringValue("fi-FI")]
			FiFI,
			[StringValue("fo")]
			Fo,
			[StringValue("fo-FO")]
			FoFO,
			[StringValue("fr")]
			Fr,
			[StringValue("fr-CA")]
			FrCA,
			[StringValue("fr-FR")]
			FrFR,
			[StringValue("fr-BE")]
			FrBE,
			[StringValue("fr-CH")]
			FrCH,
			[StringValue("fy-NL")]
			FyNL,
			[StringValue("ga")]
			Ga,
			[StringValue("ga-IE")]
			GaIE,
			[StringValue("gd")]
			Gd,
			[StringValue("gl")]
			Gl,
			[StringValue("gl-ES")]
			GlES,
			[StringValue("gn-PY")]
			GnPY,
			[StringValue("gu-IN")]
			GuIN,
			[StringValue("gv")]
			Gv,
			[StringValue("gx-GR")]
			GxGR,
			[StringValue("he")]
			He,
			[StringValue("he-IL")]
			HeIL,
			[StringValue("hi")]
			Hi,
			[StringValue("hi-IN")]
			HiIN,
			[StringValue("hr")]
			Hr,
			[StringValue("hr-HR")]
			HrHR,
			[StringValue("hsb")]
			Hsb,
			[StringValue("ht")]
			Ht,
			[StringValue("hu")]
			Hu,
			[StringValue("hu-HU")]
			HuHU,
			[StringValue("hy")]
			Hy,
			[StringValue("hy-AM")]
			HyAM,
			[StringValue("id")]
			Id,
			[StringValue("id-ID")]
			IdID,
			[StringValue("is")]
			Is,
			[StringValue("is-IS")]
			IsIS,
			[StringValue("it")]
			It,
			[StringValue("it-IT")]
			ItIT,
			[StringValue("ja")]
			Ja,
			[StringValue("ja-JP")]
			JaJP,
			[StringValue("jv-ID")]
			JvID,
			[StringValue("ka-GE")]
			KaGE,
			[StringValue("kk-KZ")]
			KkKZ,
			[StringValue("km")]
			Km,
			[StringValue("kl")]
			Kl,
			[StringValue("km-KH")]
			KmKH,
			[StringValue("kab")]
			Kab,
			[StringValue("kn")]
			Kn,
			[StringValue("kn-IN")]
			KnIN,
			[StringValue("ko")]
			Ko,
			[StringValue("ko-KR")]
			KoKR,
			[StringValue("ku-TR")]
			KuTR,
			[StringValue("kw")]
			Kw,
			[StringValue("la")]
			La,
			[StringValue("la-VA")]
			LaVA,
			[StringValue("lb")]
			Lb,
			[StringValue("li-NL")]
			LiNL,
			[StringValue("lt")]
			Lt,
			[StringValue("lt-LT")]
			LtLT,
			[StringValue("lv")]
			Lv,
			[StringValue("lv-LV")]
			LvLV,
			[StringValue("mai")]
			Mai,
			[StringValue("mg-MG")]
			MgMG,
			[StringValue("mk")]
			Mk,
			[StringValue("mk-MK")]
			MkMK,
			[StringValue("ml")]
			Ml,
			[StringValue("ml-IN")]
			MlIN,
			[StringValue("mn-MN")]
			MnMN,
			[StringValue("mr")]
			Mr,
			[StringValue("mr-IN")]
			MrIN,
			[StringValue("ms")]
			Ms,
			[StringValue("ms-MY")]
			MsMY,
			[StringValue("mt")]
			Mt,
			[StringValue("mt-MT")]
			MtMT,
			[StringValue("my")]
			My,
			[StringValue("no")]
			No,
			[StringValue("nb")]
			Nb,
			[StringValue("nb-NO")]
			NbNO,
			[StringValue("ne")]
			Ne,
			[StringValue("ne-NP")]
			NeNP,
			[StringValue("nl")]
			Nl,
			[StringValue("nl-BE")]
			NlBE,
			[StringValue("nl-NL")]
			NlNL,
			[StringValue("nn-NO")]
			NnNO,
			[StringValue("oc")]
			Oc,
			[StringValue("or-IN")]
			OrIN,
			[StringValue("pa")]
			Pa,
			[StringValue("pa-IN")]
			PaIN,
			[StringValue("pl")]
			Pl,
			[StringValue("pl-PL")]
			PlPL,
			[StringValue("ps-AF")]
			PsAF,
			[StringValue("pt")]
			Pt,
			[StringValue("pt-BR")]
			PtBR,
			[StringValue("pt-PT")]
			PtPT,
			[StringValue("qu-PE")]
			QuPE,
			[StringValue("rm-CH")]
			RmCH,
			[StringValue("ro")]
			Ro,
			[StringValue("ro-RO")]
			RoRO,
			[StringValue("ru")]
			Ru,
			[StringValue("ru-RU")]
			RuRU,
			[StringValue("sa-IN")]
			SaIN,
			[StringValue("se-NO")]
			SeNO,
			[StringValue("sh")]
			Sh,
			[StringValue("si-LK")]
			SiLK,
			[StringValue("sk")]
			Sk,
			[StringValue("sk-SK")]
			SkSK,
			[StringValue("sl")]
			Sl,
			[StringValue("sl-SI")]
			SlSI,
			[StringValue("so-SO")]
			SoSO,
			[StringValue("sq")]
			Sq,
			[StringValue("sq-AL")]
			SqAL,
			[StringValue("sr")]
			Sr,
			[StringValue("sr-RS")]
			SrRS,
			[StringValue("su")]
			Su,
			[StringValue("sv")]
			Sv,
			[StringValue("sv-SE")]
			SvSE,
			[StringValue("sw")]
			Sw,
			[StringValue("sw-KE")]
			SwKE,
			[StringValue("ta")]
			Ta,
			[StringValue("ta-IN")]
			TaIN,
			[StringValue("te")]
			Te,
			[StringValue("te-IN")]
			TeIN,
			[StringValue("tg")]
			Tg,
			[StringValue("tg-TJ")]
			TgTJ,
			[StringValue("th")]
			Th,
			[StringValue("th-TH")]
			ThTH,
			[StringValue("fil")]
			Fil,
			[StringValue("tlh")]
			Tlh,
			[StringValue("tr")]
			Tr,
			[StringValue("tr-TR")]
			TrTR,
			[StringValue("tt-RU")]
			TtRU,
			[StringValue("uk")]
			Uk,
			[StringValue("uk-UA")]
			UkUA,
			[StringValue("ur")]
			Ur,
			[StringValue("ur-PK")]
			UrPK,
			[StringValue("uz")]
			Uz,
			[StringValue("uz-UZ")]
			UzUZ,
			[StringValue("vi")]
			Vi,
			[StringValue("vi-VN")]
			ViVN,
			[StringValue("xh-ZA")]
			XhZA,
			[StringValue("yi")]
			Yi,
			[StringValue("yi-DE")]
			YiDE,
			[StringValue("zh")]
			Zh,
			[StringValue("zh-Hans")]
			ZhHans,
			[StringValue("zh-Hant")]
			ZhHant,
			[StringValue("zh-CN")]
			ZhCN,
			[StringValue("zh-HK")]
			ZhHK,
			[StringValue("zh-SG")]
			ZhSG,
			[StringValue("zh-TW")]
			ZhTW,
			[StringValue("zu-ZA")]
			ZuZA,
		}
		public async Task<Response<JsonNode>> Move(string moveToAccount)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "moveToAccount", moveToAccount },
			};
			var result = await _app.Request<JsonNode>("i/move", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
namespace Misharp.Controls.I {
	public class GalleryApi
	{
		private Misharp.App _app;
		public GalleryApi(Misharp.App app)
		{
			_app = app;
		}
		public class IGalleryLikesItemResponseObject {
			public string Id { get; set; }
			public Model.GalleryPost Post { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class IGalleryLikesItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					var sbPost = new StringBuilder();
					sbPost.Append("  post: [\n");
					if (this.Post != null)
					{
						sbPost.Append(this.Post);
						sbPost.Replace("\n", "\n    ");
						sbPost.Append("\n");
					}
					sbPost.Append("  ]\n");
					sb.Append(sbPost);
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<IGalleryLikesItemResponseObject>>> Likes(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<IGalleryLikesItemResponseObject>>("i/gallery/likes", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.GalleryPost>>> Posts(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Model.GalleryPost>>("i/gallery/posts", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
	public class RegistryApi
	{
		private Misharp.App _app;
		public RegistryApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<JsonNode>> GetAll(List<string>? scope = null,string? domain = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "scope", scope },
				{ "domain", domain },
			};
			var result = await _app.Request<JsonNode>("i/registry/get-all", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class IRegistryGetDetailResponse {
			public string UpdatedAt { get; set; }
			public JsonNode Value { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  updatedAt: {this.UpdatedAt}\n");
				sb.Append($"  value: {this.Value}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<IRegistryGetDetailResponse>> GetDetail(string key,List<string>? scope = null,string? domain = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "key", key },
				{ "scope", scope },
				{ "domain", domain },
			};
			var result = await _app.Request<IRegistryGetDetailResponse>("i/registry/get-detail", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<JsonNode>> Get(string key,List<string>? scope = null,string? domain = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "key", key },
				{ "scope", scope },
				{ "domain", domain },
			};
			var result = await _app.Request<JsonNode>("i/registry/get", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<JsonNode>> KeysWithType(List<string>? scope = null,string? domain = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "scope", scope },
				{ "domain", domain },
			};
			var result = await _app.Request<JsonNode>("i/registry/keys-with-type", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<string>>> Keys(List<string>? scope = null,string? domain = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "scope", scope },
				{ "domain", domain },
			};
			var result = await _app.Request<List<string>>("i/registry/keys", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Remove(string key,List<string>? scope = null,string? domain = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "key", key },
				{ "scope", scope },
				{ "domain", domain },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/registry/remove", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class IRegistryScopesWithDomainItemResponseObject {
			public List<List<string>> Scopes { get; set; }
			public string? Domain { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class IRegistryScopesWithDomainItemResponseObject: {\n");
					sb.Append("  scopes: [\n");
					if (this.Scopes != null && this.Scopes.Count > 0)
					{
						var sbScopes = new StringBuilder();
						sbScopes.Append("    ");
						this.Scopes.ForEach(item => sbScopes.Append(item).Append(",\n"));
						sbScopes.Replace("\n", "\n    ");
						sbScopes.Length -= 4;
						sb.Append(sbScopes);
					}
					sb.Append("  ]\n");
					sb.Append($"  domain: {this.Domain}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<IRegistryScopesWithDomainItemResponseObject>>> ScopesWithDomain()
		{
			var result = await _app.Request<List<IRegistryScopesWithDomainItemResponseObject>>("i/registry/scopes-with-domain", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Set(string key,JsonNode value,List<string>? scope = null,string? domain = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "key", key },
				{ "value", value },
				{ "scope", scope },
				{ "domain", domain },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/registry/set", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
	public class WebhooksApi
	{
		private Misharp.App _app;
		public WebhooksApi(Misharp.App app)
		{
			_app = app;
		}
		public class IWebhooksCreateResponse {
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime LatestSentAt { get; set; }
			public int LatestStatus { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  id: {this.Id}\n");
				sb.Append($"  userId: {this.UserId}\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append("  on: [\n");
				if (this.On != null && this.On.Count > 0)
				{
					var sbOn = new StringBuilder();
					sbOn.Append("    ");
					this.On.ForEach(item => sbOn.Append(item).Append(",\n"));
					sbOn.Replace("\n", "\n    ");
					sbOn.Length -= 4;
					sb.Append(sbOn);
				}
				sb.Append("  ]\n");
				sb.Append($"  url: {this.Url}\n");
				sb.Append($"  secret: {this.Secret}\n");
				sb.Append($"  active: {this.Active}\n");
				sb.Append($"  latestSentAt: {this.LatestSentAt}\n");
				sb.Append($"  latestStatus: {this.LatestStatus}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<IWebhooksCreateResponse>> Create(string name,string url,string? secret = null,List<string>? on = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "url", url },
				{ "secret", secret },
				{ "on", on },
			};
			var result = await _app.Request<IWebhooksCreateResponse>("i/webhooks/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class IWebhooksListItemResponseObject {
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime? LatestSentAt { get; set; }
			public int? LatestStatus { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class IWebhooksListItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  userId: {this.UserId}\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append("  on: [\n");
					if (this.On != null && this.On.Count > 0)
					{
						var sbOn = new StringBuilder();
						sbOn.Append("    ");
						this.On.ForEach(item => sbOn.Append(item).Append(",\n"));
						sbOn.Replace("\n", "\n    ");
						sbOn.Length -= 4;
						sb.Append(sbOn);
					}
					sb.Append("  ]\n");
					sb.Append($"  url: {this.Url}\n");
					sb.Append($"  secret: {this.Secret}\n");
					sb.Append($"  active: {this.Active}\n");
					sb.Append($"  latestSentAt: {this.LatestSentAt}\n");
					sb.Append($"  latestStatus: {this.LatestStatus}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<IWebhooksListItemResponseObject>>> List()
		{
			var result = await _app.Request<List<IWebhooksListItemResponseObject>>("i/webhooks/list", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class IWebhooksShowResponse {
			public string Id { get; set; }
			public string UserId { get; set; }
			public string Name { get; set; }
			public List<string> On { get; set; }
			public string Url { get; set; }
			public string Secret { get; set; }
			public bool Active { get; set; }
			public DateTime LatestSentAt { get; set; }
			public int LatestStatus { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  id: {this.Id}\n");
				sb.Append($"  userId: {this.UserId}\n");
				sb.Append($"  name: {this.Name}\n");
				sb.Append("  on: [\n");
				if (this.On != null && this.On.Count > 0)
				{
					var sbOn = new StringBuilder();
					sbOn.Append("    ");
					this.On.ForEach(item => sbOn.Append(item).Append(",\n"));
					sbOn.Replace("\n", "\n    ");
					sbOn.Length -= 4;
					sb.Append(sbOn);
				}
				sb.Append("  ]\n");
				sb.Append($"  url: {this.Url}\n");
				sb.Append($"  secret: {this.Secret}\n");
				sb.Append($"  active: {this.Active}\n");
				sb.Append($"  latestSentAt: {this.LatestSentAt}\n");
				sb.Append($"  latestStatus: {this.LatestStatus}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<IWebhooksShowResponse>> Show(string webhookId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "webhookId", webhookId },
			};
			var result = await _app.Request<IWebhooksShowResponse>("i/webhooks/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Update(string webhookId,string name,string url,bool active,string? secret = null,List<string>? on = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "webhookId", webhookId },
				{ "name", name },
				{ "url", url },
				{ "secret", secret },
				{ "on", on },
				{ "active", active },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/webhooks/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string webhookId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "webhookId", webhookId },
			};
			var result = await _app.Request<Model.EmptyResponse>("i/webhooks/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
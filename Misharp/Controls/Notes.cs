using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class NotesApi {
		private Misharp.App _app;
		public Notes.FavoritesApi FavoritesApi;
		public Notes.PollsApi PollsApi;
		public Notes.ReactionsApi ReactionsApi;
		public Notes.ThreadMutingApi ThreadMutingApi;
		public NotesApi(Misharp.App app)
		{
			_app = app;
			FavoritesApi = new Notes.FavoritesApi(_app);
			PollsApi = new Notes.PollsApi(_app);
			ReactionsApi = new Notes.ReactionsApi(_app);
			ThreadMutingApi = new Notes.ThreadMutingApi(_app);
		}
		public async Task<Response<List<Model.Note>>> Notes(bool reply,bool renote,bool withFiles,bool poll,bool local = false,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "local", local },
				{ "reply", reply },
				{ "renote", renote },
				{ "withFiles", withFiles },
				{ "poll", poll },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Children(string noteId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/children", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Clip>>> Clips(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			Response<List<Model.Clip>> result = await _app.Request<List<Model.Clip>>("notes/clips", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Conversation(string noteId,int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "offset", offset },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/conversation", param, useToken: false);
			return result;
		}
		public class NotesCreatePollPropertyObject {
			public List<string> Choices { get; set; }
			public bool Multiple { get; set; }
			public int? ExpiresAt { get; set; }
			public int? ExpiredAfter { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("  choices: {\n");
				if (this.Choices != null && this.Choices.Count > 0) this.Choices.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append($"  multiple: {this.Multiple}\n");
				sb.Append($"  expiresAt: {this.ExpiresAt}\n");
				sb.Append($"  expiredAfter: {this.ExpiredAfter}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public class NotesCreateResponse {
			public Model.Note CreatedNote { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				var sbcreatedNote = new StringBuilder();
				sbcreatedNote.Append("  createdNote: {\n");
				if (this.CreatedNote != null)
				{
					sbcreatedNote.Append(this.CreatedNote);
					sbcreatedNote.Replace("\n", "\n  ");
					sbcreatedNote.Append("\n");
				}
				sbcreatedNote.Append("  }\n");
				sb.Append(sbcreatedNote);
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<NotesCreateResponse>> Create(CreateVisibilityEnum visibility = CreateVisibilityEnum.Public,List<string>? visibleUserIds = null,string? cw = null,bool localOnly = false,CreateReactionAcceptanceEnum? reactionAcceptance = null,bool noExtractMentions = false,bool noExtractHashtags = false,bool noExtractEmojis = false,string? replyId = null,string? renoteId = null,string? channelId = null,string? text = null,List<string>? fileIds = null,List<string>? mediaIds = null,object? poll = null)
		{
			visibleUserIds ??= new();
			fileIds ??= new();
			mediaIds ??= new();
			var param = new Dictionary<string, object?>	
			{
				{ "visibility", visibility },
				{ "visibleUserIds", visibleUserIds },
				{ "cw", cw },
				{ "localOnly", localOnly },
				{ "reactionAcceptance", reactionAcceptance },
				{ "noExtractMentions", noExtractMentions },
				{ "noExtractHashtags", noExtractHashtags },
				{ "noExtractEmojis", noExtractEmojis },
				{ "replyId", replyId },
				{ "renoteId", renoteId },
				{ "channelId", channelId },
				{ "text", text },
				{ "fileIds", fileIds },
				{ "mediaIds", mediaIds },
				{ "poll", poll },
			};
			Response<NotesCreateResponse> result = await _app.Request<NotesCreateResponse>("notes/create", param, useToken: true);
			return result;
		}
		public class CreatePollParamObject {
			public List<string> Choices { get; set; }
			public bool Multiple { get; set; }
			public int? ExpiresAt { get; set; }
			public int? ExpiredAfter { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("  choices: {\n");
				if (this.Choices != null && this.Choices.Count > 0) this.Choices.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append($"  multiple: {this.Multiple}\n");
				sb.Append($"  expiresAt: {this.ExpiresAt}\n");
				sb.Append($"  expiredAfter: {this.ExpiredAfter}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public enum CreateVisibilityEnum {
			[StringValue("public")]
			Public,
			[StringValue("home")]
			Home,
			[StringValue("followers")]
			Followers,
			[StringValue("specified")]
			Specified,
		}
		public enum CreateReactionAcceptanceEnum {
			[StringValue("likeOnly")]
			LikeOnly,
			[StringValue("likeOnlyForRemote")]
			LikeOnlyForRemote,
			[StringValue("nonSensitiveOnly")]
			NonSensitiveOnly,
			[StringValue("nonSensitiveOnlyForLocalLikeOnlyForRemote")]
			NonSensitiveOnlyForLocalLikeOnlyForRemote,
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Featured(int limit = 10,string? untilId = null,string? channelId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "untilId", untilId },
				{ "channelId", channelId },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/featured", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> GlobalTimeline(bool withFiles = false,bool withRenotes = true,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/global-timeline", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> HybridTimeline(int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withFiles = false,bool withRenotes = true,bool withReplies = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "includeMyRenotes", includeMyRenotes },
				{ "includeRenotedMyNotes", includeRenotedMyNotes },
				{ "includeLocalRenotes", includeLocalRenotes },
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
				{ "withReplies", withReplies },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/hybrid-timeline", param, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Note>>> LocalTimeline(bool withFiles = false,bool withRenotes = true,bool withReplies = false,int limit = 10,string? sinceId = null,string? untilId = null,bool allowPartial = false,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
				{ "withReplies", withReplies },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "allowPartial", allowPartial },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/local-timeline", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Mentions(string visibility,bool following = false,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "following", following },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "visibility", visibility },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/mentions", param, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.NoteReaction>>> Reactions(string noteId,string? type = null,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "type", type },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.NoteReaction>> result = await _app.Request<List<Model.NoteReaction>>("notes/reactions", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Renotes(string noteId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/renotes", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Replies(string noteId,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/replies", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> SearchByTag(string tag,bool? reply = null,bool? renote = null,bool withFiles = false,bool? poll = null,string? sinceId = null,string? untilId = null,int limit = 10,List<List<string>>? query = null)
		{
			query ??= new();
			var param = new Dictionary<string, object?>	
			{
				{ "reply", reply },
				{ "renote", renote },
				{ "withFiles", withFiles },
				{ "poll", poll },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "tag", tag },
				{ "query", query },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/search-by-tag", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Search(string query,string host,string? sinceId = null,string? untilId = null,int limit = 10,int offset = 0,string? userId = null,string? channelId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "query", query },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
				{ "offset", offset },
				{ "host", host },
				{ "userId", userId },
				{ "channelId", channelId },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/search", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.Note>> Show(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			Response<Model.Note> result = await _app.Request<Model.Note>("notes/show", param, useToken: false);
			return result;
		}
		public class NotesStateResponse {
			public bool IsFavorited { get; set; }
			public bool IsMutedThread { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  isFavorited: {this.IsFavorited}\n");
				sb.Append($"  isMutedThread: {this.IsMutedThread}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<NotesStateResponse>> State(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			Response<NotesStateResponse> result = await _app.Request<NotesStateResponse>("notes/state", param, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Timeline(int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withFiles = false,bool withRenotes = true)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "includeMyRenotes", includeMyRenotes },
				{ "includeRenotedMyNotes", includeRenotedMyNotes },
				{ "includeLocalRenotes", includeLocalRenotes },
				{ "withFiles", withFiles },
				{ "withRenotes", withRenotes },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/timeline", param, useToken: true);
			return result;
		}
		public class NotesTranslateResponse {
			public string SourceLang { get; set; }
			public string Text { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  sourceLang: {this.SourceLang}\n");
				sb.Append($"  text: {this.Text}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<NotesTranslateResponse>> Translate(string noteId,string targetLang)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "targetLang", targetLang },
			};
			Response<NotesTranslateResponse> result = await _app.Request<NotesTranslateResponse>("notes/translate", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unrenote(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/unrenote", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Note>>> UserListTimeline(string listId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withRenotes = true,bool withFiles = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
				{ "includeMyRenotes", includeMyRenotes },
				{ "includeRenotedMyNotes", includeRenotedMyNotes },
				{ "includeLocalRenotes", includeLocalRenotes },
				{ "withRenotes", withRenotes },
				{ "withFiles", withFiles },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("notes/user-list-timeline", param, useToken: true);
			return result;
		}
	}
}
namespace Misharp.Controls.Notes {
	public class FavoritesApi
	{
		private Misharp.App _app;
		public FavoritesApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Create(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/favorites/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/favorites/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
	public class PollsApi
	{
		private Misharp.App _app;
		public PollsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.Note>>> Recommendation(int limit = 10,int offset = 0,bool excludeChannels = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "offset", offset },
				{ "excludeChannels", excludeChannels },
			};
			var result = await _app.Request<List<Model.Note>>("notes/polls/recommendation", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Vote(string noteId,int choice)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "choice", choice },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/polls/vote", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
	public class ReactionsApi
	{
		private Misharp.App _app;
		public ReactionsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Create(string noteId,string reaction)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "reaction", reaction },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/reactions/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/reactions/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
	public class ThreadMutingApi
	{
		private Misharp.App _app;
		public ThreadMutingApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Create(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/thread-muting/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("notes/thread-muting/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
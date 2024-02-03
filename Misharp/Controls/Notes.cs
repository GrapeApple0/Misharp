using Misharp;
using Misharp.Model;
using System.Text;
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
		public async Task<Models.Response<List<Note>>> Notes(bool reply,bool renote,bool withFiles,bool poll,string sinceId,string untilId,bool local = false,int limit = 10)
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
			var result = await _app.Request<List<Note>>("notes", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Children(string noteId,string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Note>>("notes/children", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Clip>>> Clips(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<List<Clip>>("notes/clips", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Conversation(string noteId,int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<List<Note>>("notes/conversation", param, useToken: false);
			return result;
		}
		public class NotesCreateResponse {
			public Note CreatedNote { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				var sbcreatedNote = new StringBuilder();
				sbcreatedNote.Append("  createdNote: {\n");
				if (this.CreatedNote != null)
				{
					sbcreatedNote.Append(this.CreatedNote);
					sbcreatedNote.Replace("\n", "\n    ");
					sbcreatedNote.Append("\n");
				}
				sbcreatedNote.Append("  }\n");
				sb.Append(sbcreatedNote);
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Models.Response<NotesCreateResponse>> Create(CreateVisibilityEnum visibility = CreateVisibilityEnum.Public,List<string>? visibleUserIds = null,string? cw = null,bool localOnly = false,CreateReactionAcceptanceEnum? reactionAcceptance = null,bool noExtractMentions = false,bool noExtractHashtags = false,bool noExtractEmojis = false,string? replyId = null,string? renoteId = null,string? channelId = null,string? text = null,List<string>? fileIds = null,List<string>? mediaIds = null,object? poll = null)
		{
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
			var result = await _app.Request<NotesCreateResponse>("notes/create", param, useToken: true);
			return result;
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
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Update(string noteId,string text,string? cw = null,List<string>? fileIds = null,object? poll = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "text", text },
				{ "cw", cw },
				{ "fileIds", fileIds },
				{ "poll", poll },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Featured(string untilId,int limit = 10,string? channelId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "untilId", untilId },
				{ "channelId", channelId },
			};
			var result = await _app.Request<List<Note>>("notes/featured", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Globaltimeline(string sinceId,string untilId,int sinceDate,int untilDate,bool withFiles = false,bool withRenotes = true,int limit = 10)
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
			var result = await _app.Request<List<Note>>("notes/global-timeline", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Hybridtimeline(string sinceId,string untilId,int sinceDate,int untilDate,int limit = 10,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withFiles = false,bool withRenotes = true,bool withReplies = false)
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
			var result = await _app.Request<List<Note>>("notes/hybrid-timeline", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Localtimeline(string sinceId,string untilId,int sinceDate,int untilDate,bool withFiles = false,bool withRenotes = true,bool withReplies = false,int limit = 10,bool allowPartial = false)
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
			var result = await _app.Request<List<Note>>("notes/local-timeline", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Mentions(string sinceId,string untilId,string visibility,bool following = false,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "following", following },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "visibility", visibility },
			};
			var result = await _app.Request<List<Note>>("notes/mentions", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Quotes(string noteId,string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Note>>("notes/quotes", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<NoteReaction>>> Reactions(string noteId,string sinceId,string untilId,string? type = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "type", type },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<NoteReaction>>("notes/reactions", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Renotes(string noteId,string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Note>>("notes/renotes", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Replies(string noteId,string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Note>>("notes/replies", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Searchbytag(string sinceId,string untilId,string tag,bool? reply = null,bool? renote = null,bool withFiles = false,bool? poll = null,int limit = 10,List<string>? query = null)
		{
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
			var result = await _app.Request<List<Note>>("notes/search-by-tag", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Search(string query,string sinceId,string untilId,string host,int limit = 10,int offset = 0,string? userId = null,string? channelId = null)
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
			var result = await _app.Request<List<Note>>("notes/search", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Note>> Show(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Note>("notes/show", param, useToken: false);
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
		public async Task<Models.Response<NotesStateResponse>> State(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<NotesStateResponse>("notes/state", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Timeline(string sinceId,string untilId,int sinceDate,int untilDate,int limit = 10,bool allowPartial = false,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withFiles = false,bool withRenotes = true)
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
			var result = await _app.Request<List<Note>>("notes/timeline", param, useToken: true);
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
		public async Task<Models.Response<NotesTranslateResponse>> Translate(string noteId,string targetLang)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "targetLang", targetLang },
			};
			var result = await _app.Request<NotesTranslateResponse>("notes/translate", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Unrenote(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/unrenote", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Userlisttimeline(string listId,string sinceId,string untilId,int sinceDate,int untilDate,int limit = 10,bool includeMyRenotes = true,bool includeRenotedMyNotes = true,bool includeLocalRenotes = true,bool withRenotes = true,bool withFiles = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "listId", listId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "includeMyRenotes", includeMyRenotes },
				{ "includeRenotedMyNotes", includeRenotedMyNotes },
				{ "includeLocalRenotes", includeLocalRenotes },
				{ "withRenotes", withRenotes },
				{ "withFiles", withFiles },
			};
			var result = await _app.Request<List<Note>>("notes/user-list-timeline", param, useToken: true);
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
		public async Task<Models.Response<Models.EmptyResponse>> Create(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/favorites/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/favorites/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
		public async Task<Models.Response<List<Note>>> Recommendation(int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<List<Note>>("notes/polls/recommendation", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Vote(string noteId,int choice)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "choice", choice },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/polls/vote", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
		public async Task<Models.Response<Models.EmptyResponse>> Create(string noteId,string reaction)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
				{ "reaction", reaction },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/reactions/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/reactions/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
		public async Task<Models.Response<Models.EmptyResponse>> Create(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/thread-muting/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("notes/thread-muting/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
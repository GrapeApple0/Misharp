using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls
{
    public class UsersApi
    {
        private Misharp.App _app;
        public Users.GalleryApi GalleryApi;
        public Users.ListsApi ListsApi;
        public UsersApi(Misharp.App app)
        {
            _app = app;
            GalleryApi = new Users.GalleryApi(_app);
            ListsApi = new Users.ListsApi(_app);
        }
        public async Task<Models.Response<List<UserDetailed>>> Users(UsersSortEnum sort, int limit = 10, int offset = 0, UsersStateEnum state = UsersStateEnum.All, UsersOriginEnum origin = UsersOriginEnum.Local, string? hostname = null)
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
            var result = await _app.Request<List<UserDetailed>>("users", param, useToken: false);
            return result;
        }
        public enum UsersSortEnum
        {
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
        public enum UsersStateEnum
        {
            [StringValue("all")]
            All,
            [StringValue("alive")]
            Alive,
        }
        public enum UsersOriginEnum
        {
            [StringValue("combined")]
            Combined,
            [StringValue("local")]
            Local,
            [StringValue("remote")]
            Remote,
        }
        public async Task<Models.Response<List<Clip>>> Clips(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Clip>>("users/clips", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<Model.Following>>> Followers(string sinceId, string untilId, string userId, string username, int limit = 10, string? host = null)
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
            var result = await _app.Request<List<Model.Following>>("users/followers", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<Model.Following>>> Following(string sinceId, string untilId, string userId, string username, int limit = 10, string? host = null, string? birthday = null)
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
            var result = await _app.Request<List<Model.Following>>("users/following", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<object>>> Getfrequentlyrepliedusers(string userId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
            };
            var result = await _app.Request<List<object>>("users/get-frequently-replied-users", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<Note>>> Featurednotes(string untilId, string userId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "untilId", untilId },
                { "userId", userId },
            };
            var result = await _app.Request<List<Note>>("users/featured-notes", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<Note>>> Notes(string userId, string sinceId, string untilId, int sinceDate, int untilDate, bool withReplies = false, bool withRenotes = true, bool withChannelNotes = false, int limit = 10, bool allowPartial = false, bool withFiles = false)
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
            var result = await _app.Request<List<Note>>("users/notes", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<Page>>> Pages(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Page>>("users/pages", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<Flash>>> Flashs(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Flash>>("users/flashs", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<NoteReaction>>> Reactions(string userId, string sinceId, string untilId, int sinceDate, int untilDate, int limit = 10)
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
            var result = await _app.Request<List<NoteReaction>>("users/reactions", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<UserDetailed>>> Recommendation(int limit = 10, int offset = 0)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "offset", offset },
            };
            var result = await _app.Request<List<UserDetailed>>("users/recommendation", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Reportabuse(string userId, string comment)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "comment", comment },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/report-abuse", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<User>>> Searchbyusernameandhost(int limit = 10, bool detail = true, string? username = null, string? host = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "detail", detail },
                { "username", username },
                { "host", host },
            };
            var result = await _app.Request<List<User>>("users/search-by-username-and-host", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<List<User>>> Search(string query, int offset = 0, int limit = 10, SearchOriginEnum origin = SearchOriginEnum.Combined, bool detail = true)
        {
            var param = new Dictionary<string, object?>
            {
                { "query", query },
                { "offset", offset },
                { "limit", limit },
                { "origin", origin },
                { "detail", detail },
            };
            var result = await _app.Request<List<User>>("users/search", param, useToken: false);
            return result;
        }
        public enum SearchOriginEnum
        {
            [StringValue("local")]
            Local,
            [StringValue("remote")]
            Remote,
            [StringValue("combined")]
            Combined,
        }
        public async Task<Models.Response<List<object>>> Achievements(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<List<object>>("users/achievements", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Updatememo(string userId, string? memo = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "memo", memo },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/update-memo", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
    }
}
namespace Misharp.Controls.Users
{
    public class GalleryApi
    {
        private Misharp.App _app;
        public GalleryApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<Models.Response<List<GalleryPost>>> Posts(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<GalleryPost>>("users/gallery/posts", param, useToken: false);
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
        public async Task<Models.Response<UserList>> Create(string name)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
            };
            var result = await _app.Request<UserList>("users/lists/create", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Delete(string listId)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/lists/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<UserList>>> List(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<List<UserList>>("users/lists/list", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Pull(string listId, string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
                { "userId", userId },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/lists/pull", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Push(string listId, string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
                { "userId", userId },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/lists/push", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<UserList>> Show(string listId, bool forPublic = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
                { "forPublic", forPublic },
            };
            var result = await _app.Request<UserList>("users/lists/show", param, useToken: false);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Favorite(string listId)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/lists/favorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Unfavorite(string listId)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/lists/unfavorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<UserList>> Update(string listId, string name, bool isPublic)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
                { "name", name },
                { "isPublic", isPublic },
            };
            var result = await _app.Request<UserList>("users/lists/update", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<UserList>> Createfrompublic(string name, string listId)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "listId", listId },
            };
            var result = await _app.Request<UserList>("users/lists/create-from-public", param, useToken: true);
            return result;
        }
        public async Task<Models.Response<Models.EmptyResponse>> Updatemembership(string listId, string userId, bool withReplies)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
                { "userId", userId },
                { "withReplies", withReplies },
            };
            var result = await _app.Request<Models.EmptyResponse>("users/lists/update-membership", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
            return result;
        }
        public async Task<Models.Response<List<object>>> Getmemberships(string listId, string sinceId, string untilId, bool forPublic = false, int limit = 30)
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
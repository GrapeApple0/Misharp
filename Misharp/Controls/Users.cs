using Misharp.Model;
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
        public async Task<List<UserDetailed>> Users(SortEnum sort, int limit = 10, int offset = 0, UsersStateEnum state = UsersStateEnum.All, OriginEnum origin = OriginEnum.Local, string? hostname = null)
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
            var result = await _app.Request<List<UserDetailed>>("users", param, false);
            return result;
        }
        public enum SortEnum
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
        public enum OriginEnum
        {
            [StringValue("combined")]
            Combined,
            [StringValue("local")]
            Local,
            [StringValue("remote")]
            Remote,
        }
        public async Task<List<Clip>> Clips(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Clip>>("users/clips", param, false);
            return result;
        }
        public async Task<List<Model.Following>> Followers(string sinceId, string untilId, string userId, string username, int limit = 10, string? host = null)
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
            var result = await _app.Request<List<Model.Following>>("users/followers", param, false);
            return result;
        }
        public async Task<List<Model.Following>> Following(string sinceId, string untilId, string userId, string username, int limit = 10, string? host = null)
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
            var result = await _app.Request<List<Model.Following>>("users/following", param, false);
            return result;
        }
        public async Task<List<object>> Getfrequentlyrepliedusers(string userId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
            };
            var result = await _app.Request<List<object>>("users/get-frequently-replied-users", param, false);
            return result;
        }
        public async Task<List<Note>> Featurednotes(string untilId, string userId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "untilId", untilId },
                { "userId", userId },
            };
            var result = await _app.Request<List<Note>>("users/featured-notes", param, false);
            return result;
        }
        public async Task<List<Note>> Notes(string userId, string sinceId, string untilId, int sinceDate, int untilDate, bool withReplies = false, bool withRenotes = true, bool withChannelNotes = false, int limit = 10, bool withFiles = false, bool excludeNsfw = false)
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
                { "withFiles", withFiles },
                { "excludeNsfw", excludeNsfw },
            };
            var result = await _app.Request<List<Note>>("users/notes", param, false);
            return result;
        }
        public async Task<List<Page>> Pages(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Page>>("users/pages", param, false);
            return result;
        }
        public async Task<List<Flash>> Flashs(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Flash>>("users/flashs", param, false);
            return result;
        }
        public async Task<List<NoteReaction>> Reactions(string userId, string sinceId, string untilId, int sinceDate, int untilDate, int limit = 10)
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
            var result = await _app.Request<List<NoteReaction>>("users/reactions", param, false);
            return result;
        }
        public async Task<List<UserDetailed>> Recommendation(int limit = 10, int offset = 0)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "offset", offset },
            };
            var result = await _app.Request<List<UserDetailed>>("users/recommendation", param, true);
            return result;
        }
        public async Task<List<User>> Searchbyusernameandhost(int limit = 10, bool detail = true, string? username = null, string? host = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "detail", detail },
                { "username", username },
                { "host", host },
            };
            var result = await _app.Request<List<User>>("users/search-by-username-and-host", param, false);
            return result;
        }
        public async Task<List<User>> Search(string query, int offset = 0, int limit = 10, SearchOriginEnum origin = SearchOriginEnum.Combined, bool detail = true)
        {
            var param = new Dictionary<string, object?>
            {
                { "query", query },
                { "offset", offset },
                { "limit", limit },
                { "origin", origin },
                { "detail", detail },
            };
            var result = await _app.Request<List<User>>("users/search", param, false);
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
        public async Task<List<GalleryPost>> Posts(string userId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<GalleryPost>>("users/gallery/posts", param, false);
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
        public async Task<UserList> Create(string name)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
            };
            var result = await _app.Request<UserList>("users/lists/create", param, true);
            return result;
        }
        public async Task<List<UserList>> List(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<List<UserList>>("users/lists/list", param, false);
            return result;
        }
        public async Task<UserList> Show(string listId, bool forPublic = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
                { "forPublic", forPublic },
            };
            var result = await _app.Request<UserList>("users/lists/show", param, false);
            return result;
        }
        public async Task<UserList> Update(string listId, string name, bool isPublic)
        {
            var param = new Dictionary<string, object?>
            {
                { "listId", listId },
                { "name", name },
                { "isPublic", isPublic },
            };
            var result = await _app.Request<UserList>("users/lists/update", param, true);
            return result;
        }
        public async Task<UserList> Createfrompublic(string name, string listId)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "listId", listId },
            };
            var result = await _app.Request<UserList>("users/lists/create-from-public", param, true);
            return result;
        }
    }
}
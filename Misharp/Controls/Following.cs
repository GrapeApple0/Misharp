using Misharp.Model;
namespace Misharp.Controls
{
    public class FollowingApi
    {
        private Misharp.App _app;
        public Following.RequestsApi RequestsApi;
        public FollowingApi(Misharp.App app)
        {
            _app = app;
            RequestsApi = new Following.RequestsApi(_app);
        }
        public async Task<UserLite> Create(string userId, bool withReplies)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "withReplies", withReplies },
            };
            var result = await _app.Request<UserLite>("following/create", param, true);
            return result;
        }
        public async Task<UserLite> Delete(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<UserLite>("following/delete", param, true);
            return result;
        }
        public async Task<UserLite> Update(string userId, NotifyEnum notify, bool withReplies)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
                { "notify", notify },
                { "withReplies", withReplies },
            };
            var result = await _app.Request<UserLite>("following/update", param, true);
            return result;
        }
        public enum NotifyEnum
        {
            [StringValue("normal")]
            Normal,
            [StringValue("none")]
            None,
        }
        public async Task<UserLite> Invalidate(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<UserLite>("following/invalidate", param, true);
            return result;
        }
    }
}
namespace Misharp.Controls.Following
{
    public class RequestsApi
    {
        private Misharp.App _app;
        public RequestsApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<UserLite> Cancel(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<UserLite>("following/requests/cancel", param, true);
            return result;
        }
        public async Task<List<object>> List(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
            };
            var result = await _app.Request<List<object>>("following/requests/list", param, true);
            return result;
        }
    }
}
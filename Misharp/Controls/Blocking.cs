using Misharp.Model;
namespace Misharp.Controls
{
    public class BlockingApi
    {
        private Misharp.App _app;
        public BlockingApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<UserDetailedNotMe> Create(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<UserDetailedNotMe>("blocking/create", param, true);
            return result;
        }
        public async Task<UserDetailedNotMe> Delete(string userId)
        {
            var param = new Dictionary<string, object?>
            {
                { "userId", userId },
            };
            var result = await _app.Request<UserDetailedNotMe>("blocking/delete", param, true);
            return result;
        }
        public async Task<List<Blocking>> List(string sinceId, string untilId, int limit = 30)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Blocking>>("blocking/list", param, true);
            return result;
        }
    }
}
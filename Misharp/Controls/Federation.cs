using Misharp.Model;
namespace Misharp.Controls
{
    public class FederationApi
    {
        private Misharp.App _app;
        public FederationApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<Model.Following>> Followers(string host, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
            };
            var result = await _app.Request<List<Model.Following>>("federation/followers", param, false);
            return result;
        }
        public async Task<List<Model.Following>> Following(string host, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
            };
            var result = await _app.Request<List<Model.Following>>("federation/following", param, false);
            return result;
        }
        public async Task<List<FederationInstance>> Instances(string sort, string? host = null, bool? blocked = null, bool? notResponding = null, bool? suspended = null, bool? silenced = null, bool? federating = null, bool? subscribing = null, bool? publishing = null, int limit = 30, int offset = 0)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host },
                { "blocked", blocked },
                { "notResponding", notResponding },
                { "suspended", suspended },
                { "silenced", silenced },
                { "federating", federating },
                { "subscribing", subscribing },
                { "publishing", publishing },
                { "limit", limit },
                { "offset", offset },
                { "sort", sort },
            };
            var result = await _app.Request<List<FederationInstance>>("federation/instances", param, false);
            return result;
        }
        public async Task<List<UserDetailedNotMe>> Users(string host, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "host", host },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
            };
            var result = await _app.Request<List<UserDetailedNotMe>>("federation/users", param, false);
            return result;
        }
    }
}
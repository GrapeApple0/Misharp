using Misharp.Model;
namespace Misharp.Controls
{
    public class FlashApi
    {
        private Misharp.App _app;
        public FlashApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<Flash>> Featured()
        {
            var result = await _app.Request<List<Flash>>("flash/featured", false);
            return result;
        }
        public async Task<Flash> Show(string flashId, string username)
        {
            var param = new Dictionary<string, object?>
            {
                { "flashId", flashId },
                { "username", username },
            };
            var result = await _app.Request<Flash>("flash/show", param, false);
            return result;
        }
        public async Task<List<Flash>> My(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Flash>>("flash/my", param, true);
            return result;
        }
        public async Task<List<object>> Mylikes(string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<object>>("flash/my-likes", param, true);
            return result;
        }
    }
}
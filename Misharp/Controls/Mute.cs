using Misharp.Model;
namespace Misharp.Controls
{
    public class MuteApi
    {
        private Misharp.App _app;
        public MuteApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<Muting>> List(string sinceId, string untilId, int limit = 30)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Muting>>("mute/list", param, true);
            return result;
        }
    }
}
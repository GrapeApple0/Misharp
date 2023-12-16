using Misharp.Model;
namespace Misharp.Controls
{
    public class RenoteMuteApi
    {
        private Misharp.App _app;
        public RenoteMuteApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<RenoteMuting>> List(string sinceId, string untilId, int limit = 30)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<RenoteMuting>>("renote-mute/list", param, true);
            return result;
        }
    }
}
using Misharp.Model;
namespace Misharp.Controls
{
    public class AnnouncementsApi
    {
        private Misharp.App _app;
        public AnnouncementsApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<Announcement>> Announcements(string sinceId, string untilId, int limit = 10, bool isActive = true)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "isActive", isActive },
            };
            var result = await _app.Request<List<Announcement>>("announcements", param, false);
            return result;
        }
    }
}
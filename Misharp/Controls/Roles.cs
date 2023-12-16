using Misharp.Model;
namespace Misharp.Controls
{
    public class RolesApi
    {
        private Misharp.App _app;
        public RolesApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<Note>> Notes(string roleId, string sinceId, string untilId, int sinceDate, int untilDate, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "roleId", roleId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "sinceDate", sinceDate },
                { "untilDate", untilDate },
            };
            var result = await _app.Request<List<Note>>("roles/notes", param, true);
            return result;
        }
    }
}
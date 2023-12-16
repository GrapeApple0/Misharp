using Misharp.Model;
namespace Misharp.Controls
{
    public class ClipsApi
    {
        private Misharp.App _app;
        public ClipsApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<Clip> Create(string name, bool isPublic = false, string? description = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "isPublic", isPublic },
                { "description", description },
            };
            var result = await _app.Request<Clip>("clips/create", param, true);
            return result;
        }
        public async Task<List<Clip>> List()
        {
            var result = await _app.Request<List<Clip>>("clips/list", true);
            return result;
        }
        public async Task<List<Note>> Notes(string clipId, string sinceId, string untilId, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "clipId", clipId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<Note>>("clips/notes", param, false);
            return result;
        }
        public async Task<Clip> Show(string clipId)
        {
            var param = new Dictionary<string, object?>
            {
                { "clipId", clipId },
            };
            var result = await _app.Request<Clip>("clips/show", param, false);
            return result;
        }
        public async Task<Clip> Update(string clipId, string name, bool isPublic, string? description = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "clipId", clipId },
                { "name", name },
                { "isPublic", isPublic },
                { "description", description },
            };
            var result = await _app.Request<Clip>("clips/update", param, true);
            return result;
        }
        public async Task<List<Clip>> Myfavorites()
        {
            var result = await _app.Request<List<Clip>>("clips/my-favorites", true);
            return result;
        }
    }
}
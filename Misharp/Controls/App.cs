namespace Misharp.Controls
{
    public class AppApi
    {
        private Misharp.App _app;
        public AppApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<App> Create(string name, string description, List<string>? permission = null, string? callbackUrl = null)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
                { "description", description },
                { "permission", permission },
                { "callbackUrl", callbackUrl },
            };
            var result = await _app.Request<App>("app/create", param, false);
            return result;
        }
        public async Task<App> Show(string appId)
        {
            var param = new Dictionary<string, object?>
            {
                { "appId", appId },
            };
            var result = await _app.Request<App>("app/show", param, false);
            return result;
        }
    }
}
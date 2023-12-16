using Misharp.Model;
namespace Misharp.Controls
{
    public class PagesApi
    {
        private Misharp.App _app;
        public PagesApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<Page> Create(string title, string name, string script, string? summary = null, List<object>? content = null, List<object>? variables = null, string? eyeCatchingImageId = null, FontEnum font = FontEnum.SansSerif, bool alignCenter = false, bool hideTitleWhenPinned = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "title", title },
                { "name", name },
                { "summary", summary },
                { "content", content },
                { "variables", variables },
                { "script", script },
                { "eyeCatchingImageId", eyeCatchingImageId },
                { "font", font },
                { "alignCenter", alignCenter },
                { "hideTitleWhenPinned", hideTitleWhenPinned },
            };
            var result = await _app.Request<Page>("pages/create", param, true);
            return result;
        }
        public enum FontEnum
        {
            [StringValue("serif")]
            Serif,
            [StringValue("sans-serif")]
            SansSerif,
        }
        public async Task<List<Page>> Featured()
        {
            var result = await _app.Request<List<Page>>("pages/featured", false);
            return result;
        }
        public async Task<Page> Show(string pageId, string name, string username)
        {
            var param = new Dictionary<string, object?>
            {
                { "pageId", pageId },
                { "name", name },
                { "username", username },
            };
            var result = await _app.Request<Page>("pages/show", param, false);
            return result;
        }
    }
}
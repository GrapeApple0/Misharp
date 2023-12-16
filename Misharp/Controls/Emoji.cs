using Misharp.Model;
namespace Misharp.Controls
{
    public class EmojiApi
    {
        private Misharp.App _app;
        public EmojiApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<EmojiDetailed> Emoji(string name)
        {
            var param = new Dictionary<string, object?>
            {
                { "name", name },
            };
            var result = await _app.Request<EmojiDetailed>("emoji", param, false);
            return result;
        }
    }
}
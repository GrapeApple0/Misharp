namespace Misharp.Controls
{
    public class GetAvatarDecorationsApi
    {
        private Misharp.App _app;
        public GetAvatarDecorationsApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<object>> Getavatardecorations()
        {
            var result = await _app.Request<List<object>>("get-avatar-decorations", false);
            return result;
        }
    }
}
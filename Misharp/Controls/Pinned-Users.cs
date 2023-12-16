using Misharp.Model;
namespace Misharp.Controls
{
    public class PinnedUsersApi
    {
        private Misharp.App _app;
        public PinnedUsersApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<List<UserDetailed>> Pinnedusers()
        {
            var result = await _app.Request<List<UserDetailed>>("pinned-users", false);
            return result;
        }
    }
}
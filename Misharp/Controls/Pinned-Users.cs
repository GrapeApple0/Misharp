using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class PinnedUsersApi {
		private Misharp.App _app;
		public PinnedUsersApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<UserDetailed>>> Pinnedusers()
		{
			var result = await _app.Request<List<UserDetailed>>("pinned-users", useToken: false);
			return result;
		}
	}
}
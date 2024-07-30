using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class PinnedUsersApi {
		private Misharp.App _app;
		public PinnedUsersApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.UserDetailed>>> PinnedUsers()
		{
			Response<List<Model.UserDetailed>> result = await _app.Request<List<Model.UserDetailed>>("pinned-users", useToken: false);
			return result;
		}
	}
}
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
		public async Task<Response<List<UserDetailed>>> PinnedUsers()
		{
			var result = await _app.Request<Model.EmptyResponse>("pinned-users", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class ResetDbApi {
		private Misharp.App _app;
		public ResetDbApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Resetdb()
		{
			var result = await _app.Request<Models.EmptyResponse>("reset-db", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class ResetDbApi {
		private Misharp.App _app;
		public ResetDbApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Resetdb()
		{
			var result = await _app.Request<Model.EmptyResponse>("reset-db", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
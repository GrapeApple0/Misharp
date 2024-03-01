using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class EndpointsApi {
		private Misharp.App _app;
		public EndpointsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<string>>> Endpoints()
		{
			Response<List<string>> result = await _app.Request<List<string>>("endpoints", useToken: false);
			return result;
		}
	}
}
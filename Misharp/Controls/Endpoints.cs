using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class EndpointsApi {
		private Misharp.App _app;
		public EndpointsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<string>>> Endpoints()
		{
			var result = await _app.Request<List<string>>("endpoints", useToken: false);
			return result;
		}
	}
}
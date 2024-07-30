using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class RetentionApi {
		private Misharp.App _app;
		public RetentionApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<object>>> Retention()
		{
			Response<List<object>> result = await _app.Request<List<object>>("retention", useToken: false);
			return result;
		}
	}
}
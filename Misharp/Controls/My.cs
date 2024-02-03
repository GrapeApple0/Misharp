using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class MyApi {
		private Misharp.App _app;
		public MyApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<App>>> Apps(int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "offset", offset },
			};
			var result = await _app.Request<List<App>>("my/apps", param, useToken: true);
			return result;
		}
	}
}
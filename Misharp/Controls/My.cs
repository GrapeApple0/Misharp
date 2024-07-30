using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class MyApi {
		private Misharp.App _app;
		public MyApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.App>>> Apps(int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "offset", offset },
			};
			Response<List<Model.App>> result = await _app.Request<List<Model.App>>("my/apps", param, useToken: true);
			return result;
		}
	}
}
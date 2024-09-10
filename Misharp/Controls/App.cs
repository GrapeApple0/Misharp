using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class AppApi {
		private Misharp.App _app;
		public AppApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.App>> Create(string name,string description,List<string>? permission = null,string? callbackUrl = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "description", description },
				{ "permission", permission },
				{ "callbackUrl", callbackUrl },
			};
			var result = await _app.Request<Model.App>("app/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<Model.App>> Show(string appId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "appId", appId },
			};
			var result = await _app.Request<Model.App>("app/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class BlockingApi {
		private Misharp.App _app;
		public BlockingApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.UserDetailedNotMe>> Create(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("blocking/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserDetailedNotMe>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("blocking/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Blocking>>> List(int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<Model.EmptyResponse>("blocking/list", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
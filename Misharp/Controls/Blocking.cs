using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
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
			Response<Model.UserDetailedNotMe> result = await _app.Request<Model.UserDetailedNotMe>("blocking/create", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserDetailedNotMe>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			Response<Model.UserDetailedNotMe> result = await _app.Request<Model.UserDetailedNotMe>("blocking/delete", param, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Blocking>>> List(int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Blocking>> result = await _app.Request<List<Model.Blocking>>("blocking/list", param, useToken: true);
			return result;
		}
	}
}
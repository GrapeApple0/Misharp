using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class MuteApi {
		private Misharp.App _app;
		public MuteApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Create(string userId,int? expiresAt = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "expiresAt", expiresAt },
			};
			var result = await _app.Request<Model.EmptyResponse>("mute/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("mute/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Muting>>> List(string sinceId,int limit = 30,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Muting>> result = await _app.Request<List<Model.Muting>>("mute/list", param, useToken: true);
			return result;
		}
	}
}
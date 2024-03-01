using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class FollowingApi {
		private Misharp.App _app;
		public Following.RequestsApi RequestsApi;
		public FollowingApi(Misharp.App app)
		{
			_app = app;
			RequestsApi = new Following.RequestsApi(_app);
		}
		public async Task<Response<Model.UserLite>> Create(string userId,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "withReplies", withReplies },
			};
			Response<Model.UserLite> result = await _app.Request<Model.UserLite>("following/create", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserLite>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			Response<Model.UserLite> result = await _app.Request<Model.UserLite>("following/delete", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserLite>> Update(string userId,UpdateNotifyEnum notify,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "notify", notify },
				{ "withReplies", withReplies },
			};
			Response<Model.UserLite> result = await _app.Request<Model.UserLite>("following/update", param, useToken: true);
			return result;
		}
		public enum UpdateNotifyEnum {
			[StringValue("normal")]
			Normal,
			[StringValue("none")]
			None,
		}
		public async Task<Response<Model.EmptyResponse>> Updateall(UpdateallNotifyEnum notify,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "notify", notify },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<Model.EmptyResponse>("following/update-all", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum UpdateallNotifyEnum {
			[StringValue("normal")]
			Normal,
			[StringValue("none")]
			None,
		}
		public async Task<Response<Model.UserLite>> Invalidate(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			Response<Model.UserLite> result = await _app.Request<Model.UserLite>("following/invalidate", param, useToken: true);
			return result;
		}
	}
}
namespace Misharp.Controls.Following {
	public class RequestsApi
	{
		private Misharp.App _app;
		public RequestsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Accept(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("following/requests/accept", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserLite>> Cancel(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.UserLite>("following/requests/cancel", param, useToken: true);
			return result;
		}
		public async Task<Response<List<JsonNode>>> List(string sinceId,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<JsonNode>>("following/requests/list", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Reject(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("following/requests/reject", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
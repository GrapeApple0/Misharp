using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class FollowingApi {
		private Misharp.App _app;
		public Following.RequestsApi RequestsApi;
		public FollowingApi(Misharp.App app)
		{
			_app = app;
			RequestsApi = new Following.RequestsApi(_app);
		}
		public async Task<Models.Response<UserLite>> Create(string userId,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<UserLite>("following/create", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<UserLite>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserLite>("following/delete", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<UserLite>> Update(string userId,UpdateNotifyEnum notify,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "notify", notify },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<UserLite>("following/update", param, useToken: true);
			return result;
		}
		public enum UpdateNotifyEnum {
			[StringValue("normal")]
			Normal,
			[StringValue("none")]
			None,
		}
		public async Task<Models.Response<Models.EmptyResponse>> Updateall(UpdateallNotifyEnum notify,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "notify", notify },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<Models.EmptyResponse>("following/update-all", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum UpdateallNotifyEnum {
			[StringValue("normal")]
			Normal,
			[StringValue("none")]
			None,
		}
		public async Task<Models.Response<UserLite>> Invalidate(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserLite>("following/invalidate", param, useToken: true);
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
		public async Task<Models.Response<Models.EmptyResponse>> Accept(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Models.EmptyResponse>("following/requests/accept", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<UserLite>> Cancel(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserLite>("following/requests/cancel", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<object>>> List(string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<object>>("following/requests/list", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Reject(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Models.EmptyResponse>("following/requests/reject", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
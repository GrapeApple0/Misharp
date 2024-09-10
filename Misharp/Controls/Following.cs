using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
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
			var result = await _app.Request<Model.UserLite>("following/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.UserLite>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.UserLite>("following/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
			var result = await _app.Request<Model.UserLite>("following/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum UpdateNotifyEnum {
			[StringValue("normal")]
			Normal,
			[StringValue("none")]
			None,
		}
		public async Task<Response<Model.EmptyResponse>> UpdateAll(UpdateAllNotifyEnum notify,bool withReplies)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "notify", notify },
				{ "withReplies", withReplies },
			};
			var result = await _app.Request<Model.EmptyResponse>("following/update-all", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum UpdateAllNotifyEnum {
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
			var result = await _app.Request<Model.UserLite>("following/invalidate", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
			var result = await _app.Request<Model.UserLite>("following/requests/cancel", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class FollowingRequestsListItemResponseObject {
			public string Id { get; set; }
			public Model.UserLite Follower { get; set; }
			public Model.UserLite Followee { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class FollowingRequestsListItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					var sbFollower = new StringBuilder();
					sbFollower.Append("  follower: [\n");
					if (this.Follower != null)
					{
						sbFollower.Append(this.Follower);
						sbFollower.Replace("\n", "\n    ");
						sbFollower.Append("\n");
					}
					sbFollower.Append("  ]\n");
					sb.Append(sbFollower);
					var sbFollowee = new StringBuilder();
					sbFollowee.Append("  followee: [\n");
					if (this.Followee != null)
					{
						sbFollowee.Append(this.Followee);
						sbFollowee.Replace("\n", "\n    ");
						sbFollowee.Append("\n");
					}
					sbFollowee.Append("  ]\n");
					sb.Append(sbFollowee);
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<FollowingRequestsListItemResponseObject>>> List(string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<FollowingRequestsListItemResponseObject>>("following/requests/list", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
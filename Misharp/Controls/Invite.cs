using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class InviteApi {
		private Misharp.App _app;
		public InviteApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<InviteCode>> Create()
		{
			var result = await _app.Request<InviteCode>("invite/create", useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string inviteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "inviteId", inviteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("invite/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<InviteCode>>> List(string sinceId,string untilId,int limit = 30)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<InviteCode>>("invite/list", param, useToken: true);
			return result;
		}
		public class InviteLimitResponse {
			public int? Remaining { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  remaining: {this.Remaining}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Models.Response<InviteLimitResponse>> Limit()
		{
			var result = await _app.Request<InviteLimitResponse>("invite/limit", useToken: true);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class InviteApi {
		private Misharp.App _app;
		public InviteApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.InviteCode>> Create()
		{
			Response<Model.InviteCode> result = await _app.Request<Model.InviteCode>("invite/create", useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string inviteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "inviteId", inviteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("invite/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.InviteCode>>> List(string sinceId,int limit = 30,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.InviteCode>> result = await _app.Request<List<Model.InviteCode>>("invite/list", param, useToken: true);
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
		public async Task<Response<InviteLimitResponse>> Limit()
		{
			Response<InviteLimitResponse> result = await _app.Request<InviteLimitResponse>("invite/limit", useToken: true);
			return result;
		}
	}
}
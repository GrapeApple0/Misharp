using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class InviteApi {
		private Misharp.App _app;
		public InviteApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.InviteCode>> Create()
		{
			var result = await _app.Request<Model.InviteCode>("invite/create", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
		public async Task<Response<List<Model.InviteCode>>> List(int limit = 30,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Model.InviteCode>>("invite/list", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class LimitResponse {
			public int Remaining { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  remaining: {this.Remaining}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<LimitResponse>> Limit()
		{
			var result = await _app.Request<LimitResponse>("invite/limit", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
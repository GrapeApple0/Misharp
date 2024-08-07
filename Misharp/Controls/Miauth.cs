using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class MiauthApi {
		private Misharp.App _app;
		public MiauthApi(Misharp.App app)
		{
			_app = app;
		}
		public class MiauthGenTokenResponse {
			public string Token { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  token: {this.Token}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<MiauthGenTokenResponse>> GenToken(string? session = null,string? name = null,string? description = null,string? iconUrl = null,List<string>? permission = null)
		{
			permission ??= new();
			var param = new Dictionary<string, object?>	
			{
				{ "session", session },
				{ "name", name },
				{ "description", description },
				{ "iconUrl", iconUrl },
				{ "permission", permission },
			};
			Response<MiauthGenTokenResponse> result = await _app.Request<MiauthGenTokenResponse>("miauth/gen-token", param, useToken: true);
			return result;
		}
	}
}
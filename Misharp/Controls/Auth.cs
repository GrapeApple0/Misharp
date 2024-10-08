using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class AuthApi {
		private Misharp.App _app;
		public Auth.SessionApi SessionApi;
		public AuthApi(Misharp.App app)
		{
			_app = app;
			SessionApi = new Auth.SessionApi(_app);
		}
		public async Task<Response<Model.EmptyResponse>> Accept(string token)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "token", token },
			};
			var result = await _app.Request<Model.EmptyResponse>("auth/accept", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
namespace Misharp.Controls.Auth {
	public class SessionApi
	{
		private Misharp.App _app;
		public SessionApi(Misharp.App app)
		{
			_app = app;
		}
		public class AuthSessionGenerateResponse {
			public string Token { get; set; }
			public string Url { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  token: {this.Token}\n");
				sb.Append($"  url: {this.Url}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<AuthSessionGenerateResponse>> Generate(string appSecret)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "appSecret", appSecret },
			};
			var result = await _app.Request<AuthSessionGenerateResponse>("auth/session/generate", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public class AuthSessionShowResponse {
			public string Id { get; set; }
			public Model.App App { get; set; }
			public string Token { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  id: {this.Id}\n");
				var sbApp = new StringBuilder();
				sbApp.Append("  app: [\n");
				if (this.App != null)
				{
					sbApp.Append(this.App);
					sbApp.Replace("\n", "\n    ");
					sbApp.Append("\n");
				}
				sbApp.Append("  ]\n");
				sb.Append(sbApp);
				sb.Append($"  token: {this.Token}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<AuthSessionShowResponse>> Show(string token)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "token", token },
			};
			var result = await _app.Request<AuthSessionShowResponse>("auth/session/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public class AuthSessionUserkeyResponse {
			public string AccessToken { get; set; }
			public Model.UserDetailedNotMe User { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  accessToken: {this.AccessToken}\n");
				var sbUser = new StringBuilder();
				sbUser.Append("  user: [\n");
				if (this.User != null)
				{
					sbUser.Append(this.User);
					sbUser.Replace("\n", "\n    ");
					sbUser.Append("\n");
				}
				sbUser.Append("  ]\n");
				sb.Append(sbUser);
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<AuthSessionUserkeyResponse>> Userkey(string appSecret,string token)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "appSecret", appSecret },
				{ "token", token },
			};
			var result = await _app.Request<AuthSessionUserkeyResponse>("auth/session/userkey", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
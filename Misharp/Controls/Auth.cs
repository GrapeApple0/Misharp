using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class AuthApi {
		private Misharp.App _app;
		public Auth.SessionApi SessionApi;
		public AuthApi(Misharp.App app)
		{
			_app = app;
			SessionApi = new Auth.SessionApi(_app);
		}
		public async Task<Models.Response<Models.EmptyResponse>> Accept(string token)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "token", token },
			};
			var result = await _app.Request<Models.EmptyResponse>("auth/accept", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
		public async Task<Models.Response<AuthSessionGenerateResponse>> Generate(string appSecret)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "appSecret", appSecret },
			};
			var result = await _app.Request<AuthSessionGenerateResponse>("auth/session/generate", param, useToken: false);
			return result;
		}
		public class AuthSessionShowResponse {
			public string Id { get; set; }
			public App App { get; set; }
			public string Token { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  id: {this.Id}\n");
				var sbapp = new StringBuilder();
				sbapp.Append("  app: {\n");
				if (this.App != null)
				{
					sbapp.Append(this.App);
					sbapp.Replace("\n", "\n    ");
					sbapp.Append("\n");
				}
				sbapp.Append("  }\n");
				sb.Append(sbapp);
				sb.Append($"  token: {this.Token}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Models.Response<AuthSessionShowResponse>> Show(string token)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "token", token },
			};
			var result = await _app.Request<AuthSessionShowResponse>("auth/session/show", param, useToken: false);
			return result;
		}
		public class AuthSessionUserkeyResponse {
			public string AccessToken { get; set; }
			public UserDetailedNotMe User { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  accessToken: {this.AccessToken}\n");
				var sbuser = new StringBuilder();
				sbuser.Append("  user: {\n");
				if (this.User != null)
				{
					sbuser.Append(this.User);
					sbuser.Replace("\n", "\n    ");
					sbuser.Append("\n");
				}
				sbuser.Append("  }\n");
				sb.Append(sbuser);
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Models.Response<AuthSessionUserkeyResponse>> Userkey(string appSecret,string token)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "appSecret", appSecret },
				{ "token", token },
			};
			var result = await _app.Request<AuthSessionUserkeyResponse>("auth/session/userkey", param, useToken: false);
			return result;
		}
	}
}
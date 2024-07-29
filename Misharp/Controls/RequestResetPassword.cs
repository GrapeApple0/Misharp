using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class RequestResetPasswordApi {
		private Misharp.App _app;
		public RequestResetPasswordApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> RequestResetPassword(string username,string email)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "username", username },
				{ "email", email },
			};
			var result = await _app.Request<Model.EmptyResponse>("request-reset-password", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
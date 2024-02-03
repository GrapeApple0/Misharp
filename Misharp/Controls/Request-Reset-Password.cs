using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class RequestResetPasswordApi {
		private Misharp.App _app;
		public RequestResetPasswordApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Requestresetpassword(string username,string email)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "username", username },
				{ "email", email },
			};
			var result = await _app.Request<Models.EmptyResponse>("request-reset-password", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
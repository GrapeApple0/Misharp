using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class ResetPasswordApi {
		private Misharp.App _app;
		public ResetPasswordApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Resetpassword(string token,string password)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "token", token },
				{ "password", password },
			};
			var result = await _app.Request<Models.EmptyResponse>("reset-password", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
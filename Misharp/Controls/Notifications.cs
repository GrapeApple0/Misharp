using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class NotificationsApi {
		private Misharp.App _app;
		public NotificationsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Create(string body,string? header = null,string? icon = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "body", body },
				{ "header", header },
				{ "icon", icon },
			};
			var result = await _app.Request<Models.EmptyResponse>("notifications/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Markallasread()
		{
			var result = await _app.Request<Models.EmptyResponse>("notifications/mark-all-as-read", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Testnotification()
		{
			var result = await _app.Request<Models.EmptyResponse>("notifications/test-notification", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
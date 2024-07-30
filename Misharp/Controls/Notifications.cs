using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class NotificationsApi {
		private Misharp.App _app;
		public NotificationsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Create(string body,string? header = null,string? icon = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "body", body },
				{ "header", header },
				{ "icon", icon },
			};
			var result = await _app.Request<Model.EmptyResponse>("notifications/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Flush()
		{
			var result = await _app.Request<Model.EmptyResponse>("notifications/flush", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> MarkAllAsRead()
		{
			var result = await _app.Request<Model.EmptyResponse>("notifications/mark-all-as-read", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> TestNotification()
		{
			var result = await _app.Request<Model.EmptyResponse>("notifications/test-notification", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
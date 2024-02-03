using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class RenoteMuteApi {
		private Misharp.App _app;
		public RenoteMuteApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Create(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Models.EmptyResponse>("renote-mute/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Models.EmptyResponse>("renote-mute/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<RenoteMuting>>> List(string sinceId,string untilId,int limit = 30)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<RenoteMuting>>("renote-mute/list", param, useToken: true);
			return result;
		}
	}
}
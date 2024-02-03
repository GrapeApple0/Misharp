using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class MuteApi {
		private Misharp.App _app;
		public MuteApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Create(string userId,int? expiresAt = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
				{ "expiresAt", expiresAt },
			};
			var result = await _app.Request<Models.EmptyResponse>("mute/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Models.EmptyResponse>("mute/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Muting>>> List(string sinceId,string untilId,int limit = 30)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Muting>>("mute/list", param, useToken: true);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class BlockingApi {
		private Misharp.App _app;
		public BlockingApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<UserDetailedNotMe>> Create(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserDetailedNotMe>("blocking/create", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<UserDetailedNotMe>> Delete(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<UserDetailedNotMe>("blocking/delete", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Blocking>>> List(string sinceId,string untilId,int limit = 30)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Blocking>>("blocking/list", param, useToken: true);
			return result;
		}
	}
}
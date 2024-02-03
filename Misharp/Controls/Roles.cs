using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class RolesApi {
		private Misharp.App _app;
		public RolesApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<Role>>> List()
		{
			var result = await _app.Request<List<Role>>("roles/list", useToken: true);
			return result;
		}
		public async Task<Models.Response<Role>> Show(string roleId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "roleId", roleId },
			};
			var result = await _app.Request<Role>("roles/show", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<object>>> Users(string roleId,string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "roleId", roleId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<object>>("roles/users", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Notes(string roleId,string sinceId,string untilId,int sinceDate,int untilDate,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "roleId", roleId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			var result = await _app.Request<List<Note>>("roles/notes", param, useToken: true);
			return result;
		}
	}
}
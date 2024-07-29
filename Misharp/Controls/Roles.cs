using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class RolesApi {
		private Misharp.App _app;
		public RolesApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.Role>>> List()
		{
			Response<List<Model.Role>> result = await _app.Request<List<Model.Role>>("roles/list", useToken: true);
			return result;
		}
		public async Task<Response<Model.Role>> Show(string roleId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "roleId", roleId },
			};
			Response<Model.Role> result = await _app.Request<Model.Role>("roles/show", param, useToken: false);
			return result;
		}
		public async Task<Response<List<JsonNode>>> Users(string roleId,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "roleId", roleId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			Response<List<JsonNode>> result = await _app.Request<List<JsonNode>>("roles/users", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Notes(string roleId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
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
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("roles/notes", param, useToken: true);
			return result;
		}
	}
}
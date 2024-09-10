using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class RolesApi {
		private Misharp.App _app;
		public RolesApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.Role>>> List()
		{
			var result = await _app.Request<List<Model.Role>>("roles/list", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.Role>> Show(string roleId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "roleId", roleId },
			};
			var result = await _app.Request<Model.Role>("roles/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public class UsersItemResponseObject {
			public string Id { get; set; }
			public Model.UserDetailed User { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class UsersItemResponseObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					var sbUser = new StringBuilder();
					sbUser.Append("  user: [\n");
					if (this.User != null)
					{
						sbUser.Append(this.User);
						sbUser.Replace("\n", "\n    ");
						sbUser.Append("\n");
					}
					sbUser.Append("  ]\n");
					sb.Append(sbUser);
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<UsersItemResponseObject>>> Users(string roleId,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "roleId", roleId },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<UsersItemResponseObject>>("roles/users", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
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
			var result = await _app.Request<List<Model.Note>>("roles/notes", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
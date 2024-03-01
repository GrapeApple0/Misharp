using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class AntennasApi {
		private Misharp.App _app;
		public AntennasApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.Antenna>> Create(string name,CreateSrcEnum src,List<List<string>> keywords,List<List<string>> excludeKeywords,List<string> users,bool caseSensitive,bool localOnly,bool withReplies,bool withFile,bool notify,string? userListId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "src", src },
				{ "userListId", userListId },
				{ "keywords", keywords },
				{ "excludeKeywords", excludeKeywords },
				{ "users", users },
				{ "caseSensitive", caseSensitive },
				{ "localOnly", localOnly },
				{ "withReplies", withReplies },
				{ "withFile", withFile },
				{ "notify", notify },
			};
			Response<Model.Antenna> result = await _app.Request<Model.Antenna>("antennas/create", param, useToken: true);
			return result;
		}
		public enum CreateSrcEnum {
			[StringValue("home")]
			Home,
			[StringValue("all")]
			All,
			[StringValue("users")]
			Users,
			[StringValue("list")]
			List,
			[StringValue("users_blacklist")]
			Users_blacklist,
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string antennaId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "antennaId", antennaId },
			};
			var result = await _app.Request<Model.EmptyResponse>("antennas/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Antenna>>> List()
		{
			Response<List<Model.Antenna>> result = await _app.Request<List<Model.Antenna>>("antennas/list", useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Notes(string antennaId,string sinceId,int limit = 10,string? untilId = null,int? sinceDate = null,int? untilDate = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "antennaId", antennaId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("antennas/notes", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.Antenna>> Show(string antennaId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "antennaId", antennaId },
			};
			Response<Model.Antenna> result = await _app.Request<Model.Antenna>("antennas/show", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.Antenna>> Update(string antennaId,string name,UpdateSrcEnum src,List<List<string>> keywords,List<List<string>> excludeKeywords,List<string> users,bool caseSensitive,bool localOnly,bool withReplies,bool withFile,bool notify,string? userListId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "antennaId", antennaId },
				{ "name", name },
				{ "src", src },
				{ "userListId", userListId },
				{ "keywords", keywords },
				{ "excludeKeywords", excludeKeywords },
				{ "users", users },
				{ "caseSensitive", caseSensitive },
				{ "localOnly", localOnly },
				{ "withReplies", withReplies },
				{ "withFile", withFile },
				{ "notify", notify },
			};
			Response<Model.Antenna> result = await _app.Request<Model.Antenna>("antennas/update", param, useToken: true);
			return result;
		}
		public enum UpdateSrcEnum {
			[StringValue("home")]
			Home,
			[StringValue("all")]
			All,
			[StringValue("users")]
			Users,
			[StringValue("list")]
			List,
			[StringValue("users_blacklist")]
			Users_blacklist,
		}
	}
}
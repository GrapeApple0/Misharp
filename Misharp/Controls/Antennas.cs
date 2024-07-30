using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class AntennasApi {
		private Misharp.App _app;
		public AntennasApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.Antenna>> Create(string name,CreateSrcEnum src,bool caseSensitive,bool localOnly,bool excludeBots,bool withReplies,bool withFile,string? userListId = null,List<List<string>>? keywords = null,List<List<string>>? excludeKeywords = null,List<string>? users = null)
		{
			keywords ??= new();
			excludeKeywords ??= new();
			users ??= new();
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
				{ "excludeBots", excludeBots },
				{ "withReplies", withReplies },
				{ "withFile", withFile },
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
		public async Task<Response<List<Model.Note>>> Notes(string antennaId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null)
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
		public async Task<Response<Model.Antenna>> Update(string antennaId,string name,UpdateSrcEnum src,bool caseSensitive,bool localOnly,bool excludeBots,bool withReplies,bool withFile,string? userListId = null,List<List<string>>? keywords = null,List<List<string>>? excludeKeywords = null,List<string>? users = null)
		{
			keywords ??= new();
			excludeKeywords ??= new();
			users ??= new();
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
				{ "excludeBots", excludeBots },
				{ "withReplies", withReplies },
				{ "withFile", withFile },
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
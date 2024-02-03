using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class AntennasApi {
		private Misharp.App _app;
		public AntennasApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Antenna>> Create(string name,CreateSrcEnum src,bool caseSensitive,bool localOnly,bool withReplies,bool withFile,bool notify,string? userListId = null,List<string>? keywords = null,List<string>? excludeKeywords = null,List<string>? users = null)
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
			var result = await _app.Request<Antenna>("antennas/create", param, useToken: true);
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
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string antennaId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "antennaId", antennaId },
			};
			var result = await _app.Request<Models.EmptyResponse>("antennas/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Antenna>>> List()
		{
			var result = await _app.Request<List<Antenna>>("antennas/list", useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Notes(string antennaId,string sinceId,string untilId,int sinceDate,int untilDate,int limit = 10)
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
			var result = await _app.Request<List<Note>>("antennas/notes", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Antenna>> Show(string antennaId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "antennaId", antennaId },
			};
			var result = await _app.Request<Antenna>("antennas/show", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Antenna>> Update(string antennaId,string name,UpdateSrcEnum src,bool caseSensitive,bool localOnly,bool withReplies,bool withFile,bool notify,string? userListId = null,List<string>? keywords = null,List<string>? excludeKeywords = null,List<string>? users = null)
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
			var result = await _app.Request<Antenna>("antennas/update", param, useToken: true);
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
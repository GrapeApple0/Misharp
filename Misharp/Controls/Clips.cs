using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class ClipsApi {
		private Misharp.App _app;
		public ClipsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Addnote(string clipId,string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("clips/add-note", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Removenote(string clipId,string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("clips/remove-note", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Clip>> Create(string name,bool isPublic = false,string? description = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "isPublic", isPublic },
				{ "description", description },
			};
			var result = await _app.Request<Clip>("clips/create", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Models.EmptyResponse>("clips/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Clip>>> List()
		{
			var result = await _app.Request<List<Clip>>("clips/list", useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Notes(string clipId,string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Note>>("clips/notes", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Clip>> Show(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Clip>("clips/show", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Clip>> Update(string clipId,string name,bool isPublic,string? description = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "name", name },
				{ "isPublic", isPublic },
				{ "description", description },
			};
			var result = await _app.Request<Clip>("clips/update", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Favorite(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Models.EmptyResponse>("clips/favorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Unfavorite(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Models.EmptyResponse>("clips/unfavorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Clip>>> Myfavorites()
		{
			var result = await _app.Request<List<Clip>>("clips/my-favorites", useToken: true);
			return result;
		}
	}
}
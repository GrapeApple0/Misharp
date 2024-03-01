using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class ClipsApi {
		private Misharp.App _app;
		public ClipsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Addnote(string clipId,string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("clips/add-note", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Removenote(string clipId,string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("clips/remove-note", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.Clip>> Create(string name,bool isPublic = false,string? description = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "isPublic", isPublic },
				{ "description", description },
			};
			Response<Model.Clip> result = await _app.Request<Model.Clip>("clips/create", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Model.EmptyResponse>("clips/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Clip>>> List()
		{
			Response<List<Model.Clip>> result = await _app.Request<List<Model.Clip>>("clips/list", useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Notes(string clipId,string sinceId,int limit = 10,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Note>> result = await _app.Request<List<Model.Note>>("clips/notes", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.Clip>> Show(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			Response<Model.Clip> result = await _app.Request<Model.Clip>("clips/show", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.Clip>> Update(string clipId,string name,bool isPublic,string? description = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "name", name },
				{ "isPublic", isPublic },
				{ "description", description },
			};
			Response<Model.Clip> result = await _app.Request<Model.Clip>("clips/update", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Favorite(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Model.EmptyResponse>("clips/favorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unfavorite(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Model.EmptyResponse>("clips/unfavorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Clip>>> Myfavorites()
		{
			Response<List<Model.Clip>> result = await _app.Request<List<Model.Clip>>("clips/my-favorites", useToken: true);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class ClipsApi {
		private Misharp.App _app;
		public ClipsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> AddNote(string clipId,string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("clips/add-note", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> RemoveNote(string clipId,string noteId)
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
			var result = await _app.Request<Model.Clip>("clips/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
			var result = await _app.Request<List<Model.Clip>>("clips/list", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Notes(string clipId,int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Model.Note>>("clips/notes", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<Model.Clip>> Show(string clipId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "clipId", clipId },
			};
			var result = await _app.Request<Model.Clip>("clips/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
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
			var result = await _app.Request<Model.Clip>("clips/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
		public async Task<Response<List<Model.Clip>>> MyFavorites()
		{
			var result = await _app.Request<List<Model.Clip>>("clips/my-favorites", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
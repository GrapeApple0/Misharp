using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class FlashApi {
		private Misharp.App _app;
		public FlashApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.Flash>> Create(string title,string summary,string script,List<string>? permissions = null,CreateVisibilityEnum visibility = CreateVisibilityEnum.Public)
		{
			permissions ??= new();
			var param = new Dictionary<string, object?>	
			{
				{ "title", title },
				{ "summary", summary },
				{ "script", script },
				{ "permissions", permissions },
				{ "visibility", visibility },
			};
			Response<Model.Flash> result = await _app.Request<Model.Flash>("flash/create", param, useToken: true);
			return result;
		}
		public enum CreateVisibilityEnum {
			[StringValue("public")]
			Public,
			[StringValue("private")]
			Private,
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string flashId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<Model.EmptyResponse>("flash/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Flash>>> Featured()
		{
			Response<List<Model.Flash>> result = await _app.Request<List<Model.Flash>>("flash/featured", useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Like(string flashId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<Model.EmptyResponse>("flash/like", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.Flash>> Show(string flashId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
			};
			Response<Model.Flash> result = await _app.Request<Model.Flash>("flash/show", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unlike(string flashId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<Model.EmptyResponse>("flash/unlike", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Update(string flashId,string title,string summary,string script,UpdateVisibilityEnum visibility,List<string>? permissions = null)
		{
			permissions ??= new();
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
				{ "title", title },
				{ "summary", summary },
				{ "script", script },
				{ "permissions", permissions },
				{ "visibility", visibility },
			};
			var result = await _app.Request<Model.EmptyResponse>("flash/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum UpdateVisibilityEnum {
			[StringValue("public")]
			Public,
			[StringValue("private")]
			Private,
		}
		public async Task<Response<List<Model.Flash>>> My(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.Flash>> result = await _app.Request<List<Model.Flash>>("flash/my", param, useToken: true);
			return result;
		}
		public async Task<Response<List<object>>> MyLikes(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<object>> result = await _app.Request<List<object>>("flash/my-likes", param, useToken: true);
			return result;
		}
	}
}
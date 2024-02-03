using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class FlashApi {
		private Misharp.App _app;
		public FlashApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Flash>> Create(string title,string summary,string script,List<string>? permissions = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "title", title },
				{ "summary", summary },
				{ "script", script },
				{ "permissions", permissions },
			};
			var result = await _app.Request<Flash>("flash/create", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string flashId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<Models.EmptyResponse>("flash/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Flash>>> Featured()
		{
			var result = await _app.Request<List<Flash>>("flash/featured", useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Like(string flashId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<Models.EmptyResponse>("flash/like", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Flash>> Show(string flashId,string username)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
				{ "username", username },
			};
			var result = await _app.Request<Flash>("flash/show", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Unlike(string flashId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
			};
			var result = await _app.Request<Models.EmptyResponse>("flash/unlike", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Update(string flashId,string title,string summary,string script,UpdateVisibilityEnum visibility,List<string>? permissions = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "flashId", flashId },
				{ "title", title },
				{ "summary", summary },
				{ "script", script },
				{ "permissions", permissions },
				{ "visibility", visibility },
			};
			var result = await _app.Request<Models.EmptyResponse>("flash/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum UpdateVisibilityEnum {
			[StringValue("public")]
			Public,
			[StringValue("private")]
			Private,
		}
		public async Task<Models.Response<List<Flash>>> My(string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<Flash>>("flash/my", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<object>>> Mylikes(string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<object>>("flash/my-likes", param, useToken: true);
			return result;
		}
	}
}
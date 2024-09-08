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
			var param = new Dictionary<string, object?>	
			{
				{ "title", title },
				{ "summary", summary },
				{ "script", script },
				{ "permissions", permissions },
				{ "visibility", visibility },
			};
			var result = await _app.Request<Model.EmptyResponse>("flash/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
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
		public async Task<Response<List<Flash>>> Featured()
		{
			var result = await _app.Request<Model.EmptyResponse>("flash/featured", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
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
			var result = await _app.Request<Model.EmptyResponse>("flash/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
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
		public async Task<Response<List<Flash>>> My(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<Model.EmptyResponse>("flash/my", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class MyLikesItemResponseObject {
			public string Id { get; set; }
			public Flash Flash { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MyLikesItemResponseObject: {\n");
				sb.Append($"  id: {this.Id}\n");
				var sbFlash = new StringBuilder();
				sbFlash.Append("  flash: [\n");
				if (this.Flash != null)
				{
					sbFlash.Append(this.Flash);
					sbFlash.Replace("\n", "\n    ");
					sbFlash.Append("\n");
				}
				sbFlash.Append("  ]\n");
				sb.Append(sbFlash);
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<List<MyLikesItemResponseObject>>> MyLikes(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<Model.EmptyResponse>("flash/my-likes", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
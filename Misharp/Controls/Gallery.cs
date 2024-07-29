using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class GalleryApi {
		private Misharp.App _app;
		public Gallery.PostsApi PostsApi;
		public GalleryApi(Misharp.App app)
		{
			_app = app;
			PostsApi = new Gallery.PostsApi(_app);
		}
		public async Task<Response<List<Model.GalleryPost>>> Featured(int limit = 10,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "untilId", untilId },
			};
			Response<List<Model.GalleryPost>> result = await _app.Request<List<Model.GalleryPost>>("gallery/featured", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.GalleryPost>>> Popular()
		{
			Response<List<Model.GalleryPost>> result = await _app.Request<List<Model.GalleryPost>>("gallery/popular", useToken: false);
			return result;
		}
		public async Task<Response<List<Model.GalleryPost>>> Posts(int limit = 10,string? sinceId = null,string? untilId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			Response<List<Model.GalleryPost>> result = await _app.Request<List<Model.GalleryPost>>("gallery/posts", param, useToken: false);
			return result;
		}
	}
}
namespace Misharp.Controls.Gallery {
	public class PostsApi
	{
		private Misharp.App _app;
		public PostsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.GalleryPost>> Create(string title,string? description = null,List<string>? fileIds = null,bool isSensitive = false)
		{
			fileIds ??= new();
			var param = new Dictionary<string, object?>	
			{
				{ "title", title },
				{ "description", description },
				{ "fileIds", fileIds },
				{ "isSensitive", isSensitive },
			};
			var result = await _app.Request<Model.GalleryPost>("gallery/posts/create", param, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Delete(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<Model.EmptyResponse>("gallery/posts/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Like(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<Model.EmptyResponse>("gallery/posts/like", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.GalleryPost>> Show(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<Model.GalleryPost>("gallery/posts/show", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unlike(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<Model.EmptyResponse>("gallery/posts/unlike", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.GalleryPost>> Update(string postId,string title,string? description = null,List<string>? fileIds = null,bool isSensitive = false)
		{
			fileIds ??= new();
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
				{ "title", title },
				{ "description", description },
				{ "fileIds", fileIds },
				{ "isSensitive", isSensitive },
			};
			var result = await _app.Request<Model.GalleryPost>("gallery/posts/update", param, useToken: true);
			return result;
		}
	}
}
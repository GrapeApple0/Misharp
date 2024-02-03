using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class GalleryApi {
		private Misharp.App _app;
		public Gallery.PostsApi PostsApi;
		public GalleryApi(Misharp.App app)
		{
			_app = app;
			PostsApi = new Gallery.PostsApi(_app);
		}
		public async Task<Models.Response<List<GalleryPost>>> Featured(string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<GalleryPost>>("gallery/featured", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<GalleryPost>>> Popular()
		{
			var result = await _app.Request<List<GalleryPost>>("gallery/popular", useToken: false);
			return result;
		}
		public async Task<Models.Response<List<GalleryPost>>> Posts(string sinceId,string untilId,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
			};
			var result = await _app.Request<List<GalleryPost>>("gallery/posts", param, useToken: false);
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
		public async Task<Models.Response<GalleryPost>> Create(string title,string? description = null,List<string>? fileIds = null,bool isSensitive = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "title", title },
				{ "description", description },
				{ "fileIds", fileIds },
				{ "isSensitive", isSensitive },
			};
			var result = await _app.Request<GalleryPost>("gallery/posts/create", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<Models.EmptyResponse>("gallery/posts/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Like(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<Models.EmptyResponse>("gallery/posts/like", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<GalleryPost>> Show(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<GalleryPost>("gallery/posts/show", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Unlike(string postId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
			};
			var result = await _app.Request<Models.EmptyResponse>("gallery/posts/unlike", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<GalleryPost>> Update(string postId,string title,string? description = null,List<string>? fileIds = null,bool isSensitive = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "postId", postId },
				{ "title", title },
				{ "description", description },
				{ "fileIds", fileIds },
				{ "isSensitive", isSensitive },
			};
			var result = await _app.Request<GalleryPost>("gallery/posts/update", param, useToken: true);
			return result;
		}
	}
}
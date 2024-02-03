using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class PagesApi {
		private Misharp.App _app;
		public PagesApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Page>> Create(string title,string name,string script,string? summary = null,List<object>? content = null,List<object>? variables = null,string? eyeCatchingImageId = null,CreateFontEnum font = CreateFontEnum.SansSerif,bool alignCenter = false,bool hideTitleWhenPinned = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "title", title },
				{ "name", name },
				{ "summary", summary },
				{ "content", content },
				{ "variables", variables },
				{ "script", script },
				{ "eyeCatchingImageId", eyeCatchingImageId },
				{ "font", font },
				{ "alignCenter", alignCenter },
				{ "hideTitleWhenPinned", hideTitleWhenPinned },
			};
			var result = await _app.Request<Page>("pages/create", param, useToken: true);
			return result;
		}
		public enum CreateFontEnum {
			[StringValue("serif")]
			Serif,
			[StringValue("sans-serif")]
			SansSerif,
		}
		public async Task<Models.Response<Models.EmptyResponse>> Delete(string pageId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "pageId", pageId },
			};
			var result = await _app.Request<Models.EmptyResponse>("pages/delete", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Page>>> Featured()
		{
			var result = await _app.Request<List<Page>>("pages/featured", useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Like(string pageId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "pageId", pageId },
			};
			var result = await _app.Request<Models.EmptyResponse>("pages/like", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Page>> Show(string pageId,string name,string username)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "pageId", pageId },
				{ "name", name },
				{ "username", username },
			};
			var result = await _app.Request<Page>("pages/show", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Unlike(string pageId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "pageId", pageId },
			};
			var result = await _app.Request<Models.EmptyResponse>("pages/unlike", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Update(string pageId,string title,string name,string script,UpdateFontEnum font,bool alignCenter,bool hideTitleWhenPinned,string? summary = null,List<object>? content = null,List<object>? variables = null,string? eyeCatchingImageId = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "pageId", pageId },
				{ "title", title },
				{ "name", name },
				{ "summary", summary },
				{ "content", content },
				{ "variables", variables },
				{ "script", script },
				{ "eyeCatchingImageId", eyeCatchingImageId },
				{ "font", font },
				{ "alignCenter", alignCenter },
				{ "hideTitleWhenPinned", hideTitleWhenPinned },
			};
			var result = await _app.Request<Models.EmptyResponse>("pages/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public enum UpdateFontEnum {
			[StringValue("serif")]
			Serif,
			[StringValue("sans-serif")]
			SansSerif,
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class PromoApi {
		private Misharp.App _app;
		public PromoApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Read(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Models.EmptyResponse>("promo/read", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
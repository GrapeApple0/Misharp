using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class PromoApi {
		private Misharp.App _app;
		public PromoApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Read(string noteId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "noteId", noteId },
			};
			var result = await _app.Request<Model.EmptyResponse>("promo/read", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
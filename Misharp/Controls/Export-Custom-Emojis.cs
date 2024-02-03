using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class ExportCustomEmojisApi {
		private Misharp.App _app;
		public ExportCustomEmojisApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Exportcustomemojis()
		{
			var result = await _app.Request<Models.EmptyResponse>("export-custom-emojis", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
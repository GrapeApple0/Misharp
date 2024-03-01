using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class ExportCustomEmojisApi {
		private Misharp.App _app;
		public ExportCustomEmojisApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.EmptyResponse>> Exportcustomemojis()
		{
			var result = await _app.Request<Model.EmptyResponse>("export-custom-emojis", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
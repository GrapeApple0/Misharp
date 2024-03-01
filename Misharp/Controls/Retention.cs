using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class RetentionApi {
		private Misharp.App _app;
		public RetentionApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<JsonNode>>> Retention()
		{
			Response<List<JsonNode>> result = await _app.Request<List<JsonNode>>("retention", useToken: false);
			return result;
		}
	}
}
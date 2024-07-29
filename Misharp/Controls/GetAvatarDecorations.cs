using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class GetAvatarDecorationsApi {
		private Misharp.App _app;
		public GetAvatarDecorationsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<JsonNode>>> GetAvatarDecorations()
		{
			Response<List<JsonNode>> result = await _app.Request<List<JsonNode>>("get-avatar-decorations", useToken: false);
			return result;
		}
	}
}
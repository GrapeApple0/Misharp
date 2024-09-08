using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class ApApi {
		private Misharp.App _app;
		public ApApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<JsonNode>> Get(string uri)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "uri", uri },
			};
			var result = await _app.Request<Model.EmptyResponse>("ap/get", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class ShowResponse {
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("{\n");
			sb.Append("}");
			return sb.ToString();
		}
		}
		public async Task<Response<ShowResponse>> Show(string uri)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "uri", uri },
			};
			var result = await _app.Request<Model.EmptyResponse>("ap/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
	}
}
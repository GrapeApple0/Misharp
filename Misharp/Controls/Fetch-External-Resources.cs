using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class FetchExternalResourcesApi {
		private Misharp.App _app;
		public FetchExternalResourcesApi(Misharp.App app)
		{
			_app = app;
		}
		public class FetchexternalresourcesResponse {
			public string Type { get; set; }
			public string Data { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  type: {this.Type}\n");
				sb.Append($"  data: {this.Data}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<FetchexternalresourcesResponse>> Fetchexternalresources(string url,string hash)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "url", url },
				{ "hash", hash },
			};
			Response<FetchexternalresourcesResponse> result = await _app.Request<FetchexternalresourcesResponse>("fetch-external-resources", param, useToken: true);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class EndpointApi {
		private Misharp.App _app;
		public EndpointApi(Misharp.App app)
		{
			_app = app;
		}
		public class EndpointResponse {
		public class ParamsPropertyType {
			public string Name { get; set; }
			public string Type { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class ParamsPropertyType: {\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  type: {this.Type}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
			public List<ParamsPropertyType> Params { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("  params: [\n");
				if (this.Params != null && this.Params.Count > 0)
				{
					var sbParams = new StringBuilder();
					sbParams.Append("    ");
					this.Params.ForEach(item => sbParams.Append(item).Append(",\n"));
					sbParams.Replace("\n", "\n    ");
					sbParams.Length -= 4;
					sb.Append(sbParams);
				}
				sb.Append("  ]\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<EndpointResponse>> Endpoint(string endpoint)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<EndpointResponse>("endpoint", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
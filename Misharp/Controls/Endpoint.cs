using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class EndpointApi {
		private Misharp.App _app;
		public EndpointApi(Misharp.App app)
		{
			_app = app;
		}
		public class EndpointResponse {
			public List<object> Params { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("  params: {\n");
				if (this.Params != null && this.Params.Count > 0) this.Params.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Models.Response<EndpointResponse>> Endpoint(string endpoint)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<EndpointResponse>("endpoint", param, useToken: false);
			return result;
		}
	}
}
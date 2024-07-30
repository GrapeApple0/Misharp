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
		public class ApShowResponse {
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<ApShowResponse>> Show(string uri)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "uri", uri },
			};
			Response<ApShowResponse> result = await _app.Request<ApShowResponse>("ap/show", param, useToken: true);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class FetchRssApi {
		private Misharp.App _app;
		public FetchRssApi(Misharp.App app)
		{
			_app = app;
		}
		public class FetchrssResponse {
			public List<object> Items { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("  items: {\n");
				if (this.Items != null && this.Items.Count > 0) this.Items.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<FetchrssResponse>> Fetchrss(string url)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "url", url },
			};
			Response<FetchrssResponse> result = await _app.Request<FetchrssResponse>("fetch-rss", param, useToken: false);
			return result;
		}
	}
}
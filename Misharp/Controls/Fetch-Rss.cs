using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
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
		public async Task<Models.Response<FetchrssResponse>> Fetchrss(string url)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "url", url },
			};
			var result = await _app.Request<FetchrssResponse>("fetch-rss", param, useToken: false);
			return result;
		}
	}
}
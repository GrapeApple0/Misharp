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
		public class FetchRssResponse {
			public JsonNode Image { get; set; }
			public JsonNode PaginationLinks { get; set; }
			public string Link { get; set; }
			public string Title { get; set; }
			public List<object> Items { get; set; }
			public string FeedUrl { get; set; }
			public string Description { get; set; }
			public JsonNode Itunes { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  image: {this.Image}\n");
				sb.Append($"  paginationLinks: {this.PaginationLinks}\n");
				sb.Append($"  link: {this.Link}\n");
				sb.Append($"  title: {this.Title}\n");
				sb.Append("  items: {\n");
				if (this.Items != null && this.Items.Count > 0) this.Items.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append($"  feedUrl: {this.FeedUrl}\n");
				sb.Append($"  description: {this.Description}\n");
				sb.Append($"  itunes: {this.Itunes}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<FetchRssResponse>> FetchRss(string url)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "url", url },
			};
			Response<FetchRssResponse> result = await _app.Request<FetchRssResponse>("fetch-rss", param, useToken: false);
			return result;
		}
	}
}
using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class FetchRssApi {
		private Misharp.App _app;
		public FetchRssApi(Misharp.App app)
		{
			_app = app;
		}
		public class FetchRssResponse {
		public class ImageProperty {
			public string Link { get; set; }
			public string Url { get; set; }
			public string Title { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  link: {this.Link}\n");
				sb.Append($"  url: {this.Url}\n");
				sb.Append($"  title: {this.Title}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public ImageProperty Image { get; set; }
		public class PaginationLinksProperty {
			public string Self { get; set; }
			public string First { get; set; }
			public string Next { get; set; }
			public string Last { get; set; }
			public string Prev { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  self: {this.Self}\n");
				sb.Append($"  first: {this.First}\n");
				sb.Append($"  next: {this.Next}\n");
				sb.Append($"  last: {this.Last}\n");
				sb.Append($"  prev: {this.Prev}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public PaginationLinksProperty PaginationLinks { get; set; }
			public string Link { get; set; }
			public string Title { get; set; }
			public class ItemsItemsProperty {
				public string Link { get; set; }
				public string Guid { get; set; }
				public string Title { get; set; }
				public string PubDate { get; set; }
				public string Creator { get; set; }
				public string Summary { get; set; }
				public string Content { get; set; }
				public string IsoDate { get; set; }
				public List<string> Categories { get; set; }
				public string ContentSnippet { get; set; }
				public class EnclosureObject {
					public string Url { get; set; }
					public decimal Length { get; set; }
					public string Type { get; set; }
					public override string ToString()
					{
						var sb = new StringBuilder();
						sb.Append("class EnclosureObject: {\n");
						sb.Append($"  url: {this.Url}\n");
						sb.Append($"  length: {this.Length}\n");
						sb.Append($"  type: {this.Type}\n");
						sb.Append("}");
						return sb.ToString();
					}
				}
				public EnclosureObject Enclosure { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("{\n");
					sb.Append($"  link: {this.Link}\n");
					sb.Append($"  guid: {this.Guid}\n");
					sb.Append($"  title: {this.Title}\n");
					sb.Append($"  pubDate: {this.PubDate}\n");
					sb.Append($"  creator: {this.Creator}\n");
					sb.Append($"  summary: {this.Summary}\n");
					sb.Append($"  content: {this.Content}\n");
					sb.Append($"  isoDate: {this.IsoDate}\n");
					sb.Append("  categories: {\n");
					if (this.Categories != null && this.Categories.Count > 0) this.Categories.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
					sb.Append("  }\n");
					sb.Append($"  contentSnippet: {this.ContentSnippet}\n");
					var sbenclosure = new StringBuilder();
					sbenclosure.Append("  enclosure: {\n");
					if (this.Enclosure != null)
					{
						sbenclosure.Append(this.Enclosure);
						sbenclosure.Replace("\n", "\n  ");
						sbenclosure.Append("\n");
					}
					sbenclosure.Append("  }\n");
					sb.Append(sbenclosure);
					sb.Append("}");
					return sb.ToString();
				}
			}
			public List<ItemsItemsProperty> Items { get; set; }
			public string FeedUrl { get; set; }
			public string Description { get; set; }
		public class ItunesProperty {
			public string Image { get; set; }
			public class OwnerObject {
				public string Name { get; set; }
				public string Email { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class OwnerObject: {\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  email: {this.Email}\n");
					sb.Append("}");
					return sb.ToString();
				}
			}
			public OwnerObject Owner { get; set; }
			public string Author { get; set; }
			public string Summary { get; set; }
			public string Explicit { get; set; }
			public List<string> Categories { get; set; }
			public List<string> Keywords { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  image: {this.Image}\n");
				var sbowner = new StringBuilder();
				sbowner.Append("  owner: {\n");
				if (this.Owner != null)
				{
					sbowner.Append(this.Owner);
					sbowner.Replace("\n", "\n  ");
					sbowner.Append("\n");
				}
				sbowner.Append("  }\n");
				sb.Append(sbowner);
				sb.Append($"  author: {this.Author}\n");
				sb.Append($"  summary: {this.Summary}\n");
				sb.Append($"  explicit: {this.Explicit}\n");
				sb.Append("  categories: {\n");
				if (this.Categories != null && this.Categories.Count > 0) this.Categories.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append("  keywords: {\n");
				if (this.Keywords != null && this.Keywords.Count > 0) this.Keywords.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public ItunesProperty Itunes { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				var sbimage = new StringBuilder();
				sbimage.Append("  image: {\n");
				if (this.Image != null)
				{
					sbimage.Append(this.Image);
					sbimage.Replace("\n", "\n  ");
					sbimage.Append("\n");
				}
				sbimage.Append("  }\n");
				sb.Append(sbimage);
				var sbpaginationLinks = new StringBuilder();
				sbpaginationLinks.Append("  paginationLinks: {\n");
				if (this.PaginationLinks != null)
				{
					sbpaginationLinks.Append(this.PaginationLinks);
					sbpaginationLinks.Replace("\n", "\n  ");
					sbpaginationLinks.Append("\n");
				}
				sbpaginationLinks.Append("  }\n");
				sb.Append(sbpaginationLinks);
				sb.Append($"  link: {this.Link}\n");
				sb.Append($"  title: {this.Title}\n");
				sb.Append("  items: {\n");
				if (this.Items != null && this.Items.Count > 0) this.Items.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
				sb.Append("  }\n");
				sb.Append($"  feedUrl: {this.FeedUrl}\n");
				sb.Append($"  description: {this.Description}\n");
				var sbitunes = new StringBuilder();
				sbitunes.Append("  itunes: {\n");
				if (this.Itunes != null)
				{
					sbitunes.Append(this.Itunes);
					sbitunes.Replace("\n", "\n  ");
					sbitunes.Append("\n");
				}
				sbitunes.Append("  }\n");
				sb.Append(sbitunes);
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
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
		public class ImageObject {
			public string Link { get; set; }
			public string Url { get; set; }
			public string Title { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class ImageObject: {\n");
				sb.Append($"  link: {this.Link}\n");
				sb.Append($"  url: {this.Url}\n");
				sb.Append($"  title: {this.Title}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public ImageObject Image { get; set; }
		public class PaginationLinksObject {
			public string Self { get; set; }
			public string First { get; set; }
			public string Next { get; set; }
			public string Last { get; set; }
			public string Prev { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class PaginationLinksObject: {\n");
				sb.Append($"  self: {this.Self}\n");
				sb.Append($"  first: {this.First}\n");
				sb.Append($"  next: {this.Next}\n");
				sb.Append($"  last: {this.Last}\n");
				sb.Append($"  prev: {this.Prev}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public PaginationLinksObject PaginationLinks { get; set; }
			public string Link { get; set; }
			public string Title { get; set; }
		public class ItemsPropertyType {
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
				sb.Append("class ItemsPropertyType: {\n");
				sb.Append($"  link: {this.Link}\n");
				sb.Append($"  guid: {this.Guid}\n");
				sb.Append($"  title: {this.Title}\n");
				sb.Append($"  pubDate: {this.PubDate}\n");
				sb.Append($"  creator: {this.Creator}\n");
				sb.Append($"  summary: {this.Summary}\n");
				sb.Append($"  content: {this.Content}\n");
				sb.Append($"  isoDate: {this.IsoDate}\n");
				sb.Append("  categories: [\n");
				if (this.Categories != null && this.Categories.Count > 0)
				{
					var sbCategories = new StringBuilder();
					sbCategories.Append("    ");
					this.Categories.ForEach(item => sbCategories.Append(item).Append(",\n"));
					sbCategories.Replace("\n", "\n    ");
					sbCategories.Length -= 4;
					sb.Append(sbCategories);
				}
				sb.Append("  ]\n");
				sb.Append($"  contentSnippet: {this.ContentSnippet}\n");
				var sbEnclosure = new StringBuilder();
				sbEnclosure.Append("  enclosure: [\n");
				if (this.Enclosure != null)
				{
					sbEnclosure.Append(this.Enclosure);
					sbEnclosure.Replace("\n", "\n    ");
					sbEnclosure.Append("\n");
				}
				sbEnclosure.Append("  ]\n");
				sb.Append(sbEnclosure);
				sb.Append("}");
				return sb.ToString();
			}
		}
			public List<ItemsPropertyType> Items { get; set; }
			public string FeedUrl { get; set; }
			public string Description { get; set; }
		public class ItunesObject {
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
				sb.Append("class ItunesObject: {\n");
				sb.Append($"  image: {this.Image}\n");
				var sbOwner = new StringBuilder();
				sbOwner.Append("  owner: [\n");
				if (this.Owner != null)
				{
					sbOwner.Append(this.Owner);
					sbOwner.Replace("\n", "\n    ");
					sbOwner.Append("\n");
				}
				sbOwner.Append("  ]\n");
				sb.Append(sbOwner);
				sb.Append($"  author: {this.Author}\n");
				sb.Append($"  summary: {this.Summary}\n");
				sb.Append($"  explicit: {this.Explicit}\n");
				sb.Append("  categories: [\n");
				if (this.Categories != null && this.Categories.Count > 0)
				{
					var sbCategories = new StringBuilder();
					sbCategories.Append("    ");
					this.Categories.ForEach(item => sbCategories.Append(item).Append(",\n"));
					sbCategories.Replace("\n", "\n    ");
					sbCategories.Length -= 4;
					sb.Append(sbCategories);
				}
				sb.Append("  ]\n");
				sb.Append("  keywords: [\n");
				if (this.Keywords != null && this.Keywords.Count > 0)
				{
					var sbKeywords = new StringBuilder();
					sbKeywords.Append("    ");
					this.Keywords.ForEach(item => sbKeywords.Append(item).Append(",\n"));
					sbKeywords.Replace("\n", "\n    ");
					sbKeywords.Length -= 4;
					sb.Append(sbKeywords);
				}
				sb.Append("  ]\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
			public ItunesObject Itunes { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("{\n");
			var sbImage = new StringBuilder();
			sbImage.Append("  image: [\n");
			if (this.Image != null)
			{
				sbImage.Append(this.Image);
				sbImage.Replace("\n", "\n    ");
				sbImage.Append("\n");
			}
			sbImage.Append("  ]\n");
			sb.Append(sbImage);
			var sbPaginationLinks = new StringBuilder();
			sbPaginationLinks.Append("  paginationLinks: [\n");
			if (this.PaginationLinks != null)
			{
				sbPaginationLinks.Append(this.PaginationLinks);
				sbPaginationLinks.Replace("\n", "\n    ");
				sbPaginationLinks.Append("\n");
			}
			sbPaginationLinks.Append("  ]\n");
			sb.Append(sbPaginationLinks);
			sb.Append($"  link: {this.Link}\n");
			sb.Append($"  title: {this.Title}\n");
			sb.Append("  items: [\n");
			if (this.Items != null && this.Items.Count > 0)
			{
				var sbItems = new StringBuilder();
				sbItems.Append("    ");
				this.Items.ForEach(item => sbItems.Append(item).Append(",\n"));
				sbItems.Replace("\n", "\n    ");
				sbItems.Length -= 4;
				sb.Append(sbItems);
			}
			sb.Append("  ]\n");
			sb.Append($"  feedUrl: {this.FeedUrl}\n");
			sb.Append($"  description: {this.Description}\n");
			var sbItunes = new StringBuilder();
			sbItunes.Append("  itunes: [\n");
			if (this.Itunes != null)
			{
				sbItunes.Append(this.Itunes);
				sbItunes.Replace("\n", "\n    ");
				sbItunes.Append("\n");
			}
			sbItunes.Append("  ]\n");
			sb.Append(sbItunes);
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
			var result = await _app.Request<Model.EmptyResponse>("fetch-rss", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
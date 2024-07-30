using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Announcement {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Text { get; set; }
		public string Title { get; set; }
		public string? ImageUrl { get; set; }
		public string Icon { get; set; }
		public string Display { get; set; }
		public bool NeedConfirmationToRead { get; set; }
		public bool Silence { get; set; }
		public bool ForYou { get; set; }
		public bool IsRead { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Announcement: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  updatedAt: {this.UpdatedAt}\n");
			sb.Append($"  text: {this.Text}\n");
			sb.Append($"  title: {this.Title}\n");
			sb.Append($"  imageUrl: {this.ImageUrl}\n");
			sb.Append($"  icon: {this.Icon}\n");
			sb.Append($"  display: {this.Display}\n");
			sb.Append($"  needConfirmationToRead: {this.NeedConfirmationToRead}\n");
			sb.Append($"  silence: {this.Silence}\n");
			sb.Append($"  forYou: {this.ForYou}\n");
			sb.Append($"  isRead: {this.IsRead}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

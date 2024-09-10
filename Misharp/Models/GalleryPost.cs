using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class GalleryPost {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UserId { get; set; }
		public Model.UserLite User { get; set; }
		public string Title { get; set; }
		public string? Description { get; set; }
		public List<string> FileIds { get; set; }
		public List<Model.DriveFile> Files { get; set; }
		public List<string> Tags { get; set; }
		public bool IsSensitive { get; set; }
		public decimal LikedCount { get; set; }
		public bool IsLiked { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GalleryPost: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  updatedAt: {this.UpdatedAt}\n");
			sb.Append($"  userId: {this.UserId}\n");
			var sbUser = new StringBuilder();
			sbUser.Append("  user: [\n");
			if (this.User != null)
			{
				sbUser.Append(this.User);
				sbUser.Replace("\n", "\n    ");
				sbUser.Append("\n");
			}
			sbUser.Append("  ]\n");
			sb.Append(sbUser);
			sb.Append($"  title: {this.Title}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append("  fileIds: [\n");
			if (this.FileIds != null && this.FileIds.Count > 0)
			{
				var sbFileIds = new StringBuilder();
				sbFileIds.Append("    ");
				this.FileIds.ForEach(item => sbFileIds.Append(item).Append(",\n"));
				sbFileIds.Replace("\n", "\n    ");
				sbFileIds.Length -= 4;
				sb.Append(sbFileIds);
			}
			sb.Append("  ]\n");
			sb.Append("  files: [\n");
			if (this.Files != null && this.Files.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.Files.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.Files.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  ]\n");
			sb.Append("  tags: [\n");
			if (this.Tags != null && this.Tags.Count > 0)
			{
				var sbTags = new StringBuilder();
				sbTags.Append("    ");
				this.Tags.ForEach(item => sbTags.Append(item).Append(",\n"));
				sbTags.Replace("\n", "\n    ");
				sbTags.Length -= 4;
				sb.Append(sbTags);
			}
			sb.Append("  ]\n");
			sb.Append($"  isSensitive: {this.IsSensitive}\n");
			sb.Append($"  likedCount: {this.LikedCount}\n");
			sb.Append($"  isLiked: {this.IsLiked}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

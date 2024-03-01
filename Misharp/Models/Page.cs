using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Page {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLite User { get; set; }
		public List<PageBlock> Content { get; set; }
		public List<object> Variables { get; set; }
		public string Title { get; set; }
		public string Name { get; set; }
		public string Summary { get; set; }
		public bool HideTitleWhenPinned { get; set; }
		public bool AlignCenter { get; set; }
		public string Font { get; set; }
		public string Script { get; set; }
		public string EyeCatchingImageId { get; set; }
		public JsonNode EyeCatchingImage { get; set; }
		public List<DriveFile> AttachedFiles { get; set; }
		public decimal LikedCount { get; set; }
		public bool IsLiked { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Page: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  updatedAt: {this.UpdatedAt}\n");
			sb.Append($"  userId: {this.UserId}\n");
			var sbuser = new StringBuilder();
			sbuser.Append("  user: {\n");
			if (this.User != null)
			{
				sbuser.Append(this.User);
				sbuser.Replace("\n", "\n    ");
				sbuser.Append("\n");
			}
			sbuser.Append("  }\n");
			sb.Append(sbuser);
			sb.Append("  content: {\n");
			if (this.Content != null && this.Content.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.Content.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.Content.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  }\n");
			sb.Append("  variables: {\n");
			if (this.Variables != null && this.Variables.Count > 0) this.Variables.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  title: {this.Title}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  summary: {this.Summary}\n");
			sb.Append($"  hideTitleWhenPinned: {this.HideTitleWhenPinned}\n");
			sb.Append($"  alignCenter: {this.AlignCenter}\n");
			sb.Append($"  font: {this.Font}\n");
			sb.Append($"  script: {this.Script}\n");
			sb.Append($"  eyeCatchingImageId: {this.EyeCatchingImageId}\n");
			sb.Append($"  eyeCatchingImage: {this.EyeCatchingImage}\n");
			sb.Append("  attachedFiles: {\n");
			if (this.AttachedFiles != null && this.AttachedFiles.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.AttachedFiles.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.AttachedFiles.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  }\n");
			sb.Append($"  likedCount: {this.LikedCount}\n");
			sb.Append($"  isLiked: {this.IsLiked}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

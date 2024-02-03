using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class Flash {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UserId { get; set; }
		public UserLite User { get; set; }
		public string Title { get; set; }
		public string Summary { get; set; }
		public string Script { get; set; }
		public decimal LikedCount { get; set; }
		public bool IsLiked { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Flash: {\n");
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
			sb.Append($"  title: {this.Title}\n");
			sb.Append($"  summary: {this.Summary}\n");
			sb.Append($"  script: {this.Script}\n");
			sb.Append($"  likedCount: {this.LikedCount}\n");
			sb.Append($"  isLiked: {this.IsLiked}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

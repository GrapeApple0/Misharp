using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class Clip {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime LastClippedAt { get; set; }
		public string UserId { get; set; }
		public UserLite User { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsPublic { get; set; }
		public decimal FavoritedCount { get; set; }
		public bool IsFavorited { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Clip: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  lastClippedAt: {this.LastClippedAt}\n");
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
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append($"  isPublic: {this.IsPublic}\n");
			sb.Append($"  favoritedCount: {this.FavoritedCount}\n");
			sb.Append($"  isFavorited: {this.IsFavorited}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

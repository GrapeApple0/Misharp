using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class UserList {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Name { get; set; }
		public List<string> UserIds { get; set; }
		public bool IsPublic { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserList: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append("  userIds: [\n");
			if (this.UserIds != null && this.UserIds.Count > 0)
			{
				var sbUserIds = new StringBuilder();
				sbUserIds.Append("    ");
				this.UserIds.ForEach(item => sbUserIds.Append(item).Append(",\n"));
				sbUserIds.Replace("\n", "\n    ");
				sbUserIds.Length -= 4;
				sb.Append(sbUserIds);
			}
			sb.Append("  ]\n");
			sb.Append($"  isPublic: {this.IsPublic}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

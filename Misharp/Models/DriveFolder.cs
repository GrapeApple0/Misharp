using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class DriveFolder {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Name { get; set; }
		public string? ParentId { get; set; }
		public decimal FoldersCount { get; set; }
		public decimal FilesCount { get; set; }
		public DriveFolder? Parent { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DriveFolder: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  parentId: {this.ParentId}\n");
			sb.Append($"  foldersCount: {this.FoldersCount}\n");
			sb.Append($"  filesCount: {this.FilesCount}\n");
			var sbParent = new StringBuilder();
			sbParent.Append("  parent: [\n");
			if (this.Parent != null)
			{
				sbParent.Append(this.Parent);
				sbParent.Replace("\n", "\n    ");
				sbParent.Append("\n");
			}
			sbParent.Append("  ]\n");
			sb.Append(sbParent);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

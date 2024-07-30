using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Role {
		public string Id { get; set; }
		public string Name { get; set; }
		public string? Color { get; set; }
		public string? IconUrl { get; set; }
		public string Description { get; set; }
		public bool IsModerator { get; set; }
		public bool IsAdministrator { get; set; }
		public int DisplayOrder { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Role: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  color: {this.Color}\n");
			sb.Append($"  iconUrl: {this.IconUrl}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append($"  isModerator: {this.IsModerator}\n");
			sb.Append($"  isAdministrator: {this.IsAdministrator}\n");
			sb.Append($"  displayOrder: {this.DisplayOrder}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

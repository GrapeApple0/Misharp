using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RoleCondFormulaValueIsLocalOrRemote {
		public string Id { get; set; }
		public string Type { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleCondFormulaValueIsLocalOrRemote: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  type: {this.Type}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RoleCondFormulaValueAssignedRole {
		public string Type { get; set; }
		public string RoleId { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleCondFormulaValueAssignedRole: {\n");
			sb.Append($"  type: {this.Type}\n");
			sb.Append($"  roleId: {this.RoleId}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

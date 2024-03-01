using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RoleCondFormulaValueCreated {
		public string Id { get; set; }
		public string Type { get; set; }
		public decimal Sec { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleCondFormulaValueCreated: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  type: {this.Type}\n");
			sb.Append($"  sec: {this.Sec}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

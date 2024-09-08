using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RoleCondFormulaValueNot {
		public string Id { get; set; }
		public string Type { get; set; }
		public RoleCondFormulaValue Value { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleCondFormulaValueNot: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  type: {this.Type}\n");
			var sbValue = new StringBuilder();
			sbValue.Append("  value: [\n");
			if (this.Value != null)
			{
				sbValue.Append(this.Value);
				sbValue.Replace("\n", "\n    ");
				sbValue.Append("\n");
			}
			sbValue.Append("  ]\n");
			sb.Append(sbValue);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

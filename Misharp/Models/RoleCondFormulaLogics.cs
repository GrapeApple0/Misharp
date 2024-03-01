using System.Text;
namespace Misharp.Model
{
    public class RoleCondFormulaLogics
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public List<RoleCondFormulaValue> Values { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleCondFormulaLogics: {\n");
            sb.Append($"  id: {this.Id}\n");
            sb.Append($"  type: {this.Type}\n");
            sb.Append("  values: {\n");
            if (this.Values != null && this.Values.Count > 0)
            {
                var sb2 = new StringBuilder();
                sb2.Append("    ");
                this.Values.ForEach(item =>
                {
                    sb2.Append(item).Append(",");
                    if (item != this.Values.Last()) sb2.Append("\n");
                });
                sb2.Replace("\n", "\n    ");
                sb2.Append("\n");
                sb.Append(sb2);
            }
            sb.Append("  }\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}

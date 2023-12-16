using System.Text;
namespace Misharp.Model
{
    public class Blocking
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string BlockeeId { get; set; }
        public UserDetailed Blockee { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Blocking: {\n");
            sb.Append($"  id: {this.Id}\n");
            sb.Append($"  createdAt: {this.CreatedAt}\n");
            sb.Append($"  blockeeId: {this.BlockeeId}\n");
            var sbblockee = new StringBuilder();
            sbblockee.Append("  blockee: {\n");
            if (this.Blockee != null)
            {
                sbblockee.Append(this.Blockee);
                sbblockee.Replace("\n", "\n    ");
                sbblockee.Append("\n");
            }
            sbblockee.Append("  }\n");
            sb.Append(sbblockee);
            sb.Append("}");
            return sb.ToString();
        }
    }
}

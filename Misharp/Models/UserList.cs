using System.Text;
namespace Misharp.Model
{
    public class UserList
    {
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
            sb.Append("  userIds: {\n");
            if (this.UserIds != null && this.UserIds.Count > 0) this.UserIds.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
            sb.Append("  }\n");
            sb.Append($"  isPublic: {this.IsPublic}\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}

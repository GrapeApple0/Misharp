using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class Following {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string FolloweeId { get; set; }
		public string FollowerId { get; set; }
		public object Followee { get; set; }
		public object Follower { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Following: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  followeeId: {this.FolloweeId}\n");
			sb.Append($"  followerId: {this.FollowerId}\n");
			sb.Append($"  followee: {this.Followee}\n");
			sb.Append($"  follower: {this.Follower}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

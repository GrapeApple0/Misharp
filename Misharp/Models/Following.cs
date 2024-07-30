using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Following {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public string FolloweeId { get; set; }
		public string FollowerId { get; set; }
		public UserDetailedNotMe Followee { get; set; }
		public UserDetailedNotMe Follower { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Following: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  followeeId: {this.FolloweeId}\n");
			sb.Append($"  followerId: {this.FollowerId}\n");
			var sbFollowee = new StringBuilder();
			sbFollowee.Append("  followee: [\n");
			if (this.Followee != null)
			{
				sbFollowee.Append(this.Followee);
				sbFollowee.Replace("\n", "\n    ");
				sbFollowee.Append("\n");
			}
			sbFollowee.Append("  ]\n");
			sb.Append(sbFollowee);
			var sbFollower = new StringBuilder();
			sbFollower.Append("  follower: [\n");
			if (this.Follower != null)
			{
				sbFollower.Append(this.Follower);
				sbFollower.Replace("\n", "\n    ");
				sbFollower.Append("\n");
			}
			sbFollower.Append("  ]\n");
			sb.Append(sbFollower);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

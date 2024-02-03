using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class FederationInstance {
		public string Id { get; set; }
		public DateTime FirstRetrievedAt { get; set; }
		public string Host { get; set; }
		public decimal UsersCount { get; set; }
		public decimal NotesCount { get; set; }
		public decimal FollowingCount { get; set; }
		public decimal FollowersCount { get; set; }
		public bool IsNotResponding { get; set; }
		public bool IsSuspended { get; set; }
		public bool IsBlocked { get; set; }
		public string SoftwareName { get; set; }
		public string SoftwareVersion { get; set; }
		public bool OpenRegistrations { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string MaintainerName { get; set; }
		public string MaintainerEmail { get; set; }
		public bool IsSilenced { get; set; }
		public string IconUrl { get; set; }
		public string FaviconUrl { get; set; }
		public string ThemeColor { get; set; }
		public DateTime InfoUpdatedAt { get; set; }
		public DateTime LatestRequestReceivedAt { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FederationInstance: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  firstRetrievedAt: {this.FirstRetrievedAt}\n");
			sb.Append($"  host: {this.Host}\n");
			sb.Append($"  usersCount: {this.UsersCount}\n");
			sb.Append($"  notesCount: {this.NotesCount}\n");
			sb.Append($"  followingCount: {this.FollowingCount}\n");
			sb.Append($"  followersCount: {this.FollowersCount}\n");
			sb.Append($"  isNotResponding: {this.IsNotResponding}\n");
			sb.Append($"  isSuspended: {this.IsSuspended}\n");
			sb.Append($"  isBlocked: {this.IsBlocked}\n");
			sb.Append($"  softwareName: {this.SoftwareName}\n");
			sb.Append($"  softwareVersion: {this.SoftwareVersion}\n");
			sb.Append($"  openRegistrations: {this.OpenRegistrations}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append($"  maintainerName: {this.MaintainerName}\n");
			sb.Append($"  maintainerEmail: {this.MaintainerEmail}\n");
			sb.Append($"  isSilenced: {this.IsSilenced}\n");
			sb.Append($"  iconUrl: {this.IconUrl}\n");
			sb.Append($"  faviconUrl: {this.FaviconUrl}\n");
			sb.Append($"  themeColor: {this.ThemeColor}\n");
			sb.Append($"  infoUpdatedAt: {this.InfoUpdatedAt}\n");
			sb.Append($"  latestRequestReceivedAt: {this.LatestRequestReceivedAt}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

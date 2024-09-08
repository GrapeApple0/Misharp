using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class FederationApi {
		private Misharp.App _app;
		public FederationApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Following>>> Followers(string host,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/followers", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<List<Following>>> Following(string host,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/following", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<List<FederationInstance>>> Instances(string? host = null,bool? blocked = null,bool? notResponding = null,bool? suspended = null,bool? silenced = null,bool? federating = null,bool? subscribing = null,bool? publishing = null,int limit = 30,int offset = 0,InstancesSortEnum? sort = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
				{ "blocked", blocked },
				{ "notResponding", notResponding },
				{ "suspended", suspended },
				{ "silenced", silenced },
				{ "federating", federating },
				{ "subscribing", subscribing },
				{ "publishing", publishing },
				{ "limit", limit },
				{ "offset", offset },
				{ "sort", sort },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/instances", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public enum InstancesSortEnum {
			[StringValue("+pubSub")]
			PluspubSub,
			[StringValue("-pubSub")]
			MinuspubSub,
			[StringValue("+notes")]
			Plusnotes,
			[StringValue("-notes")]
			Minusnotes,
			[StringValue("+users")]
			Plususers,
			[StringValue("-users")]
			Minususers,
			[StringValue("+following")]
			Plusfollowing,
			[StringValue("-following")]
			Minusfollowing,
			[StringValue("+followers")]
			Plusfollowers,
			[StringValue("-followers")]
			Minusfollowers,
			[StringValue("+firstRetrievedAt")]
			PlusfirstRetrievedAt,
			[StringValue("-firstRetrievedAt")]
			MinusfirstRetrievedAt,
			[StringValue("+latestRequestReceivedAt")]
			PluslatestRequestReceivedAt,
			[StringValue("-latestRequestReceivedAt")]
			MinuslatestRequestReceivedAt,
		}
		public class ShowInstanceResponse {
			public string Id { get; set; }
			public DateTime FirstRetrievedAt { get; set; }
			public string Host { get; set; }
			public decimal UsersCount { get; set; }
			public decimal NotesCount { get; set; }
			public decimal FollowingCount { get; set; }
			public decimal FollowersCount { get; set; }
			public bool IsNotResponding { get; set; }
			public bool IsSuspended { get; set; }
			public string SuspensionState { get; set; }
			public bool IsBlocked { get; set; }
			public string SoftwareName { get; set; }
			public string SoftwareVersion { get; set; }
			public bool OpenRegistrations { get; set; }
			public string Name { get; set; }
			public string Description { get; set; }
			public string MaintainerName { get; set; }
			public string MaintainerEmail { get; set; }
			public bool IsSilenced { get; set; }
			public bool IsMediaSilenced { get; set; }
			public string IconUrl { get; set; }
			public string FaviconUrl { get; set; }
			public string ThemeColor { get; set; }
			public DateTime InfoUpdatedAt { get; set; }
			public DateTime LatestRequestReceivedAt { get; set; }
			public string ModerationNote { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("{\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  firstRetrievedAt: {this.FirstRetrievedAt}\n");
			sb.Append($"  host: {this.Host}\n");
			sb.Append($"  usersCount: {this.UsersCount}\n");
			sb.Append($"  notesCount: {this.NotesCount}\n");
			sb.Append($"  followingCount: {this.FollowingCount}\n");
			sb.Append($"  followersCount: {this.FollowersCount}\n");
			sb.Append($"  isNotResponding: {this.IsNotResponding}\n");
			sb.Append($"  isSuspended: {this.IsSuspended}\n");
			sb.Append($"  suspensionState: {this.SuspensionState}\n");
			sb.Append($"  isBlocked: {this.IsBlocked}\n");
			sb.Append($"  softwareName: {this.SoftwareName}\n");
			sb.Append($"  softwareVersion: {this.SoftwareVersion}\n");
			sb.Append($"  openRegistrations: {this.OpenRegistrations}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append($"  maintainerName: {this.MaintainerName}\n");
			sb.Append($"  maintainerEmail: {this.MaintainerEmail}\n");
			sb.Append($"  isSilenced: {this.IsSilenced}\n");
			sb.Append($"  isMediaSilenced: {this.IsMediaSilenced}\n");
			sb.Append($"  iconUrl: {this.IconUrl}\n");
			sb.Append($"  faviconUrl: {this.FaviconUrl}\n");
			sb.Append($"  themeColor: {this.ThemeColor}\n");
			sb.Append($"  infoUpdatedAt: {this.InfoUpdatedAt}\n");
			sb.Append($"  latestRequestReceivedAt: {this.LatestRequestReceivedAt}\n");
			sb.Append($"  moderationNote: {this.ModerationNote}\n");
			sb.Append("}");
			return sb.ToString();
		}
		}
		public async Task<Response<ShowInstanceResponse>> ShowInstance(string host)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/show-instance", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> UpdateRemoteUser(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/update-remote-user", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<List<UserDetailedNotMe>>> Users(string host,string? sinceId = null,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/users", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public class StatsResponse {
			public List<FederationInstance> TopSubInstances { get; set; }
			public decimal OtherFollowersCount { get; set; }
			public List<FederationInstance> TopPubInstances { get; set; }
			public decimal OtherFollowingCount { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("{\n");
			sb.Append("  topSubInstances: [\n");
			if (this.TopSubInstances != null && this.TopSubInstances.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.TopSubInstances.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.TopSubInstances.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  ]\n");
			sb.Append($"  otherFollowersCount: {this.OtherFollowersCount}\n");
			sb.Append("  topPubInstances: [\n");
			if (this.TopPubInstances != null && this.TopPubInstances.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.TopPubInstances.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.TopPubInstances.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  ]\n");
			sb.Append($"  otherFollowingCount: {this.OtherFollowingCount}\n");
			sb.Append("}");
			return sb.ToString();
		}
		}
		public async Task<Response<StatsResponse>> Stats(int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/stats", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
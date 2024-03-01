using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class FederationApi {
		private Misharp.App _app;
		public FederationApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.Following>>> Followers(string host,string sinceId,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			Response<List<Model.Following>> result = await _app.Request<List<Model.Following>>("federation/followers", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Following>>> Following(string host,string sinceId,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			Response<List<Model.Following>> result = await _app.Request<List<Model.Following>>("federation/following", param, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.FederationInstance>>> Instances(string? host = null,bool? blocked = null,bool? notResponding = null,bool? suspended = null,bool? silenced = null,bool? federating = null,bool? subscribing = null,bool? publishing = null,int limit = 30,int offset = 0,InstancesSortEnum? sort = null)
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
			Response<List<Model.FederationInstance>> result = await _app.Request<List<Model.FederationInstance>>("federation/instances", param, useToken: false);
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
		public async Task<Response<Model.EmptyResponse>> Updateremoteuser(string userId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "userId", userId },
			};
			var result = await _app.Request<Model.EmptyResponse>("federation/update-remote-user", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.UserDetailedNotMe>>> Users(string host,string sinceId,string? untilId = null,int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "host", host },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			Response<List<Model.UserDetailedNotMe>> result = await _app.Request<List<Model.UserDetailedNotMe>>("federation/users", param, useToken: false);
			return result;
		}
		public class FederationStatsResponse {
			public List<Model.FederationInstance> TopSubInstances { get; set; }
			public decimal OtherFollowersCount { get; set; }
			public List<Model.FederationInstance> TopPubInstances { get; set; }
			public decimal OtherFollowingCount { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append("  topSubInstances: {\n");
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
				sb.Append("  }\n");
				sb.Append($"  otherFollowersCount: {this.OtherFollowersCount}\n");
				sb.Append("  topPubInstances: {\n");
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
				sb.Append("  }\n");
				sb.Append($"  otherFollowingCount: {this.OtherFollowingCount}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<FederationStatsResponse>> Stats(int limit = 10)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
			};
			Response<FederationStatsResponse> result = await _app.Request<FederationStatsResponse>("federation/stats", param, useToken: false);
			return result;
		}
	}
}
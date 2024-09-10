using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class HashtagsApi {
		private Misharp.App _app;
		public HashtagsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.Hashtag>>> List(ListSortEnum sort,int limit = 10,bool attachedToUserOnly = false,bool attachedToLocalUserOnly = false,bool attachedToRemoteUserOnly = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "attachedToUserOnly", attachedToUserOnly },
				{ "attachedToLocalUserOnly", attachedToLocalUserOnly },
				{ "attachedToRemoteUserOnly", attachedToRemoteUserOnly },
				{ "sort", sort },
			};
			var result = await _app.Request<List<Model.Hashtag>>("hashtags/list", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public enum ListSortEnum {
			[StringValue("+mentionedUsers")]
			PlusmentionedUsers,
			[StringValue("-mentionedUsers")]
			MinusmentionedUsers,
			[StringValue("+mentionedLocalUsers")]
			PlusmentionedLocalUsers,
			[StringValue("-mentionedLocalUsers")]
			MinusmentionedLocalUsers,
			[StringValue("+mentionedRemoteUsers")]
			PlusmentionedRemoteUsers,
			[StringValue("-mentionedRemoteUsers")]
			MinusmentionedRemoteUsers,
			[StringValue("+attachedUsers")]
			PlusattachedUsers,
			[StringValue("-attachedUsers")]
			MinusattachedUsers,
			[StringValue("+attachedLocalUsers")]
			PlusattachedLocalUsers,
			[StringValue("-attachedLocalUsers")]
			MinusattachedLocalUsers,
			[StringValue("+attachedRemoteUsers")]
			PlusattachedRemoteUsers,
			[StringValue("-attachedRemoteUsers")]
			MinusattachedRemoteUsers,
		}
		public async Task<Response<List<string>>> Search(string query,int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "query", query },
				{ "offset", offset },
			};
			var result = await _app.Request<List<string>>("hashtags/search", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<Model.Hashtag>> Show(string tag)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "tag", tag },
			};
			var result = await _app.Request<Model.Hashtag>("hashtags/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public class TrendItemResponseObject {
			public string Tag { get; set; }
			public List<number> Chart { get; set; }
			public decimal UsersCount { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class TrendItemResponseObject: {\n");
					sb.Append($"  tag: {this.Tag}\n");
					sb.Append("  chart: [\n");
					if (this.Chart != null && this.Chart.Count > 0)
					{
						var sbChart = new StringBuilder();
						sbChart.Append("    ");
						this.Chart.ForEach(item => sbChart.Append(item).Append(",\n"));
						sbChart.Replace("\n", "\n    ");
						sbChart.Length -= 4;
						sb.Append(sbChart);
					}
					sb.Append("  ]\n");
					sb.Append($"  usersCount: {this.UsersCount}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public async Task<Response<List<TrendItemResponseObject>>> Trend()
		{
			var result = await _app.Request<List<TrendItemResponseObject>>("hashtags/trend", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.UserDetailed>>> Users(string tag,UsersSortEnum sort,int limit = 10,UsersStateEnum state = UsersStateEnum.All,UsersOriginEnum origin = UsersOriginEnum.Local)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "tag", tag },
				{ "limit", limit },
				{ "sort", sort },
				{ "state", state },
				{ "origin", origin },
			};
			var result = await _app.Request<List<Model.UserDetailed>>("hashtags/users", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public enum UsersSortEnum {
			[StringValue("+follower")]
			Plusfollower,
			[StringValue("-follower")]
			Minusfollower,
			[StringValue("+createdAt")]
			PluscreatedAt,
			[StringValue("-createdAt")]
			MinuscreatedAt,
			[StringValue("+updatedAt")]
			PlusupdatedAt,
			[StringValue("-updatedAt")]
			MinusupdatedAt,
		}
		public enum UsersStateEnum {
			[StringValue("all")]
			All,
			[StringValue("alive")]
			Alive,
		}
		public enum UsersOriginEnum {
			[StringValue("combined")]
			Combined,
			[StringValue("local")]
			Local,
			[StringValue("remote")]
			Remote,
		}
	}
}
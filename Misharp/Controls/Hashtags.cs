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
			Response<List<Model.Hashtag>> result = await _app.Request<List<Model.Hashtag>>("hashtags/list", param, useToken: false);
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
			Response<List<string>> result = await _app.Request<List<string>>("hashtags/search", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.Hashtag>> Show(string tag)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "tag", tag },
			};
			Response<Model.Hashtag> result = await _app.Request<Model.Hashtag>("hashtags/show", param, useToken: false);
			return result;
		}
		public async Task<Response<List<object>>> Trend()
		{
			Response<List<object>> result = await _app.Request<List<object>>("hashtags/trend", useToken: false);
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
			Response<List<Model.UserDetailed>> result = await _app.Request<List<Model.UserDetailed>>("hashtags/users", param, useToken: false);
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
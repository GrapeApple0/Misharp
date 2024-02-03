using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class HashtagsApi {
		private Misharp.App _app;
		public HashtagsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<Hashtag>>> List(ListSortEnum sort,int limit = 10,bool attachedToUserOnly = false,bool attachedToLocalUserOnly = false,bool attachedToRemoteUserOnly = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "attachedToUserOnly", attachedToUserOnly },
				{ "attachedToLocalUserOnly", attachedToLocalUserOnly },
				{ "attachedToRemoteUserOnly", attachedToRemoteUserOnly },
				{ "sort", sort },
			};
			var result = await _app.Request<List<Hashtag>>("hashtags/list", param, useToken: false);
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
		public async Task<Models.Response<List<string>>> Search(string query,int limit = 10,int offset = 0)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "query", query },
				{ "offset", offset },
			};
			var result = await _app.Request<List<string>>("hashtags/search", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Hashtag>> Show(string tag)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "tag", tag },
			};
			var result = await _app.Request<Hashtag>("hashtags/show", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<object>>> Trend()
		{
			var result = await _app.Request<List<object>>("hashtags/trend", useToken: false);
			return result;
		}
		public async Task<Models.Response<List<UserDetailed>>> Users(string tag,UsersSortEnum sort,int limit = 10,UsersStateEnum state = UsersStateEnum.All,UsersOriginEnum origin = UsersOriginEnum.Local)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "tag", tag },
				{ "limit", limit },
				{ "sort", sort },
				{ "state", state },
				{ "origin", origin },
			};
			var result = await _app.Request<List<UserDetailed>>("hashtags/users", param, useToken: false);
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
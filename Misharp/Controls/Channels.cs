using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class ChannelsApi {
		private Misharp.App _app;
		public ChannelsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<Channel>> Create(string name,string color,string? description = null,string? bannerId = null,bool? isSensitive = null,bool? allowRenoteToExternal = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "name", name },
				{ "description", description },
				{ "bannerId", bannerId },
				{ "color", color },
				{ "isSensitive", isSensitive },
				{ "allowRenoteToExternal", allowRenoteToExternal },
			};
			var result = await _app.Request<Channel>("channels/create", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Channel>>> Featured()
		{
			var result = await _app.Request<List<Channel>>("channels/featured", useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Follow(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Models.EmptyResponse>("channels/follow", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Channel>>> Followed(string sinceId,string untilId,int limit = 5)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Channel>>("channels/followed", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Channel>>> Owned(string sinceId,string untilId,int limit = 5)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Channel>>("channels/owned", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Channel>> Show(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Channel>("channels/show", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<List<Note>>> Timeline(string channelId,string sinceId,string untilId,int sinceDate,int untilDate,int limit = 10,bool allowPartial = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "sinceDate", sinceDate },
				{ "untilDate", untilDate },
				{ "allowPartial", allowPartial },
			};
			var result = await _app.Request<List<Note>>("channels/timeline", param, useToken: false);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Unfollow(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Models.EmptyResponse>("channels/unfollow", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Channel>> Update(string channelId,string name,string color,string? description = null,string? bannerId = null,bool? isArchived = null,List<string>? pinnedNoteIds = null,bool? isSensitive = null,bool? allowRenoteToExternal = null)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
				{ "name", name },
				{ "description", description },
				{ "bannerId", bannerId },
				{ "isArchived", isArchived },
				{ "pinnedNoteIds", pinnedNoteIds },
				{ "color", color },
				{ "isSensitive", isSensitive },
				{ "allowRenoteToExternal", allowRenoteToExternal },
			};
			var result = await _app.Request<Channel>("channels/update", param, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Favorite(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Models.EmptyResponse>("channels/favorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<Models.EmptyResponse>> Unfavorite(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Models.EmptyResponse>("channels/unfavorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Channel>>> Myfavorites()
		{
			var result = await _app.Request<List<Channel>>("channels/my-favorites", useToken: true);
			return result;
		}
		public async Task<Models.Response<List<Channel>>> Search(string query,string sinceId,string untilId,SearchTypeEnum type = SearchTypeEnum.NameAndDescription,int limit = 5)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "query", query },
				{ "type", type },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Channel>>("channels/search", param, useToken: false);
			return result;
		}
		public enum SearchTypeEnum {
			[StringValue("nameAndDescription")]
			NameAndDescription,
			[StringValue("nameOnly")]
			NameOnly,
		}
	}
}
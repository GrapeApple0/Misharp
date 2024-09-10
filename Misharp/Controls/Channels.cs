using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class ChannelsApi {
		private Misharp.App _app;
		public ChannelsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<Model.Channel>> Create(string name,string color,string? description = null,string? bannerId = null,bool? isSensitive = null,bool? allowRenoteToExternal = null)
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
			var result = await _app.Request<Model.Channel>("channels/create", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Channel>>> Featured()
		{
			var result = await _app.Request<List<Model.Channel>>("channels/featured", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Follow(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Model.EmptyResponse>("channels/follow", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Channel>>> Followed(string? sinceId = null,string? untilId = null,int limit = 5)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Model.Channel>>("channels/followed", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Channel>>> Owned(string? sinceId = null,string? untilId = null,int limit = 5)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Model.Channel>>("channels/owned", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.Channel>> Show(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Model.Channel>("channels/show", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<List<Model.Note>>> Timeline(string channelId,int limit = 10,string? sinceId = null,string? untilId = null,int? sinceDate = null,int? untilDate = null,bool allowPartial = false)
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
			var result = await _app.Request<List<Model.Note>>("channels/timeline", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unfollow(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Model.EmptyResponse>("channels/unfollow", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.Channel>> Update(string channelId,string name,string color,string? description = null,string? bannerId = null,bool? isArchived = null,List<string>? pinnedNoteIds = null,bool? isSensitive = null,bool? allowRenoteToExternal = null)
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
			var result = await _app.Request<Model.Channel>("channels/update", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Favorite(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Model.EmptyResponse>("channels/favorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unfavorite(string channelId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "channelId", channelId },
			};
			var result = await _app.Request<Model.EmptyResponse>("channels/unfavorite", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Channel>>> MyFavorites()
		{
			var result = await _app.Request<List<Model.Channel>>("channels/my-favorites", successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<List<Model.Channel>>> Search(string query,SearchTypeEnum type = SearchTypeEnum.NameAndDescription,string? sinceId = null,string? untilId = null,int limit = 5)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "query", query },
				{ "type", type },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "limit", limit },
			};
			var result = await _app.Request<List<Model.Channel>>("channels/search", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
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
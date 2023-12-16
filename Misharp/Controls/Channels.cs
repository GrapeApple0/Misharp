using Misharp.Model;
namespace Misharp.Controls
{
    public class ChannelsApi
    {
        private Misharp.App _app;
        public ChannelsApi(Misharp.App app)
        {
            _app = app;
        }
        public async Task<Channel> Create(string name, string color, string? description = null, string? bannerId = null, bool? isSensitive = null, bool? allowRenoteToExternal = null)
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
            var result = await _app.Request<Channel>("channels/create", param, true);
            return result;
        }
        public async Task<List<Channel>> Featured()
        {
            var result = await _app.Request<List<Channel>>("channels/featured", false);
            return result;
        }
        public async Task<List<Channel>> Followed(string sinceId, string untilId, int limit = 5)
        {
            var param = new Dictionary<string, object?>
            {
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
            };
            var result = await _app.Request<List<Channel>>("channels/followed", param, true);
            return result;
        }
        public async Task<List<Channel>> Owned(string sinceId, string untilId, int limit = 5)
        {
            var param = new Dictionary<string, object?>
            {
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
            };
            var result = await _app.Request<List<Channel>>("channels/owned", param, true);
            return result;
        }
        public async Task<Channel> Show(string channelId)
        {
            var param = new Dictionary<string, object?>
            {
                { "channelId", channelId },
            };
            var result = await _app.Request<Channel>("channels/show", param, false);
            return result;
        }
        public async Task<List<Note>> Timeline(string channelId, string sinceId, string untilId, int sinceDate, int untilDate, int limit = 10)
        {
            var param = new Dictionary<string, object?>
            {
                { "channelId", channelId },
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "sinceDate", sinceDate },
                { "untilDate", untilDate },
            };
            var result = await _app.Request<List<Note>>("channels/timeline", param, false);
            return result;
        }
        public async Task<Channel> Update(string channelId, string name, string color, string? description = null, string? bannerId = null, bool? isArchived = null, List<string>? pinnedNoteIds = null, bool? isSensitive = null, bool? allowRenoteToExternal = null)
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
            var result = await _app.Request<Channel>("channels/update", param, true);
            return result;
        }
        public async Task<List<Channel>> Myfavorites()
        {
            var result = await _app.Request<List<Channel>>("channels/my-favorites", true);
            return result;
        }
        public async Task<List<Channel>> Search(string query, string sinceId, string untilId, TypeEnum type = TypeEnum.NameAndDescription, int limit = 5)
        {
            var param = new Dictionary<string, object?>
            {
                { "query", query },
                { "type", type },
                { "sinceId", sinceId },
                { "untilId", untilId },
                { "limit", limit },
            };
            var result = await _app.Request<List<Channel>>("channels/search", param, false);
            return result;
        }
        public enum TypeEnum
        {
            [StringValue("nameAndDescription")]
            NameAndDescription,
            [StringValue("nameOnly")]
            NameOnly,
        }
    }
}
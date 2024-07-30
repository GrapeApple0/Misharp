using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class AnnouncementsApi {
		private Misharp.App _app;
		public AnnouncementsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Response<List<Model.Announcement>>> Announcements(int limit = 10,string? sinceId = null,string? untilId = null,bool isActive = true)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "limit", limit },
				{ "sinceId", sinceId },
				{ "untilId", untilId },
				{ "isActive", isActive },
			};
			Response<List<Model.Announcement>> result = await _app.Request<List<Model.Announcement>>("announcements", param, useToken: false);
			return result;
		}
		public async Task<Response<Model.Announcement>> Show(string announcementId)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "announcementId", announcementId },
			};
			Response<Model.Announcement> result = await _app.Request<Model.Announcement>("announcements/show", param, useToken: false);
			return result;
		}
	}
}
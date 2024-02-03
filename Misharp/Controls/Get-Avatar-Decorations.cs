using Misharp;
using Misharp.Model;
using System.Text;
namespace Misharp.Controls {
	public class GetAvatarDecorationsApi {
		private Misharp.App _app;
		public GetAvatarDecorationsApi(Misharp.App app)
		{
			_app = app;
		}
		public async Task<Models.Response<List<object>>> Getavatardecorations()
		{
			var result = await _app.Request<List<object>>("get-avatar-decorations", useToken: false);
			return result;
		}
	}
}
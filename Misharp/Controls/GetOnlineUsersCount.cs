using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class GetOnlineUsersCountApi {
		private Misharp.App _app;
		public GetOnlineUsersCountApi(Misharp.App app)
		{
			_app = app;
		}
		public class GetOnlineUsersCountResponse {
			public decimal Count { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  count: {this.Count}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<GetOnlineUsersCountResponse>> GetOnlineUsersCount()
		{
			Response<GetOnlineUsersCountResponse> result = await _app.Request<GetOnlineUsersCountResponse>("get-online-users-count", useToken: false);
			return result;
		}
	}
}
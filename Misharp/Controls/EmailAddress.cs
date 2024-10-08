using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class EmailAddressApi {
		private Misharp.App _app;
		public EmailAddressApi(Misharp.App app)
		{
			_app = app;
		}
		public class AvailableResponse {
			public bool Available { get; set; }
			public string Reason { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("{\n");
				sb.Append($"  available: {this.Available}\n");
				sb.Append($"  reason: {this.Reason}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public async Task<Response<AvailableResponse>> Available(string emailAddress)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "emailAddress", emailAddress },
			};
			var result = await _app.Request<AvailableResponse>("email-address/available", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
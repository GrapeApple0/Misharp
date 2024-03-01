using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;namespace Misharp.Controls {
	public class EmailAddressApi {
		private Misharp.App _app;
		public EmailAddressApi(Misharp.App app)
		{
			_app = app;
		}
		public class EmailaddressAvailableResponse {
			public bool Available { get; set; }
			public string? Reason { get; set; }
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
		public async Task<Response<EmailaddressAvailableResponse>> Available(string emailAddress)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "emailAddress", emailAddress },
			};
			Response<EmailaddressAvailableResponse> result = await _app.Request<EmailaddressAvailableResponse>("email-address/available", param, useToken: false);
			return result;
		}
	}
}
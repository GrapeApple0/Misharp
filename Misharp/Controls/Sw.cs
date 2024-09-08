using Misharp;
using Misharp.Model;
using System.Text;
using System.Text.Json.Nodes;
namespace Misharp.Controls {
	public class SwApi {
		private Misharp.App _app;
		public SwApi(Misharp.App app)
		{
			_app = app;
		}
		public class ShowRegistrationResponse {
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("{\n");
			sb.Append($"  userId: {this.UserId}\n");
			sb.Append($"  endpoint: {this.Endpoint}\n");
			sb.Append($"  sendReadMessage: {this.SendReadMessage}\n");
			sb.Append("}");
			return sb.ToString();
		}
		}
		public async Task<Response<ShowRegistrationResponse>> ShowRegistration(string endpoint)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<Model.EmptyResponse>("sw/show-registration", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class UpdateRegistrationResponse {
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("{\n");
			sb.Append($"  userId: {this.UserId}\n");
			sb.Append($"  endpoint: {this.Endpoint}\n");
			sb.Append($"  sendReadMessage: {this.SendReadMessage}\n");
			sb.Append("}");
			return sb.ToString();
		}
		}
		public async Task<Response<UpdateRegistrationResponse>> UpdateRegistration(string endpoint,bool sendReadMessage)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "endpoint", endpoint },
				{ "sendReadMessage", sendReadMessage },
			};
			var result = await _app.Request<Model.EmptyResponse>("sw/update-registration", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public class RegisterResponse {
			public string State { get; set; }
			public string Key { get; set; }
			public string UserId { get; set; }
			public string Endpoint { get; set; }
			public bool SendReadMessage { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("{\n");
			sb.Append($"  state: {this.State}\n");
			sb.Append($"  key: {this.Key}\n");
			sb.Append($"  userId: {this.UserId}\n");
			sb.Append($"  endpoint: {this.Endpoint}\n");
			sb.Append($"  sendReadMessage: {this.SendReadMessage}\n");
			sb.Append("}");
			return sb.ToString();
		}
		}
		public async Task<Response<RegisterResponse>> Register(string endpoint,string auth,string publickey,bool sendReadMessage = false)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "endpoint", endpoint },
				{ "auth", auth },
				{ "publickey", publickey },
				{ "sendReadMessage", sendReadMessage },
			};
			var result = await _app.Request<Model.EmptyResponse>("sw/register", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: true);
			return result;
		}
		public async Task<Response<Model.EmptyResponse>> Unregister(string endpoint)
		{
			var param = new Dictionary<string, object?>	
			{
				{ "endpoint", endpoint },
			};
			var result = await _app.Request<Model.EmptyResponse>("sw/unregister", param, successStatusCode: System.Net.HttpStatusCode.NoContent, useToken: false);
			return result;
		}
	}
}
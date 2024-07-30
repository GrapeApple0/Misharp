using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class MetaDetailedOnly {
		public class MetaDetailedOnlyFeaturesObject {
			public bool Registration { get; set; }
			public bool EmailRequiredForSignup { get; set; }
			public bool LocalTimeline { get; set; }
			public bool GlobalTimeline { get; set; }
			public bool Hcaptcha { get; set; }
			public bool Turnstile { get; set; }
			public bool Recaptcha { get; set; }
			public bool ObjectStorage { get; set; }
			public bool ServiceWorker { get; set; }
			public bool Miauth { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MetaDetailedOnlyFeaturesObject: {\n");
				sb.Append($"  registration: {this.Registration}\n");
				sb.Append($"  emailRequiredForSignup: {this.EmailRequiredForSignup}\n");
				sb.Append($"  localTimeline: {this.LocalTimeline}\n");
				sb.Append($"  globalTimeline: {this.GlobalTimeline}\n");
				sb.Append($"  hcaptcha: {this.Hcaptcha}\n");
				sb.Append($"  turnstile: {this.Turnstile}\n");
				sb.Append($"  recaptcha: {this.Recaptcha}\n");
				sb.Append($"  objectStorage: {this.ObjectStorage}\n");
				sb.Append($"  serviceWorker: {this.ServiceWorker}\n");
				sb.Append($"  miauth: {this.Miauth}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public MetaDetailedOnlyFeaturesObject Features { get; set; }
		public string? ProxyAccountName { get; set; }
		public bool RequireSetup { get; set; }
		public bool CacheRemoteFiles { get; set; }
		public bool CacheRemoteSensitiveFiles { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetaDetailedOnly: {\n");
			var sbFeatures = new StringBuilder();
			sbFeatures.Append("  features: [\n");
			if (this.Features != null)
			{
				sbFeatures.Append(this.Features);
				sbFeatures.Replace("\n", "\n    ");
				sbFeatures.Append("\n");
			}
			sbFeatures.Append("  ]\n");
			sb.Append(sbFeatures);
			sb.Append($"  proxyAccountName: {this.ProxyAccountName}\n");
			sb.Append($"  requireSetup: {this.RequireSetup}\n");
			sb.Append($"  cacheRemoteFiles: {this.CacheRemoteFiles}\n");
			sb.Append($"  cacheRemoteSensitiveFiles: {this.CacheRemoteSensitiveFiles}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

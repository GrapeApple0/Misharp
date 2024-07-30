using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class MetaDetailed {
		public string? MaintainerName { get; set; }
		public string? MaintainerEmail { get; set; }
		public string Version { get; set; }
		public bool ProvidesTarball { get; set; }
		public string? Name { get; set; }
		public string? ShortName { get; set; }
		public string Uri { get; set; }
		public string? Description { get; set; }
		public List<string> Langs { get; set; }
		public string? TosUrl { get; set; }
		public string? RepositoryUrl { get; set; }
		public string? FeedbackUrl { get; set; }
		public string? DefaultDarkTheme { get; set; }
		public string? DefaultLightTheme { get; set; }
		public bool DisableRegistration { get; set; }
		public bool EmailRequiredForSignup { get; set; }
		public bool EnableHcaptcha { get; set; }
		public string? HcaptchaSiteKey { get; set; }
		public bool EnableMcaptcha { get; set; }
		public string? McaptchaSiteKey { get; set; }
		public string? McaptchaInstanceUrl { get; set; }
		public bool EnableRecaptcha { get; set; }
		public string? RecaptchaSiteKey { get; set; }
		public bool EnableTurnstile { get; set; }
		public string? TurnstileSiteKey { get; set; }
		public string? SwPublickey { get; set; }
		public string MascotImageUrl { get; set; }
		public string? BannerUrl { get; set; }
		public string? ServerErrorImageUrl { get; set; }
		public string? InfoImageUrl { get; set; }
		public string? NotFoundImageUrl { get; set; }
		public string? IconUrl { get; set; }
		public decimal MaxNoteTextLength { get; set; }
		public class MetaDetailedAdsPropertyType {
			public string Id { get; set; }
			public string Url { get; set; }
			public string Place { get; set; }
			public decimal Ratio { get; set; }
			public string ImageUrl { get; set; }
			public int DayOfWeek { get; set; }
			public override string ToString()
			{
				var sb = new StringBuilder();
				sb.Append("class MetaDetailedAdsPropertyType: {\n");
				sb.Append($"  id: {this.Id}\n");
				sb.Append($"  url: {this.Url}\n");
				sb.Append($"  place: {this.Place}\n");
				sb.Append($"  ratio: {this.Ratio}\n");
				sb.Append($"  imageUrl: {this.ImageUrl}\n");
				sb.Append($"  dayOfWeek: {this.DayOfWeek}\n");
				sb.Append("}");
				return sb.ToString();
			}
		}
		public List<MetaDetailedAdsPropertyType> Ads { get; set; }
		public decimal NotesPerOneAd { get; set; }
		public bool EnableEmail { get; set; }
		public bool EnableServiceWorker { get; set; }
		public bool TranslatorAvailable { get; set; }
		public string MediaProxy { get; set; }
		public bool EnableUrlPreview { get; set; }
		public string? BackgroundImageUrl { get; set; }
		public string? ImpressumUrl { get; set; }
		public string? LogoImageUrl { get; set; }
		public string? PrivacyPolicyUrl { get; set; }
		public string? InquiryUrl { get; set; }
		public List<string> ServerRules { get; set; }
		public string? ThemeColor { get; set; }
		public RolePolicies Policies { get; set; }
		public class MetaDetailedFeaturesObject {
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
				sb.Append("class MetaDetailedFeaturesObject: {\n");
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
		public MetaDetailedFeaturesObject Features { get; set; }
		public string? ProxyAccountName { get; set; }
		public bool RequireSetup { get; set; }
		public bool CacheRemoteFiles { get; set; }
		public bool CacheRemoteSensitiveFiles { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetaDetailed: {\n");
			sb.Append($"  maintainerName: {this.MaintainerName}\n");
			sb.Append($"  maintainerEmail: {this.MaintainerEmail}\n");
			sb.Append($"  version: {this.Version}\n");
			sb.Append($"  providesTarball: {this.ProvidesTarball}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  shortName: {this.ShortName}\n");
			sb.Append($"  uri: {this.Uri}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append("  langs: [\n");
			if (this.Langs != null && this.Langs.Count > 0)
			{
				var sbLangs = new StringBuilder();
				sbLangs.Append("    ");
				this.Langs.ForEach(item => sbLangs.Append(item).Append(",\n"));
				sbLangs.Replace("\n", "\n    ");
				sbLangs.Length -= 4;
				sb.Append(sbLangs);
			}
			sb.Append("  ]\n");
			sb.Append($"  tosUrl: {this.TosUrl}\n");
			sb.Append($"  repositoryUrl: {this.RepositoryUrl}\n");
			sb.Append($"  feedbackUrl: {this.FeedbackUrl}\n");
			sb.Append($"  defaultDarkTheme: {this.DefaultDarkTheme}\n");
			sb.Append($"  defaultLightTheme: {this.DefaultLightTheme}\n");
			sb.Append($"  disableRegistration: {this.DisableRegistration}\n");
			sb.Append($"  emailRequiredForSignup: {this.EmailRequiredForSignup}\n");
			sb.Append($"  enableHcaptcha: {this.EnableHcaptcha}\n");
			sb.Append($"  hcaptchaSiteKey: {this.HcaptchaSiteKey}\n");
			sb.Append($"  enableMcaptcha: {this.EnableMcaptcha}\n");
			sb.Append($"  mcaptchaSiteKey: {this.McaptchaSiteKey}\n");
			sb.Append($"  mcaptchaInstanceUrl: {this.McaptchaInstanceUrl}\n");
			sb.Append($"  enableRecaptcha: {this.EnableRecaptcha}\n");
			sb.Append($"  recaptchaSiteKey: {this.RecaptchaSiteKey}\n");
			sb.Append($"  enableTurnstile: {this.EnableTurnstile}\n");
			sb.Append($"  turnstileSiteKey: {this.TurnstileSiteKey}\n");
			sb.Append($"  swPublickey: {this.SwPublickey}\n");
			sb.Append($"  mascotImageUrl: {this.MascotImageUrl}\n");
			sb.Append($"  bannerUrl: {this.BannerUrl}\n");
			sb.Append($"  serverErrorImageUrl: {this.ServerErrorImageUrl}\n");
			sb.Append($"  infoImageUrl: {this.InfoImageUrl}\n");
			sb.Append($"  notFoundImageUrl: {this.NotFoundImageUrl}\n");
			sb.Append($"  iconUrl: {this.IconUrl}\n");
			sb.Append($"  maxNoteTextLength: {this.MaxNoteTextLength}\n");
			sb.Append("  ads: [\n");
			if (this.Ads != null && this.Ads.Count > 0)
			{
				var sbAds = new StringBuilder();
				sbAds.Append("    ");
				this.Ads.ForEach(item => sbAds.Append(item).Append(",\n"));
				sbAds.Replace("\n", "\n    ");
				sbAds.Length -= 4;
				sb.Append(sbAds);
			}
			sb.Append("  ]\n");
			sb.Append($"  notesPerOneAd: {this.NotesPerOneAd}\n");
			sb.Append($"  enableEmail: {this.EnableEmail}\n");
			sb.Append($"  enableServiceWorker: {this.EnableServiceWorker}\n");
			sb.Append($"  translatorAvailable: {this.TranslatorAvailable}\n");
			sb.Append($"  mediaProxy: {this.MediaProxy}\n");
			sb.Append($"  enableUrlPreview: {this.EnableUrlPreview}\n");
			sb.Append($"  backgroundImageUrl: {this.BackgroundImageUrl}\n");
			sb.Append($"  impressumUrl: {this.ImpressumUrl}\n");
			sb.Append($"  logoImageUrl: {this.LogoImageUrl}\n");
			sb.Append($"  privacyPolicyUrl: {this.PrivacyPolicyUrl}\n");
			sb.Append($"  inquiryUrl: {this.InquiryUrl}\n");
			sb.Append("  serverRules: [\n");
			if (this.ServerRules != null && this.ServerRules.Count > 0)
			{
				var sbServerRules = new StringBuilder();
				sbServerRules.Append("    ");
				this.ServerRules.ForEach(item => sbServerRules.Append(item).Append(",\n"));
				sbServerRules.Replace("\n", "\n    ");
				sbServerRules.Length -= 4;
				sb.Append(sbServerRules);
			}
			sb.Append("  ]\n");
			sb.Append($"  themeColor: {this.ThemeColor}\n");
			var sbPolicies = new StringBuilder();
			sbPolicies.Append("  policies: [\n");
			if (this.Policies != null)
			{
				sbPolicies.Append(this.Policies);
				sbPolicies.Replace("\n", "\n    ");
				sbPolicies.Append("\n");
			}
			sbPolicies.Append("  ]\n");
			sb.Append(sbPolicies);
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

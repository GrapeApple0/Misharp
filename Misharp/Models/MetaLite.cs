using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class MetaLite {
		public string MaintainerName { get; set; }
		public string MaintainerEmail { get; set; }
		public string Version { get; set; }
		public bool ProvidesTarball { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string Uri { get; set; }
		public string Description { get; set; }
		public List<string> Langs { get; set; }
		public string TosUrl { get; set; }
		public string RepositoryUrl { get; set; }
		public string FeedbackUrl { get; set; }
		public string DefaultDarkTheme { get; set; }
		public string DefaultLightTheme { get; set; }
		public bool DisableRegistration { get; set; }
		public bool EmailRequiredForSignup { get; set; }
		public bool EnableHcaptcha { get; set; }
		public string HcaptchaSiteKey { get; set; }
		public bool EnableMcaptcha { get; set; }
		public string McaptchaSiteKey { get; set; }
		public string McaptchaInstanceUrl { get; set; }
		public bool EnableRecaptcha { get; set; }
		public string RecaptchaSiteKey { get; set; }
		public bool EnableTurnstile { get; set; }
		public string TurnstileSiteKey { get; set; }
		public string SwPublickey { get; set; }
		public string MascotImageUrl { get; set; }
		public string BannerUrl { get; set; }
		public string ServerErrorImageUrl { get; set; }
		public string InfoImageUrl { get; set; }
		public string NotFoundImageUrl { get; set; }
		public string IconUrl { get; set; }
		public decimal MaxNoteTextLength { get; set; }
		public List<object> Ads { get; set; }
		public decimal NotesPerOneAd { get; set; }
		public bool EnableEmail { get; set; }
		public bool EnableServiceWorker { get; set; }
		public bool TranslatorAvailable { get; set; }
		public string MediaProxy { get; set; }
		public string BackgroundImageUrl { get; set; }
		public string ImpressumUrl { get; set; }
		public string LogoImageUrl { get; set; }
		public string PrivacyPolicyUrl { get; set; }
		public List<string> ServerRules { get; set; }
		public string ThemeColor { get; set; }
		public RolePolicies Policies { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetaLite: {\n");
			sb.Append($"  maintainerName: {this.MaintainerName}\n");
			sb.Append($"  maintainerEmail: {this.MaintainerEmail}\n");
			sb.Append($"  version: {this.Version}\n");
			sb.Append($"  providesTarball: {this.ProvidesTarball}\n");
			sb.Append($"  name: {this.Name}\n");
			sb.Append($"  shortName: {this.ShortName}\n");
			sb.Append($"  uri: {this.Uri}\n");
			sb.Append($"  description: {this.Description}\n");
			sb.Append("  langs: {\n");
			if (this.Langs != null && this.Langs.Count > 0) this.Langs.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
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
			sb.Append("  ads: {\n");
			if (this.Ads != null && this.Ads.Count > 0) this.Ads.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  notesPerOneAd: {this.NotesPerOneAd}\n");
			sb.Append($"  enableEmail: {this.EnableEmail}\n");
			sb.Append($"  enableServiceWorker: {this.EnableServiceWorker}\n");
			sb.Append($"  translatorAvailable: {this.TranslatorAvailable}\n");
			sb.Append($"  mediaProxy: {this.MediaProxy}\n");
			sb.Append($"  backgroundImageUrl: {this.BackgroundImageUrl}\n");
			sb.Append($"  impressumUrl: {this.ImpressumUrl}\n");
			sb.Append($"  logoImageUrl: {this.LogoImageUrl}\n");
			sb.Append($"  privacyPolicyUrl: {this.PrivacyPolicyUrl}\n");
			sb.Append("  serverRules: {\n");
			if (this.ServerRules != null && this.ServerRules.Count > 0) this.ServerRules.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  themeColor: {this.ThemeColor}\n");
			var sbpolicies = new StringBuilder();
			sbpolicies.Append("  policies: {\n");
			if (this.Policies != null)
			{
				sbpolicies.Append(this.Policies);
				sbpolicies.Replace("\n", "\n    ");
				sbpolicies.Append("\n");
			}
			sbpolicies.Append("  }\n");
			sb.Append(sbpolicies);
			sb.Append("}");
			return sb.ToString();
		}
	}
}

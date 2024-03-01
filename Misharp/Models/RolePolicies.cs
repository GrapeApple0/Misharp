using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class RolePolicies {
		public bool GtlAvailable { get; set; }
		public bool LtlAvailable { get; set; }
		public bool CanPublicNote { get; set; }
		public bool CanInvite { get; set; }
		public int InviteLimit { get; set; }
		public int InviteLimitCycle { get; set; }
		public int InviteExpirationTime { get; set; }
		public bool CanManageCustomEmojis { get; set; }
		public bool CanManageAvatarDecorations { get; set; }
		public bool CanSearchNotes { get; set; }
		public bool CanUseTranslator { get; set; }
		public bool CanHideAds { get; set; }
		public int DriveCapacityMb { get; set; }
		public bool AlwaysMarkNsfw { get; set; }
		public int PinLimit { get; set; }
		public int AntennaLimit { get; set; }
		public int WordMuteLimit { get; set; }
		public int WebhookLimit { get; set; }
		public int ClipLimit { get; set; }
		public int NoteEachClipsLimit { get; set; }
		public int UserListLimit { get; set; }
		public int UserEachUserListsLimit { get; set; }
		public int RateLimitFactor { get; set; }
		public int AvatarDecorationLimit { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RolePolicies: {\n");
			sb.Append($"  gtlAvailable: {this.GtlAvailable}\n");
			sb.Append($"  ltlAvailable: {this.LtlAvailable}\n");
			sb.Append($"  canPublicNote: {this.CanPublicNote}\n");
			sb.Append($"  canInvite: {this.CanInvite}\n");
			sb.Append($"  inviteLimit: {this.InviteLimit}\n");
			sb.Append($"  inviteLimitCycle: {this.InviteLimitCycle}\n");
			sb.Append($"  inviteExpirationTime: {this.InviteExpirationTime}\n");
			sb.Append($"  canManageCustomEmojis: {this.CanManageCustomEmojis}\n");
			sb.Append($"  canManageAvatarDecorations: {this.CanManageAvatarDecorations}\n");
			sb.Append($"  canSearchNotes: {this.CanSearchNotes}\n");
			sb.Append($"  canUseTranslator: {this.CanUseTranslator}\n");
			sb.Append($"  canHideAds: {this.CanHideAds}\n");
			sb.Append($"  driveCapacityMb: {this.DriveCapacityMb}\n");
			sb.Append($"  alwaysMarkNsfw: {this.AlwaysMarkNsfw}\n");
			sb.Append($"  pinLimit: {this.PinLimit}\n");
			sb.Append($"  antennaLimit: {this.AntennaLimit}\n");
			sb.Append($"  wordMuteLimit: {this.WordMuteLimit}\n");
			sb.Append($"  webhookLimit: {this.WebhookLimit}\n");
			sb.Append($"  clipLimit: {this.ClipLimit}\n");
			sb.Append($"  noteEachClipsLimit: {this.NoteEachClipsLimit}\n");
			sb.Append($"  userListLimit: {this.UserListLimit}\n");
			sb.Append($"  userEachUserListsLimit: {this.UserEachUserListsLimit}\n");
			sb.Append($"  rateLimitFactor: {this.RateLimitFactor}\n");
			sb.Append($"  avatarDecorationLimit: {this.AvatarDecorationLimit}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

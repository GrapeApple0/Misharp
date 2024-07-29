using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Note {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime DeletedAt { get; set; }
		public string Text { get; set; }
		public string Cw { get; set; }
		public string UserId { get; set; }
		public UserLite User { get; set; }
		public string ReplyId { get; set; }
		public string RenoteId { get; set; }
		public Note Reply { get; set; }
		public Note Renote { get; set; }
		public bool IsHidden { get; set; }
		public string Visibility { get; set; }
		public List<string> Mentions { get; set; }
		public List<string> VisibleUserIds { get; set; }
		public List<string> FileIds { get; set; }
		public List<object> Files { get; set; }
		public List<string> Tags { get; set; }
		public class NotePollObject {
			public DateTime ExpiresAt { get; set; }
			public bool Multiple { get; set; }
			public List<object> Choices { get; set; }
		}
		public NotePollObject Poll { get; set; }
		public JsonNode Emojis { get; set; }
		public string ChannelId { get; set; }
		public class NoteChannelObject {
			public string Id { get; set; }
			public string Name { get; set; }
			public string Color { get; set; }
			public bool IsSensitive { get; set; }
			public bool AllowRenoteToExternal { get; set; }
			public string UserId { get; set; }
		}
		public NoteChannelObject Channel { get; set; }
		public bool LocalOnly { get; set; }
		public string ReactionAcceptance { get; set; }
		public JsonNode ReactionEmojis { get; set; }
		public JsonNode Reactions { get; set; }
		public decimal ReactionCount { get; set; }
		public decimal RenoteCount { get; set; }
		public decimal RepliesCount { get; set; }
		public string Uri { get; set; }
		public string Url { get; set; }
		public List<string> ReactionAndUserPairCache { get; set; }
		public decimal ClippedCount { get; set; }
		public string MyReaction { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Note: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  createdAt: {this.CreatedAt}\n");
			sb.Append($"  deletedAt: {this.DeletedAt}\n");
			sb.Append($"  text: {this.Text}\n");
			sb.Append($"  cw: {this.Cw}\n");
			sb.Append($"  userId: {this.UserId}\n");
			var sbuser = new StringBuilder();
			sbuser.Append("  user: {\n");
			if (this.User != null)
			{
				sbuser.Append(this.User);
				sbuser.Replace("\n", "\n    ");
				sbuser.Append("\n");
			}
			sbuser.Append("  }\n");
			sb.Append(sbuser);
			sb.Append($"  replyId: {this.ReplyId}\n");
			sb.Append($"  renoteId: {this.RenoteId}\n");
			sb.Append($"  reply: {this.Reply}\n");
			sb.Append($"  renote: {this.Renote}\n");
			sb.Append($"  isHidden: {this.IsHidden}\n");
			sb.Append($"  visibility: {this.Visibility}\n");
			sb.Append("  mentions: {\n");
			if (this.Mentions != null && this.Mentions.Count > 0) this.Mentions.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  visibleUserIds: {\n");
			if (this.VisibleUserIds != null && this.VisibleUserIds.Count > 0) this.VisibleUserIds.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  fileIds: {\n");
			if (this.FileIds != null && this.FileIds.Count > 0) this.FileIds.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append("  files: {\n");
			if (this.Files != null && this.Files.Count > 0)
			{
				var sb2 = new StringBuilder();
				sb2.Append("    ");
				this.Files.ForEach(item =>
				{
					sb2.Append(item).Append(",");
					if (item != this.Files.Last()) sb2.Append("\n");
				});
				sb2.Replace("\n", "\n    ");
				sb2.Append("\n");
				sb.Append(sb2);
			}
			sb.Append("  }\n");
			sb.Append("  tags: {\n");
			if (this.Tags != null && this.Tags.Count > 0) this.Tags.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  poll: {this.Poll}\n");
			sb.Append($"  emojis: {this.Emojis}\n");
			sb.Append($"  channelId: {this.ChannelId}\n");
			sb.Append($"  channel: {this.Channel}\n");
			sb.Append($"  localOnly: {this.LocalOnly}\n");
			sb.Append($"  reactionAcceptance: {this.ReactionAcceptance}\n");
			sb.Append($"  reactionEmojis: {this.ReactionEmojis}\n");
			sb.Append($"  reactions: {this.Reactions}\n");
			sb.Append($"  reactionCount: {this.ReactionCount}\n");
			sb.Append($"  renoteCount: {this.RenoteCount}\n");
			sb.Append($"  repliesCount: {this.RepliesCount}\n");
			sb.Append($"  uri: {this.Uri}\n");
			sb.Append($"  url: {this.Url}\n");
			sb.Append("  reactionAndUserPairCache: {\n");
			if (this.ReactionAndUserPairCache != null && this.ReactionAndUserPairCache.Count > 0) this.ReactionAndUserPairCache.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
			sb.Append("  }\n");
			sb.Append($"  clippedCount: {this.ClippedCount}\n");
			sb.Append($"  myReaction: {this.MyReaction}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

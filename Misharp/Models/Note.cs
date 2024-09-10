using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
namespace Misharp.Model {
	public class Note {
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public string? Text { get; set; }
		public string? Cw { get; set; }
		public string UserId { get; set; }
		public Model.UserLite User { get; set; }
		public string? ReplyId { get; set; }
		public string? RenoteId { get; set; }
		public Note? Reply { get; set; }
		public Note? Renote { get; set; }
		public bool IsHidden { get; set; }
		public string Visibility { get; set; }
		public List<string> Mentions { get; set; }
		public List<string> VisibleUserIds { get; set; }
		public List<string> FileIds { get; set; }
		public List<Model.DriveFile> Files { get; set; }
		public List<string> Tags { get; set; }
		public class NotePollObject {
			public DateTime? ExpiresAt { get; set; }
			public bool Multiple { get; set; }
			public class NoteChoicesPropertyType {
				public bool IsVoted { get; set; }
				public string Text { get; set; }
				public decimal Votes { get; set; }
					public override string ToString()
					{
						var sb = new StringBuilder();
						sb.Append("class NoteChoicesPropertyType: {\n");
						sb.Append($"  isVoted: {this.IsVoted}\n");
						sb.Append($"  text: {this.Text}\n");
						sb.Append($"  votes: {this.Votes}\n");
						sb.Append("}");
						return sb.ToString();
					}
			}
			public List<NoteChoicesPropertyType> Choices { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class NotePollObject: {\n");
					sb.Append($"  expiresAt: {this.ExpiresAt}\n");
					sb.Append($"  multiple: {this.Multiple}\n");
					sb.Append("  choices: [\n");
					if (this.Choices != null && this.Choices.Count > 0)
					{
						var sbChoices = new StringBuilder();
						sbChoices.Append("    ");
						this.Choices.ForEach(item => sbChoices.Append(item).Append(",\n"));
						sbChoices.Replace("\n", "\n    ");
						sbChoices.Length -= 4;
						sb.Append(sbChoices);
					}
					sb.Append("  ]\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public NotePollObject? Poll { get; set; }
		public Dictionary<string, string> Emojis { get; set; }
		public string? ChannelId { get; set; }
		public class NoteChannelObject {
			public string Id { get; set; }
			public string Name { get; set; }
			public string Color { get; set; }
			public bool IsSensitive { get; set; }
			public bool AllowRenoteToExternal { get; set; }
			public string? UserId { get; set; }
				public override string ToString()
				{
					var sb = new StringBuilder();
					sb.Append("class NoteChannelObject: {\n");
					sb.Append($"  id: {this.Id}\n");
					sb.Append($"  name: {this.Name}\n");
					sb.Append($"  color: {this.Color}\n");
					sb.Append($"  isSensitive: {this.IsSensitive}\n");
					sb.Append($"  allowRenoteToExternal: {this.AllowRenoteToExternal}\n");
					sb.Append($"  userId: {this.UserId}\n");
					sb.Append("}");
					return sb.ToString();
				}
		}
		public NoteChannelObject? Channel { get; set; }
		public bool LocalOnly { get; set; }
		public string? ReactionAcceptance { get; set; }
		public Dictionary<string, string> ReactionEmojis { get; set; }
		public Dictionary<string, decimal> Reactions { get; set; }
		public decimal ReactionCount { get; set; }
		public decimal RenoteCount { get; set; }
		public decimal RepliesCount { get; set; }
		public string Uri { get; set; }
		public string Url { get; set; }
		public List<string> ReactionAndUserPairCache { get; set; }
		public decimal ClippedCount { get; set; }
		public string? MyReaction { get; set; }
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
			var sbUser = new StringBuilder();
			sbUser.Append("  user: [\n");
			if (this.User != null)
			{
				sbUser.Append(this.User);
				sbUser.Replace("\n", "\n    ");
				sbUser.Append("\n");
			}
			sbUser.Append("  ]\n");
			sb.Append(sbUser);
			sb.Append($"  replyId: {this.ReplyId}\n");
			sb.Append($"  renoteId: {this.RenoteId}\n");
			var sbReply = new StringBuilder();
			sbReply.Append("  reply: [\n");
			if (this.Reply != null)
			{
				sbReply.Append(this.Reply);
				sbReply.Replace("\n", "\n    ");
				sbReply.Append("\n");
			}
			sbReply.Append("  ]\n");
			sb.Append(sbReply);
			var sbRenote = new StringBuilder();
			sbRenote.Append("  renote: [\n");
			if (this.Renote != null)
			{
				sbRenote.Append(this.Renote);
				sbRenote.Replace("\n", "\n    ");
				sbRenote.Append("\n");
			}
			sbRenote.Append("  ]\n");
			sb.Append(sbRenote);
			sb.Append($"  isHidden: {this.IsHidden}\n");
			sb.Append($"  visibility: {this.Visibility}\n");
			sb.Append("  mentions: [\n");
			if (this.Mentions != null && this.Mentions.Count > 0)
			{
				var sbMentions = new StringBuilder();
				sbMentions.Append("    ");
				this.Mentions.ForEach(item => sbMentions.Append(item).Append(",\n"));
				sbMentions.Replace("\n", "\n    ");
				sbMentions.Length -= 4;
				sb.Append(sbMentions);
			}
			sb.Append("  ]\n");
			sb.Append("  visibleUserIds: [\n");
			if (this.VisibleUserIds != null && this.VisibleUserIds.Count > 0)
			{
				var sbVisibleUserIds = new StringBuilder();
				sbVisibleUserIds.Append("    ");
				this.VisibleUserIds.ForEach(item => sbVisibleUserIds.Append(item).Append(",\n"));
				sbVisibleUserIds.Replace("\n", "\n    ");
				sbVisibleUserIds.Length -= 4;
				sb.Append(sbVisibleUserIds);
			}
			sb.Append("  ]\n");
			sb.Append("  fileIds: [\n");
			if (this.FileIds != null && this.FileIds.Count > 0)
			{
				var sbFileIds = new StringBuilder();
				sbFileIds.Append("    ");
				this.FileIds.ForEach(item => sbFileIds.Append(item).Append(",\n"));
				sbFileIds.Replace("\n", "\n    ");
				sbFileIds.Length -= 4;
				sb.Append(sbFileIds);
			}
			sb.Append("  ]\n");
			sb.Append("  files: [\n");
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
			sb.Append("  ]\n");
			sb.Append("  tags: [\n");
			if (this.Tags != null && this.Tags.Count > 0)
			{
				var sbTags = new StringBuilder();
				sbTags.Append("    ");
				this.Tags.ForEach(item => sbTags.Append(item).Append(",\n"));
				sbTags.Replace("\n", "\n    ");
				sbTags.Length -= 4;
				sb.Append(sbTags);
			}
			sb.Append("  ]\n");
			var sbPoll = new StringBuilder();
			sbPoll.Append("  poll: [\n");
			if (this.Poll != null)
			{
				sbPoll.Append(this.Poll);
				sbPoll.Replace("\n", "\n    ");
				sbPoll.Append("\n");
			}
			sbPoll.Append("  ]\n");
			sb.Append(sbPoll);
			var sbEmojis = new StringBuilder();
			sbEmojis.Append("  emojis: [\n");
			if (this.Emojis != null)
			{
				sbEmojis.Append(this.Emojis);
				sbEmojis.Replace("\n", "\n    ");
				sbEmojis.Append("\n");
			}
			sbEmojis.Append("  ]\n");
			sb.Append(sbEmojis);
			sb.Append($"  channelId: {this.ChannelId}\n");
			var sbChannel = new StringBuilder();
			sbChannel.Append("  channel: [\n");
			if (this.Channel != null)
			{
				sbChannel.Append(this.Channel);
				sbChannel.Replace("\n", "\n    ");
				sbChannel.Append("\n");
			}
			sbChannel.Append("  ]\n");
			sb.Append(sbChannel);
			sb.Append($"  localOnly: {this.LocalOnly}\n");
			sb.Append($"  reactionAcceptance: {this.ReactionAcceptance}\n");
			var sbReactionEmojis = new StringBuilder();
			sbReactionEmojis.Append("  reactionEmojis: [\n");
			if (this.ReactionEmojis != null)
			{
				sbReactionEmojis.Append(this.ReactionEmojis);
				sbReactionEmojis.Replace("\n", "\n    ");
				sbReactionEmojis.Append("\n");
			}
			sbReactionEmojis.Append("  ]\n");
			sb.Append(sbReactionEmojis);
			var sbReactions = new StringBuilder();
			sbReactions.Append("  reactions: [\n");
			if (this.Reactions != null)
			{
				sbReactions.Append(this.Reactions);
				sbReactions.Replace("\n", "\n    ");
				sbReactions.Append("\n");
			}
			sbReactions.Append("  ]\n");
			sb.Append(sbReactions);
			sb.Append($"  reactionCount: {this.ReactionCount}\n");
			sb.Append($"  renoteCount: {this.RenoteCount}\n");
			sb.Append($"  repliesCount: {this.RepliesCount}\n");
			sb.Append($"  uri: {this.Uri}\n");
			sb.Append($"  url: {this.Url}\n");
			sb.Append("  reactionAndUserPairCache: [\n");
			if (this.ReactionAndUserPairCache != null && this.ReactionAndUserPairCache.Count > 0)
			{
				var sbReactionAndUserPairCache = new StringBuilder();
				sbReactionAndUserPairCache.Append("    ");
				this.ReactionAndUserPairCache.ForEach(item => sbReactionAndUserPairCache.Append(item).Append(",\n"));
				sbReactionAndUserPairCache.Replace("\n", "\n    ");
				sbReactionAndUserPairCache.Length -= 4;
				sb.Append(sbReactionAndUserPairCache);
			}
			sb.Append("  ]\n");
			sb.Append($"  clippedCount: {this.ClippedCount}\n");
			sb.Append($"  myReaction: {this.MyReaction}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

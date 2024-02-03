using System.Collections.Generic;
using System.Text;
namespace Misharp.Model {
	public class Ad {
		public string Id { get; set; }
		public DateTime ExpiresAt { get; set; }
		public DateTime StartsAt { get; set; }
		public string Place { get; set; }
		public string Priority { get; set; }
		public decimal Ratio { get; set; }
		public string Url { get; set; }
		public string ImageUrl { get; set; }
		public string Memo { get; set; }
		public int DayOfWeek { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Ad: {\n");
			sb.Append($"  id: {this.Id}\n");
			sb.Append($"  expiresAt: {this.ExpiresAt}\n");
			sb.Append($"  startsAt: {this.StartsAt}\n");
			sb.Append($"  place: {this.Place}\n");
			sb.Append($"  priority: {this.Priority}\n");
			sb.Append($"  ratio: {this.Ratio}\n");
			sb.Append($"  url: {this.Url}\n");
			sb.Append($"  imageUrl: {this.ImageUrl}\n");
			sb.Append($"  memo: {this.Memo}\n");
			sb.Append($"  dayOfWeek: {this.DayOfWeek}\n");
			sb.Append("}");
			return sb.ToString();
		}
	}
}

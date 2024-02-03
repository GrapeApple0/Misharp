using System.Collections.Generic;
using System.Text;
namespace Misharp.Model
{
    public class ReversiGameDetailed
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public bool IsStarted { get; set; }
        public bool IsEnded { get; set; }
        public object Form1 { get; set; }
        public object Form2 { get; set; }
        public bool User1Ready { get; set; }
        public bool User2Ready { get; set; }
        public string User1Id { get; set; }
        public string User2Id { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
        public string WinnerId { get; set; }
        public object Winner { get; set; }
        public string SurrenderedUserId { get; set; }
        public string TimeoutUserId { get; set; }
        public decimal Black { get; set; }
        public string Bw { get; set; }
        public bool NoIrregularRules { get; set; }
        public bool IsLlotheo { get; set; }
        public bool CanPutEverywhere { get; set; }
        public bool LoopedBoard { get; set; }
        public decimal TimeLimitForEachTurn { get; set; }
        public List<object> Logs { get; set; }
        public List<string> Map { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReversiGameDetailed: {\n");
            sb.Append($"  id: {this.Id}\n");
            sb.Append($"  createdAt: {this.CreatedAt}\n");
            sb.Append($"  startedAt: {this.StartedAt}\n");
            sb.Append($"  endedAt: {this.EndedAt}\n");
            sb.Append($"  isStarted: {this.IsStarted}\n");
            sb.Append($"  isEnded: {this.IsEnded}\n");
            sb.Append($"  form1: {this.Form1}\n");
            sb.Append($"  form2: {this.Form2}\n");
            sb.Append($"  user1Ready: {this.User1Ready}\n");
            sb.Append($"  user2Ready: {this.User2Ready}\n");
            sb.Append($"  user1Id: {this.User1Id}\n");
            sb.Append($"  user2Id: {this.User2Id}\n");
            var sbuser1 = new StringBuilder();
            sbuser1.Append("  user1: {\n");
            if (this.User1 != null)
            {
                sbuser1.Append(this.User1);
                sbuser1.Replace("\n", "\n    ");
                sbuser1.Append("\n");
            }
            sbuser1.Append("  }\n");
            sb.Append(sbuser1);
            var sbuser2 = new StringBuilder();
            sbuser2.Append("  user2: {\n");
            if (this.User2 != null)
            {
                sbuser2.Append(this.User2);
                sbuser2.Replace("\n", "\n    ");
                sbuser2.Append("\n");
            }
            sbuser2.Append("  }\n");
            sb.Append(sbuser2);
            sb.Append($"  winnerId: {this.WinnerId}\n");
            sb.Append($"  winner: {this.Winner}\n");
            sb.Append($"  surrenderedUserId: {this.SurrenderedUserId}\n");
            sb.Append($"  timeoutUserId: {this.TimeoutUserId}\n");
            sb.Append($"  black: {this.Black}\n");
            sb.Append($"  bw: {this.Bw}\n");
            sb.Append($"  noIrregularRules: {this.NoIrregularRules}\n");
            sb.Append($"  isLlotheo: {this.IsLlotheo}\n");
            sb.Append($"  canPutEverywhere: {this.CanPutEverywhere}\n");
            sb.Append($"  loopedBoard: {this.LoopedBoard}\n");
            sb.Append($"  timeLimitForEachTurn: {this.TimeLimitForEachTurn}\n");
            sb.Append("  logs: {\n");
            if (this.Logs != null && this.Logs.Count > 0) this.Logs.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
            sb.Append("  }\n");
            sb.Append("  map: {\n");
            if (this.Map != null && this.Map.Count > 0) this.Map.ForEach(item => sb.Append("    ").Append(item).Append(",\n"));
            sb.Append("  }\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}
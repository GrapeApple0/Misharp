using System.Text;

namespace Misharp;

public class UniqueList<T> : HashSet<T>
{
    public UniqueList() : base() { }
    public void ForEach(Action<T> action)
    {
        this.ToList().ForEach(action);
    }
}

public class Core
{
    public static string AddIndent(string str)
    {
        var lines = str.Split(new[] { '\n' }, StringSplitOptions.None);
        StringBuilder sb = new StringBuilder();
        foreach (var line in lines)
        {
            sb.Append("    ").Append(line).Append('\n');
        }
        if (sb.Length > 0)
        {
            sb.Length--;
        }
        return sb.ToString();
    }
}
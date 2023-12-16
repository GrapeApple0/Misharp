using Misharp.Controls;

namespace Misharp.cli
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var app = new App("misskey.04.si", "");
            var post = await app.NotesApi.Create(text: "Hello world", visibility: NotesApi.VisibilityEnum.Followers, localOnly: false);
            Console.WriteLine(post.ToString());
        }
    }
}
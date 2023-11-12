namespace Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> list = new List<Article>();

            int commandCount = int.Parse(Console.ReadLine());//the number of commands

            for (int i = 0; i < commandCount; i++)
            {
                string[] strings = Console.ReadLine().Split(", ");//reads an article

                string title = strings[0];
                string content = strings[1];
                string author = strings[2];

                Article article = new Article(title, content, author);//final state of the article.

                list.Add(article);
            }
            Console.WriteLine(string.Join("\n", list));

        }
        class Article
        {
            public Article(string title, string contest, string autor)// constructor
            {
                Title = title;
                Content = contest;
                Author = autor;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }


            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

    }
}
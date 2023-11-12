namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Create a class Article with the following properties:
           • Title – a string
           • Content – a string
           • Author – a string
           The class should have a constructor and the following methods:
           • Edit (new content) – change the old content with the new one
           • ChangeAuthor (new author) – change the author
           • Rename (new title) – change the title of the article
           • Override the ToString method – print the article in the following format:
           "{title} - {content}: {author}"
           Create a program that reads an article in the following format 
           "{title}, {content}, {author}".
           On the next line, you will receive a number n, representing the number of commands,
           which will follow after it. 
           On the next n lines, you will be receiving the following commands:
           • "Edit: {new content}"
           • "ChangeAuthor: {new author}"
           • "Rename: {new title}"
           In the end, print the final state of the article.
           */

            string[] strings = Console.ReadLine().Split(", ");//reads an article
            string title = strings[0];
            string content = strings[1];
            string author = strings[2];

            Article article = new Article(title, content, author);//final state of the article.

            int commandCount = int.Parse(Console.ReadLine());//the number of commands

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Edit")
                {
                    string newContaint = command[1];
                    article.Edit(newContaint);

                }
                else if (command[0] == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command[0] == "Rename")
                {
                    string newTitle = command[1];
                    article.Rename(newTitle);
                }
            }
            Console.WriteLine(article.ToString());

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

            public void Edit(string newContent)
            {
                Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                Title = newTitle;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

    }
}
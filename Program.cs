using POO.ContentContext;
internal class Program
{
    private static object career;

    private static void Main(string[] args)
    {
        var articles = new List<Article>()
        {
            new Article("Test POO", "orientacao-objetos"),
            new Article("Test POO2", "orientacao-objetos2"),
            new Article("Test POO3", "orientacao-objetos3")


        };

        foreach (var article in articles)
        {
            Console.WriteLine(article.Id);
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Url);
        }
        Console.WriteLine("___________________________");

        var courses = new List<Course>();

        var coursesPoo = new Course("fundamentos poo", "fundamentos");
        var coursesPoo2 = new Course("fundamentos poo2", "fundamentos2");
        var coursesPoo3 = new Course("fundamentos poo3", "fundamentos3");


        var careers = new List<Carrer>
        {
            new Carrer ("Especialista .NET", "epecialista-dotnet")
        };

        var careersItem = new List<CarrerItem>
        {
            new CarrerItem  (1, "Comece por aqui", "", coursesPoo),
            new CarrerItem  (3, "Mysql", "", coursesPoo3),
            new CarrerItem  (2, "OOP", "",coursesPoo2 ),
        };

        foreach (var career in careers)
        {
            Console.WriteLine(career.Title);
            foreach (var item in careersItem.OrderBy(x => x.Ordem))
            {
                Console.WriteLine($"{item.Ordem} - {item.Title} ");
                Console.WriteLine($"{item.Course.Title} - {item.Course.Level}");
            }
        }




    }
}

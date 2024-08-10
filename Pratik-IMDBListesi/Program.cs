using Pratik_IMDBListesi;

List<Movies> movie = new List<Movies>();

bool devam = true;
while (devam)
{
    Console.WriteLine("Film İsmi: ");
    string userInput = Console.ReadLine();
    Console.WriteLine("Imdb Puanı: ");
    double userInput2 = Convert.ToDouble(Console.ReadLine());
    if (userInput2 >= 0 && userInput2 <= 9)
    {
        movie.Add(new Movies(userInput, userInput2));
    }
    else
    {
        Console.WriteLine("Yanlis imdb puani girdiniz.");
    }
    Console.WriteLine("Daha fazla film ekleyecek misiniz? (evet/hayir)");
    string answer = Console.ReadLine().Trim().ToLower();
    if(answer == "hayir")
    {
        break;
    }
}
Console.WriteLine("-----------------");
Console.WriteLine("Bütün Filmler ------------>>>");
foreach (var film in movie)
{
    Console.WriteLine(film._movieName +"      "+ film._imdb);
}


Console.WriteLine("IMDB PUANI 4 İLE 9 ARASINDA OLANLAR");
foreach (var film in movie)
{
    if (film._imdb >= 4 && film._imdb <= 9)
    {  
        Console.WriteLine(film._movieName + "      " + film._imdb);
    }
}


Console.WriteLine("İsmi A ile başlayanlar: ");
foreach (var film in movie)
{
    if(film._movieName.StartsWith("A"))
    {
        Console.WriteLine(film._movieName + "      " + film._imdb);
    }
}
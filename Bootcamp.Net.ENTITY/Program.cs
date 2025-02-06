using Bootcamp.Net.ENTITY.Data;
using Bootcamp.Net.ENTITY.Entities;

using (DataContext dc = new DataContext())
{

    IEnumerable<Game> mesJeux = dc.Games;

    

    foreach (Game game in mesJeux)
    {
        Console.WriteLine(game.Title);
        Console.WriteLine(game.Description);
        Console.WriteLine(game.IsNew);
        Console.WriteLine(game.ReleaseDate);
        Console.WriteLine(game.PEGI);
        Console.WriteLine(game.Price);

        Console.WriteLine("----------------");
    }
}
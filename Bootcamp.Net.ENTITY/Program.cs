using Bootcamp.Net.ENTITY.Data;
using Bootcamp.Net.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;


bool continuer = true;

while (continuer)
{
    Console.Clear();
    Console.WriteLine("Veuillez faire un choix : \n" +
                      "1. Voir tous les jeux\n" +
                      "2. Voir un jeu via son Id\n" +
                      "3. Créer un jeu\n" +
                      "4. Mettre à jours un jeu\n" +
                      "5. Supprimer un jeu\n" +
                      "0. Quitter");
    string choix = Console.ReadLine();
    Console.Clear();


    switch (choix)
    {
        case "1":
            using (DataContext dc = new DataContext())
            {

                IEnumerable<Game> mesJeux = dc.Games;

                foreach (Game game in mesJeux)
                {
                    Console.WriteLine($"{game.Id} | {game.Title} | {game.Description} | {game.IsNew} | {game.ReleaseDate} | {game.PEGI} | {game.Price}");

                    Console.WriteLine("----------------");
                }
                Console.ReadLine();
            } break;

        case "2":

            Console.WriteLine("Veuillez entrer l'id du jeu à trouver :");
            int Id = int.Parse(Console.ReadLine());
            using (DataContext dc = new DataContext())
            {

                Game game = dc.Games.SingleOrDefault(g => g.Id == Id);
                if(game is not null)
                {
                    Console.WriteLine($"{game.Id} | {game.Title} | {game.Description} | {game.IsNew} | {game.ReleaseDate} | {game.PEGI} | {game.Price}");
                }
                else
                {
                    Console.WriteLine("Il n'y a pas de jeux avec cette Id");
                }
                Console.ReadLine();

            }
            break;


        case "3":
            using (DataContext dc = new DataContext()) 
            {

                Game game = new Game
                {
                    Title = "Rocket League7",
                    Description = "Du foot avec des voitures",
                    IsNew = true,
                    ReleaseDate = new DateTime(2015, 07, 07),
                    PEGI = 3,
                    Price = 1,

                };

                GameDetails gameDetails = new GameDetails
                {
                    FileSize = 100,
                };


                dc.Add(game);
                dc.SaveChanges();

                dc.Entry(gameDetails).Property("GameId").CurrentValue = game.Id;
                dc.GameDetails.Add(gameDetails);
                dc.SaveChanges();

                if(game.Id > 0)
                {
                    Console.WriteLine($"Le jeu à bien été créé à l'Id : {game.Id} et l'id du détail est {gameDetails.Id} ");
                }
                else
                {
                    Console.WriteLine("Le jeu n'a pas été créé");
                }
                Console.ReadLine ();

            }
            break;

        case "4":
            Console.WriteLine("Veuillez entrer l'id du jeu à modifier :");
            int idJeuAUpdate = int.Parse(Console.ReadLine());
            using (DataContext dc = new DataContext())
            {
                //    Game jeuAUpdate = dc.Games.SingleOrDefault(g => g.Id == idJeuAUpdate);

                //    if(jeuAUpdate is not null)
                //    {
                //        jeuAUpdate.Price = 133;
                //        try
                //        {

                //            dc.SaveChanges();
                //        }
                //        catch (Exception ex) 
                //        {
                //            Console.WriteLine(ex.Message);
                //            Console.ReadLine();
                //        }
                //    }

                Game jeuAUpdate = new Game { Id = 7, Title = "The Legend of Zelda", ReleaseDate = DateTime.Parse("1986-02-21"), Description = "Premier jeu de la série Zelda.", Price = -1, IsNew = false, PEGI = 7 };

                dc.Games.Attach(jeuAUpdate);

                dc.Entry(jeuAUpdate).State = EntityState.Modified;

                try
                {
                    dc.SaveChanges();

                }catch(DbUpdateException ex)
                {

                    Console.WriteLine($"{ex.Message}"); 
                    Console.ReadLine();
                }
           
            }
            break;

        case "5":
            Console.WriteLine("Veuillez entrer l'id du jeu à modifier :");
            int idJeuADelete = int.Parse(Console.ReadLine());
            using (DataContext dc = new DataContext())
            {
                Game jeuADelete = dc.Games.SingleOrDefault(g => g.Id == idJeuADelete);

                if (jeuADelete is not null)
                {
                    dc.Remove(jeuADelete);

                    dc.SaveChanges();
                }
            }
            break;

        case "0":
            continuer = false;
            break;

        default:
            Console.WriteLine("Choix invalide");
            break;
    }
}

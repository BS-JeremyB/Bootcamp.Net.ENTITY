using Bootcamp.Net.ENTITY.Data;
using Bootcamp.Net.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;


//bool continuer = true;

//while (continuer)
//{
//    Console.Clear();
//    Console.WriteLine("Veuillez faire un choix : \n" +
//                      "1. Voir tous les jeux\n" +
//                      "2. Voir un jeu via son Id\n" +
//                      "3. Créer un jeu\n" +
//                      "4. Mettre à jours un jeu\n" +
//                      "5. Supprimer un jeu\n" +
//                      "0. Quitter");
//    string choix = Console.ReadLine();
//    Console.Clear();


//    switch (choix)
//    {
//        case "1":
//            using (DataContext dc = new DataContext())
//            {

//                IEnumerable<Game> mesJeux = dc.Games;

//                foreach (Game game in mesJeux)
//                {
//                    Console.WriteLine($"{game.Id} | {game.Title} | {game.Description} | {game.IsNew} | {game.ReleaseDate} | {game.PEGI} | {game.Price}");

//                    Console.WriteLine("----------------");
//                }
//                Console.ReadLine();
//            } break;

//        case "2":

//            Console.WriteLine("Veuillez entrer l'id du jeu à trouver :");
//            int Id = int.Parse(Console.ReadLine());
//            using (DataContext dc = new DataContext())
//            {

//                Game game = dc.Games.SingleOrDefault(g => g.Id == Id);
//                if(game is not null)
//                {
//                    Console.WriteLine($"{game.Id} | {game.Title} | {game.Description} | {game.IsNew} | {game.ReleaseDate} | {game.PEGI} | {game.Price}");
//                }
//                else
//                {
//                    Console.WriteLine("Il n'y a pas de jeux avec cette Id");
//                }
//                Console.ReadLine();

//            }
//            break;


//        case "3":
//            using (DataContext dc = new DataContext()) 
//            {

//                Game game = new Game
//                {
//                    Title = "Rocket League5",
//                    Description = "Du foot avec des voitures",
//                    IsNew = true,
//                    ReleaseDate = new DateTime(2015, 07, 07),
//                    PEGI = 3,
//                    Price = 1,
//                    GameDetails = new GameDetails
//                    {
//                        FileSize = 100,
//                    }
//                };

//                dc.Add(game);
//                dc.SaveChanges();

//                if(game.Id > 0)
//                {
//                    Console.WriteLine($"Le jeu à bien été créé à l'Id : {game.Id} et l'id du détail est {game.GameDetails.Id}");
//                }
//                else
//                {
//                    Console.WriteLine("Le jeu n'a pas été créé");
//                }
//                Console.ReadLine ();

//            }
//            break;

//        case "4":
//            Console.WriteLine("Veuillez entrer l'id du jeu à modifier :");
//            int idJeuAUpdate = int.Parse(Console.ReadLine());
//            using (DataContext dc = new DataContext())
//            {
//                //    Game jeuAUpdate = dc.Games.SingleOrDefault(g => g.Id == idJeuAUpdate);

//                //    if(jeuAUpdate is not null)
//                //    {
//                //        jeuAUpdate.Price = 133;
//                //        try
//                //        {

//                //            dc.SaveChanges();
//                //        }
//                //        catch (Exception ex) 
//                //        {
//                //            Console.WriteLine(ex.Message);
//                //            Console.ReadLine();
//                //        }
//                //    }

//                Game jeuAUpdate = new Game { Id = 7, Title = "The Legend of Zelda", ReleaseDate = DateTime.Parse("1986-02-21"), Description = "Premier jeu de la série Zelda.", Price = -1, IsNew = false, PEGI = 7 };

//                dc.Games.Attach(jeuAUpdate);

//                dc.Entry(jeuAUpdate).State = EntityState.Modified;

//                try
//                {
//                    dc.SaveChanges();

//                }catch(DbUpdateException ex)
//                {

//                    Console.WriteLine($"{ex.Message}"); 
//                    Console.ReadLine();
//                }

//            }
//            break;

//        case "5":
//            Console.WriteLine("Veuillez entrer l'id du jeu à modifier :");
//            int idJeuADelete = int.Parse(Console.ReadLine());
//            using (DataContext dc = new DataContext())
//            {
//                Game jeuADelete = dc.Games.SingleOrDefault(g => g.Id == idJeuADelete);

//                if (jeuADelete is not null)
//                {
//                    dc.Remove(jeuADelete);

//                    dc.SaveChanges();
//                }
//            }
//            break;

//        case "0":
//            continuer = false;
//            break;

//        default:
//            Console.WriteLine("Choix invalide");
//            break;
//    }
//}

//using (DataContext dc = new DataContext())
//{

//    Studio studio = new Studio
//    {
//        Name = "Psyonix",
//        Games = new List<Game>
//        {
//            new Game
//            {
//                Title = "Rocket League5",
//                Description = "Du foot avec des voitures",
//                IsNew = true,
//                ReleaseDate = new DateTime(2015, 07, 07),
//                PEGI = 3,
//                Price = 1,
//                GameDetails = new GameDetails
//                {
//                    FileSize = 100,
//                }
//            }
//        }
//    };

//    dc.Add(studio);
//    dc.SaveChanges();

//}

//using(DataContext dc = new DataContext())
//{
//    Studio studio = dc.Studios.Include(s => s.Games).FirstOrDefault(s => s.Name.Contains("psyonix"));

//    if (studio != null)
//    {
//        Game game = new Game
//        {
//            Title = "Rocket League2",
//            Description = "Du foot avec des voitures",
//            IsNew = true,
//            ReleaseDate = new DateTime(2015, 07, 07),
//            PEGI = 3,
//            Price = 1,
//            GameDetails = new GameDetails
//            {
//                FileSize = 200,
//            }
//        };

//        studio.Games.Add(game);

//        dc.SaveChanges();
//    }

//}

//using (DataContext dc = new DataContext())
//{
//    using (IDbContextTransaction dbTransaction = dc.Database.BeginTransaction())
//    {

//        try
//        {

//            Game game = new Game
//            {
//                Title = "Rocket League67",
//                Description = "Du foot avec des voitures",
//                IsNew = true,
//                ReleaseDate = new DateTime(2015, 07, 07),
//                PEGI = 3,
//                Price = 1,
//                GameDetails = new GameDetails
//                {
//                    FileSize = 200,
//                },
//                StudioId = 1,
//            };
//            Game game2 = new Game
//            {
//                Title = "Rocket League65",
//                Description = "Du foot avec des voitures",
//                IsNew = true,
//                ReleaseDate = new DateTime(2015, 07, 07),
//                PEGI = 3,
//                Price = 1,
//                GameDetails = new GameDetails
//                {
//                    FileSize = 200,
//                },
//                StudioId = 1,
//            };


//            Platform playstation = dc.Platforms.FirstOrDefault(p => p.Name.Contains("playstation"));
//            Platform xbox = dc.Platforms.FirstOrDefault(p => p.Name.Contains("xbox"));


//            GamePlatform g1 = new GamePlatform { Game = game, Platform = playstation };
//            GamePlatform g2 = new GamePlatform { Game = game, Platform = xbox };

//            dc.GamePlatform.AddRange(g2, g1);

//            dc.SaveChanges();

//            GamePlatform g3 = new GamePlatform { Game = game2, Platform = playstation };
//            GamePlatform g4 = new GamePlatform { Game = game2, Platform = xbox };

//            dc.GamePlatform.AddRange(g3, g4);

//            dc.SaveChanges();

//            dbTransaction.Commit();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//            dbTransaction.Rollback();
//        }
//    }
//    //Platform playstation = new Platform { Name = "PlayStation" };
//    //Platform xbox = new Platform { Name = "Xbox" };

//    //Game game = new Game
//    //{
//    //    Title = "Rocket League4",
//    //    Description = "Du foot avec des voitures",
//    //    IsNew = true,
//    //    ReleaseDate = new DateTime(2015, 07, 07),
//    //    PEGI = 3,
//    //    Price = 1,
//    //    GameDetails = new GameDetails
//    //    {
//    //        FileSize = 200,
//    //    },
//    //    StudioId = 1,
//    //};

//    //GamePlatform gp1 = new GamePlatform { Game = game, Platform = playstation };
//    //GamePlatform gp2 = new GamePlatform { Game = game, Platform = xbox };


//    //dc.GamePlatform.AddRange(gp1, gp2);

//    //dc.SaveChanges();




//}



//using(DataContext dc = new DataContext())
//{
//    Platform ps = new Platform { Name = "Playstation" };
//    Platform xbox = new Platform { Name = "Xbox" };

//    Game game = new Game
//    {

//            Title = "Rocket League4",
//            Description = "Du foot avec des voitures",
//            IsNew = true,
//            ReleaseDate = new DateTime(2015, 07, 07),
//            PEGI = 3,
//            Price = 1,
//            GameDetails = new GameDetails
//            {
//                FileSize = 200,
//            },
//            StudioId = 1,
//            Platforms = new List<Platform> { ps, xbox },



            
//    }

//    Game GameDetails = dc.Games.Include(g => g.Platforms).FirstOrDefault(g => g.Title == "Rocket league");
//}

using(DataContext dc = new DataContext())
{
    Game game = dc.Games.Include(g => g.Platforms)
                        .ThenInclude(gp => gp.Platform)
                        .FirstOrDefault(g => g.Title.Contains("Rocket League"));

    Console.WriteLine($"{game.Title} ");
    foreach (GamePlatform platform in game.Platforms)
    {
        Console.WriteLine($"  - {platform.Platform.Name}");
    }
}
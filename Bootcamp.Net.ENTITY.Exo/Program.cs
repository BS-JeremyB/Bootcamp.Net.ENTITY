using Bootcamp.Net.ENTITY.Exo.Data;
using Bootcamp.Net.ENTITY.Exo.Entities;
using Microsoft.EntityFrameworkCore;

#region Ajout d'un film
//using (DataContext dc = new DataContext())
//{
//    Film filmAAjouter = new Film 
//    {
//        Titre = "Pacific Rim",
//        ActeurPrincipal = "Charlie Hunnam",
//        Realisateur = "Guillermo Del Toro",
//        AnneeSortie = 2013,
//        Genre = "Action"
//    }; 

//    try
//    {
//        dc.Films.Add(filmAAjouter);
//        dc.SaveChanges();

//    }catch(DbUpdateException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }

//    if(filmAAjouter.Id > 0)
//    Console.WriteLine($"Le film à été ajouté à l'Id : {filmAAjouter.Id}");
//}
#endregion

#region Afficher les films Réalisé avant 2001
//using (DataContext dc = new DataContext())
//{
//    IEnumerable<Film> films = dc.Films.Where(f => f.AnneeSortie < 2001);

//    foreach (Film film in films)
//    {
//        Console.WriteLine(film.ToString());
//    }
//}
#endregion

#region Changer Acteur Principal
//using (DataContext dc  = new DataContext())
//{
//    int nbrRows = dc.Films.Where(f => f.Titre.Contains("Star Wars"))
//                          .ExecuteUpdate(u => u.SetProperty(f => f.ActeurPrincipal, "Harrison Ford"));

//    Console.WriteLine(nbrRows);
//    ;
//    //foreach (Film film in films)
//    //{
//    //    film.ActeurPrincipal = "Harrison Ford";
//    //}
//    if(nbrRows > 0)
//    {
//        try
//        {
//            dc.SaveChanges();
//        }
//        catch (DbUpdateException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//}
#endregion

#region Supprimer des films
using (DataContext dc = new DataContext())
{
    IEnumerable<Film> films = dc.Films.Where(f => f.ActeurPrincipal.Contains("Hunnam"));

    dc.RemoveRange(films);

    //foreach(Film film in films)
    //{
    //    dc.Remove(film);
    //}

    try
    {
        dc.SaveChanges();
    }catch(DbUpdateException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
#endregion 
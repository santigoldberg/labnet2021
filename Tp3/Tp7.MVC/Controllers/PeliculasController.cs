using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using Tp7.MVC.Models;

namespace Tp7.MVC.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas
        

        public ActionResult Index()
        {
            try
            {
                TMDbClient client = new TMDbClient("f2db576f970dc20fdd090f9e96001929");
                
                SearchContainer<SearchMovie> movies = client.GetMoviePopularListAsync().Result;

                List<PeliculasView> peliculas = new List<PeliculasView>();

                movies.Results.ForEach(searchMovie => {
                   PeliculasView pelicula = new PeliculasView
                    {
                        Id = searchMovie.Id,
                        OriginalTitle = searchMovie.OriginalTitle,
                        
                    };
                    peliculas.Add(pelicula);
                });

                return View(peliculas);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex.Message);
            }


        }

    }
}
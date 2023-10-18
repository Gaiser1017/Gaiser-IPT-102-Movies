using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;

        public MoviesController()
        {
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
                new MovieViewModel { Id = 1, Name = "Iron Man", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=KAE5ymVLmZg", Description = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 2, Name = "Thor", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=qYmPZIn9rno", Description = "The powerful but arrogant god Thor is cast out of Asgard to live amongst humans in Midgard (Earth), where he soon becomes one of their finest defenders.\r\n", Genre = "Genre: Superhero Fiction"},
                new MovieViewModel { Id = 3, Name = "Captain America: The First Avenger", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=L4DZ-L9SwRY", Description = "Steve Rogers, a rejected military soldier, transforms into Captain America after taking a dose of a \"Super-Soldier serum\". But being Captain America comes at a price as he attempts to take down a warmonger and a terrorist organization.\r\n, Genre = \"Superhero Fiction", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 4, Name = "The Avengers", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=cT9g4_0UnxI", Description = "Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 5, Name = "Thor The Dark World", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=wQnQhqskHM8", Description = "When the Dark Elves attempt to plunge the universe into darkness, Thor must embark on a perilous and personal journey that will reunite him with doctor Jane Foster.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 6, Name = "Captain America: Civil War", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=X5qNd0A7vOw", Description = "Political involvement in the Avengers' affairs causes a rift between Captain America and Iron Man.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 7, Name = "Doctor Strange: Multiverse of Madness", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=zpz1Ncgx1KQ", Description = "Doctor Strange teams up with a mysterious teenage girl from his dreams who can travel across multiverses, to battle multiple threats, including other-universe versions of himself, which threaten to wipe out millions across the multiverse. They seek help from Wanda the Scarlet Witch, Wong and others.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 8, Name = "Spiderman: Homecoming", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=vxoJL60Q_vo", Description = "Peter Parker balances his life as an ordinary high school student in Queens with his superhero alter-ego Spider-Man, and finds himself on the trail of a new menace prowling the skies of New York City.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 9, Name = "Black Panther", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=UH0KeoB72zs", Description = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 10, Name = "Infinity War", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=C4NGf35h_Ww", Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 11, Name = "Antman and the Wasp: Quantumania", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=ZlNFpri-Y40", Description = "Scott Lang and Hope Van Dyne are dragged into the Quantum Realm, along with Hope's parents and Scott's daughter Cassie. Together they must find a way to escape, but what secrets is Hope's mother hiding? And who is the mysterious Kang?\\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 12, Name = "Captain Marvels", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=wS_qbDztgVY", Description = "Carol Danvers becomes one of the universe's most powerful heroes when Earth is caught in the middle of a galactic war between two alien races.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 13, Name = "Endgame", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=hA6hldpSTF8", Description = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 14, Name = "Shang chi and the Legend of the Ten Rings", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=8YjFbMbfXaQ", Description = "Shang-Chi, the master of weaponry-based Kung Fu, is forced to confront his past after being drawn into the Ten Rings organization.\r\n", Genre = "Genre: Superhero Fiction" },
                new MovieViewModel { Id = 15, Name = "Thor Love and Thunder", Rating = "1", Image = "css/picture/Pic1.jpg", Details = "https://www.youtube.com/watch?v=smfEF8xeBu4", Description = "Thor enlists the help of Valkyrie, Korg and ex-girlfriend Jane Foster to fight Gorr the God Butcher, who intends to make the gods extinct.\r\n", Genre = "Genre: Superhero Fiction" },
            };
        }

        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }

        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);
        }
    }
}
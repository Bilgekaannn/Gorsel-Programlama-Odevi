using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Şanslı Biri",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 19 Dakika",
                    price = 40,
                    picturePath = basePath + "\\thumb_ug0WQaS1echV9BQoSeL2im9I3hk.jpg"
                },
                   new Movie()
                {
                    movieName = "Ejderha Savaşçılarının Şafağı",
                    category = Category.macera,
                    minute = "2 Saat 30 Dakika",
                    price = 20,
                    picturePath = basePath + "\\fullhd-dragons-dawn-of-the-dragon-racers.jpg"
                },
                new Movie()
                {
                    movieName = "Kızıl Savaşçılar",
                    category = Category.bilimKurgu,
                    minute = "1 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "\\kizil-savascilar-1660920454.jpg"
                },
                new Movie()
                {
                    movieName = "Logan",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "\\531088.jpg"
                },
                new Movie()
                {
                    movieName = "El Camino: A Breaking Bad Movie",
                    category = Category.komedi,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    picturePath = basePath + "\\MV5BNjk4MzVlM2UtZGM0ZC00M2M1LThkMWEtZjUyN2U2ZTc0NmM5XkEyXkFqcGdeQXVyOTAzMTc2MjA@._V1_.jpg"
                },

             new Movie()
                {
                    movieName = "Jarhead 2: Ateş Alanı",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 10 Dakika",
                    price = 120,
                    picturePath = basePath + "\\7d0cb4a2a8fe0130fe3d1a93cab88026ef3eb64462022c8b0266aed11745ef28._RI_V_TTW_.jpg"
                },


            };
        }
    }
}

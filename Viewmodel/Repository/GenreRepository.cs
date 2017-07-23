using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewmodel.ViewModel.Helpers;

namespace Viewmodel.Repository 
{
    public class GenreRepository : BaseViewModel
    {
 

        public  void Add(String genreName, ObservableCollection<Genre> ListGenres)
        {

            bool existInList = false;

            foreach (var genre in ListGenres)
            {
                if (genre.Name.ToUpper() == genreName.ToUpper())
                {
                    existInList = true;
                    break;
                }
            }

            if (existInList)
            {
                throw new ArgumentException("name already is in the list", "name");
            }

            Genre g = new Genre();
            g.Name = genreName;

            ListGenres.Add(g);
            _context.Genres.Add(g);
            _context.SaveChanges();
        }

    }
}

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
    public class CountryRepository : BaseViewModel
    {
 

        public  void Add(String countryName, ObservableCollection<Country> ListCountries)
        {
            bool existInList = false;

            foreach (var country in ListCountries)
            {
                if (country.Name.ToUpper() == countryName.ToUpper())
                {
                    existInList = true;
                    break;
                }
            }

            if (existInList)
            {
                throw new ArgumentException("name already is in the list", "name");
            }

            Country c = new Country();
            c.Name = countryName;

            ListCountries.Add(c);

            _context.Countries.Add(c);
            _context.SaveChanges();
        }

    }
}

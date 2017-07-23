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
    public class LabelRepository : BaseViewModel
    {
 

        public  void Add(String labelName, ObservableCollection<Label> ListLabels)
        {

            bool existInList = false;

            foreach (var label in ListLabels)
            {
                if (label.Name.ToUpper() == labelName.ToUpper())
                {
                    existInList = true;
                    break;
                }
            }

            if (existInList)
            {
                throw new ArgumentException("name already is in the list", "name");
            }

            Label l = new Label();
            l.Name = labelName;

            ListLabels.Add(l);

            _context.Labels.Add(l);
            _context.SaveChanges();
        }

    }
}

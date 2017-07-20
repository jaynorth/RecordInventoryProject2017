using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Viewmodel.ViewModel.Helpers
{
    public class BaseViewModel : INotifyPropertyChanged
    {

       
            protected RecordsDBEntities _context;

            public BaseViewModel()
            {
                _context = new RecordsDBEntities();
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void FirePropertyChanged([CallerMemberName] string propertyName = null)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Innlevering02.Model;

namespace Innlevering02.ViewModel
{
    public class PropertyViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public PropertyViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                });
        }
    }
}

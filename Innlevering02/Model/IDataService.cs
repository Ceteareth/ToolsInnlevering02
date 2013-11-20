using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Innlevering02.Model.Custom_Models
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
    }
}

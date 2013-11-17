using System;
using GalaSoft.MvvmLight;

namespace Innlevering02.Model.Custom_Models.Property_Classes
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public abstract class BaseProperty : ViewModelBase
    {
        public String Name
        {
            get;
            internal set;
        }

        protected BaseProperty()
        {
        }

        public abstract object ReturnValue();
    }
}
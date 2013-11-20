using System;
using GalaSoft.MvvmLight;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public abstract class BaseProperty
    {
        public abstract String Name
        {
            get; set;
        }

        public abstract object GetValue();
    }
}
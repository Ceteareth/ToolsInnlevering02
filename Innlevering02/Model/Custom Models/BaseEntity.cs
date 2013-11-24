using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class BaseEntity
    {
        public string Name { get; set; }
        public ObservableCollection<BaseProperty> PropertyCollection; 

        /// <summary>
        /// Initializes a new instance of the BaseEntity class.
        /// </summary>
        public BaseEntity()
        {
            Name = "Unknown";
            PropertyCollection = new ObservableCollection<BaseProperty>();
        }

        public BaseEntity(string name, params BaseProperty[] listBaseProperty)
        {
            PropertyCollection = new ObservableCollection<BaseProperty>();
            Name = name;

            foreach (BaseProperty property in listBaseProperty)
            {
                PropertyCollection.Add(property);
            }
        }
    }
}
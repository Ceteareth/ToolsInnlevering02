using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models
{
    // Base entity class which basically holds its own name, as well as a collection of properties.
    // The collection is used both for serializing and display.
    public class BaseEntity
    {
        public string Name { get; set; }
        public ObservableCollection<BaseProperty> PropertyCollection; 

        public BaseEntity()
        {
            Name = "Unknown";
            PropertyCollection = new ObservableCollection<BaseProperty>();
        }

        // Takes a (more or less) unlimited amount of BaseProperties. Useful if one wishes to have many.
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
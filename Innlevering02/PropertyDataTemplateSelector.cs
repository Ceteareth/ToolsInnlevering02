using System;
using System.Windows;
using System.Windows.Controls;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;

namespace Innlevering02
{
    // An instance of this class gets called when the property list is populated
    // It determines based on the datatype which datatemplate the program should use to display information
    // In this case, a default template (name and textbox) is used for anything other than bool, where a checkbox is used instead of a textbox
    public class PropertyDataTemplateSelector : DataTemplateSelector
    {
        // The two available datatemplates.
        public DataTemplate DefaultDataTemplate { get; set; }
        public DataTemplate BooleanDataTemplate { get; set; }

        // Checks the property, and returns the appropriate datatemplate.
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            BaseProperty baseProperty = item as BaseProperty;
            if (baseProperty != null && baseProperty.Value is bool)
            {
                return BooleanDataTemplate;
            }

            return DefaultDataTemplate;
        }
    }
}
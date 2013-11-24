using System;
using System.Windows;
using System.Windows.Controls;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;

namespace Innlevering02
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class PropertyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate { get; set; }
        public DataTemplate BooleanDataTemplate { get; set; }

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
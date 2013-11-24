/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:Innlevering02.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Innlevering02.Model.Custom_Models;

namespace Innlevering02.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        // Near default state ViewModelLocator.
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Registers the two viewmodels we're using.
            SimpleIoc.Default.Register<PropertyViewModel>();
            SimpleIoc.Default.Register<ListViewModel>();
        }

        // Gets the propertyviewmodel property
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public PropertyViewModel Properties
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PropertyViewModel>();
            }
        }

        // Gets the listviewmodel property
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public ListViewModel EntityList
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ListViewModel>();
            }
        }

        // Currently no cleanup that needs to be done.
        public static void Cleanup()
        {
        }
    }
}
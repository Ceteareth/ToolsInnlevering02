using System;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Innlevering02.Model;
using Innlevering02.Model.Custom_Models;

namespace Innlevering02.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ListViewModel : ViewModelBase
    {

        public ObservableCollection<BaseEntity> UnnamedEntityCollection
        {
            get; private set;
        }

        private int _unnamedEntityIndex;
        public int UnnamedEntityIndex
        {
            get { return _unnamedEntityIndex; }
            set
            {
                _unnamedEntityIndex = value;
                Console.WriteLine(UnnamedEntityCollection.ElementAt(value));
                Messenger.Default.Send<BaseEntity, PropertyViewModel>(UnnamedEntityCollection.ElementAt(value));
            }
        }

        public ObservableCollection<BaseEntity> NamedEntityCollection
        {
            get;
            private set;
        }

        private int _namedEntityIndex;
        public int NamedEntityIndex
        {
            get { return _namedEntityIndex; }
            set
            {
                _namedEntityIndex = value;
                Console.WriteLine(NamedEntityCollection.ElementAt(value));
                Messenger.Default.Send<BaseEntity, PropertyViewModel>(NamedEntityCollection.ElementAt(value));
            }
        }

        public ListViewModel()
        {
            UnnamedEntityCollection = new ObservableCollection<BaseEntity>
            {
                new Buzzer(),
                new KamikazeBuzzer(),
                new Mech(),
                new Spider()
            };
            UnnamedEntityIndex = 0;

            NamedEntityCollection = new ObservableCollection<BaseEntity>
            {
                new Player(),
                new ConfusedMech()
            };
            NamedEntityIndex = 0;
        }
    }
}
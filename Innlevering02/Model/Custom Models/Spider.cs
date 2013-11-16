﻿using GalaSoft.MvvmLight;

namespace Innlevering02.Model
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class Spider : ViewModelBase
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public float MovementSpeed { get; set; }

        /// <summary>
        /// Initializes a new instance of the Spider class.
        /// </summary>
        public Spider()
        {
            Health = 20;
            Damage = 10;
            MovementSpeed = 0.5f;
        }
    }
}
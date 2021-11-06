﻿using System.ComponentModel;

namespace InventoryManager.Data
{
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

    }
}

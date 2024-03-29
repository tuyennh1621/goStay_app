﻿using goStay.Data;
using goStay.Models;

namespace goStay.Views
{
    [QueryProperty(nameof(Name), "name")]
    public partial class DogDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                LoadAnimal(value);
            }
        }

        public DogDetailPage()
        {
            InitializeComponent();
        }

        void LoadAnimal(string name)
        {
            try
            {
                Animal animal = DogData.Dogs.FirstOrDefault(a => a.Name == name);
                BindingContext = animal;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load animal.");
            }
        }
    }
}

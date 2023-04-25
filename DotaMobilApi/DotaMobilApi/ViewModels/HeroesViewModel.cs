using DotaMobilApi.Models;
using DotaMobilApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DotaMobilApi.ViewModels
{
    public class HeroesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        IHeroesService _rest = DependencyService.Get<IHeroesService>();
        public HeroesViewModel()
        {
            GetHeroes();
        }

        public async void GetHeroes()
        {
            var result = await _rest.getHeroes();

            if (result != null)
            {
                HeroesStats = result;
            }
        }
        private ObservableCollection<HeroesStat> heroesStats;

        public ObservableCollection<HeroesStat> HeroesStats
        {
            get { return heroesStats; }
            set 
            { 
                heroesStats = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HeroesStats"));
            }
        }

    }
}

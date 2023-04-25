using DotaMobilApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DotaMobilApi.Services
{
    public interface IHeroesService
    {
        Task<ObservableCollection<HeroesStat>> getHeroes();
    }
}

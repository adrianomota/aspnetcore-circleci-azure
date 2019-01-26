using System;
using System.Collections.Generic;
using WorshopAspnetCore.Models;

namespace WorshopAspnetCore
{
    public class CityDataStore
    {
        public static CityDataStore Current { get; } = new CityDataStore();

        public IList<CityViewModel> Cities { get; set; }

        public CityDataStore()
        {
            Cities = new List<CityViewModel>()
            {
                new CityViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Rio de Janeiro",
                    PointOfInterest = new List<PointOfInterestViewModel>()
                    {
                        new PointOfInterestViewModel()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Corcovado",
                            Description = "Grande morro de onde se vê todo o Rio de Janeiro"
                        },

                        new PointOfInterestViewModel()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Cristo Rednetor",
                            Description = "Grande escultura do Cristo redentor"
                        },
                    }
                },

                new CityViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "New York City",

                    PointOfInterest = new List<PointOfInterestViewModel>()
                    {
                        new PointOfInterestViewModel()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Central Park",
                            Description = "Parque mais visitado de new work"
                        },
                    },
                 },

                new CityViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Antwerp" ,
                     PointOfInterest = new List<PointOfInterestViewModel>()
                    {
                        new PointOfInterestViewModel()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Cathedral of Hour Lady",
                            Description = "A Gothic style cathedral, conceived by architects."
                        },
                    },
                },

                new CityViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Wakanda",
                     PointOfInterest = new List<PointOfInterestViewModel>()
                    {
                        new PointOfInterestViewModel()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Trem bala de Wakanda",
                            Description = "Nesses trens são carregados os Vibranios da cidade"
                        },
                    },
                },
            };
        }
    }
}
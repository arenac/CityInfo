using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.Api.Models;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Point 1",
                            Description = "Very cool"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Point 2",
                            Description = "Very nice"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with that cathedral that was never realy finished.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Point 3",
                            Description = "Very cool"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Point 4",
                            Description = "Very nice"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Point 5",
                            Description = "Very cool"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Point 6",
                            Description = "Very nice"
                        }
                    }
                }
            };
        }
    }
}

using MagicVlla_VillaAPI.Models.Dto;

namespace MagicVlla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
                new VillaDTO { Id = 1, Name = "Pool View", Occupancy = 4, sqft = 1500 },
                new VillaDTO { Id = 2, Name = "Ocean Breeze", Occupancy = 6, sqft = 2000 },
                new VillaDTO { Id = 3, Name = "Mountain Retreat", Occupancy = 8, sqft = 2500 },
                new VillaDTO { Id = 4, Name = "Sunset Haven", Occupancy = 5, sqft = 1800 },
                new VillaDTO { Id = 5, Name = "Garden Oasis", Occupancy = 3, sqft = 1200 },
                new VillaDTO { Id = 6, Name = "Beachfront Bliss", Occupancy = 7, sqft = 2200 },
                new VillaDTO { Id = 7, Name = "Forest Escape", Occupancy = 4, sqft = 1600 },
                new VillaDTO { Id = 8, Name = "Lakeside Lodge", Occupancy = 6, sqft = 2100 },
                new VillaDTO { Id = 9, Name = "Urban Sanctuary", Occupancy = 2, sqft = 1000 },
                new VillaDTO { Id = 10, Name = "Desert Mirage", Occupancy = 5, sqft = 1700 }



        };
    }
}

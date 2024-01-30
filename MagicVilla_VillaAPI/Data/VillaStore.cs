using MagicVilla_VillaAPI.Model;
using MagicVilla_VillaAPI.Model.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> VillaList = new List<VillaDto>
        {
            new VillaDto{Id = 1,Name = "Pool Villa",Occupancy=4,Sqft=100},
            new VillaDto{Id = 2,Name = "Beach Villa",Occupancy=4,Sqft=100}
        };

    }
}

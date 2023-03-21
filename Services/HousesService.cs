namespace gregslist.Services
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
  using gregslist.Models;

  public class HousesService
    {
        
        private readonly HousesRepository _houseRepository;

    public HousesService(HousesRepository houseRepository)
    {
        _houseRepository = houseRepository;
    }

    internal List<House> getAllHouses()
    {
        List<House> houses = _houseRepository.getAllHouses();
        return houses;
    }

    internal House getHouseById(int houseId)
    {
        House house = _houseRepository.getHouseById(houseId);
        if(house == null)throw new Exception("bad house id man");
        return house;
    }

    internal House postHouse()
    {
        House house = _houseRepository.postHouse();
        return house;
    }
  }
}
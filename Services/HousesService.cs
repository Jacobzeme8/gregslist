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

    internal string deleteHouse(int id)
    {
        int rows = _houseRepository.deleteHouse(id);
        if(rows < 1) throw new Exception("bad house Id my dude!");
        if(rows > 1) throw new Exception("something went very bad");
        string message = "House has been deleted!";
        return message;
    }

    internal House editHouse(House updata)
    {
        House house = this.getHouseById(updata.id);
        house.address = updata.address != null ? updata.address : house.address;
        house.bedrooms = updata.bedrooms != null ? updata.bedrooms : house.bedrooms;
        house.bathrooms = updata.bathrooms != null ? updata.bathrooms : house.bathrooms;
        house.floors = updata.floors != null ? updata.floors : house.floors;
        int rows = _houseRepository.editHouse(house);
        if(rows < 1) throw new Exception("bad house Id my dude!");
        if(rows > 1) throw new Exception("something went very bad");
        return updata;
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

    internal House postHouse(House houseData)
    {
        House house = _houseRepository.postHouse(houseData);
        return house;
    }
  }
}
namespace gregslist.Repositories
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
  using gregslist.Models;

  public class HousesRepository
    {
        
        private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<House> getAllHouses()
    {
        string sql = @"
        SELECT
        *
        FROM houses;
        ";

        List<House> houses = _db.Query<House>(sql).ToList();
        return houses;
    }

    internal House getHouseById(int houseId)
    {
        string sql = @"
        SELECT
        *
        FROM houses
        WHERE id = @id;
        ";

        int id = houseId;

        House house = _db.Query<House>(sql, new {id}).FirstOrDefault();
        return house;
    }
    }
}
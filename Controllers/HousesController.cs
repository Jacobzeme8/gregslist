namespace gregslist.Controllers
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _housesService;

    public HousesController(HousesService housesService)
    {
        _housesService = housesService;
    }

    [HttpGet]
    public ActionResult<List<House>> getAllHouses(){
        try 
        {
            List<House> houses = _housesService.getAllHouses();
            return houses;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{houseId}")]
    public ActionResult<House> getHouseById(int houseId){
        try 
        {
            House house = _housesService.getHouseById(houseId);
            return house;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<House> postHouse(){
        try 
        {
            House house = _housesService.postHouse();
            return house;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }




    }
}
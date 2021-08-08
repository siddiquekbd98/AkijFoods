using Akijfood.Repository;
using AkijFood.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
    public class ColdDrinksController : ControllerBase
    {
        private readonly IColdDrinks _coldDrinkRepository;

        public ColdDrinksController(IColdDrinks coldDrinkRepository)
        {
            _coldDrinkRepository = coldDrinkRepository;
        }

        [HttpGet("GetProducts")]
        public async Task<ActionResult> GetProducts()
        {
            return Ok(await _coldDrinkRepository.Products());
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct()
        {
            return Ok(await _coldDrinkRepository.AddDrinks());
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProduct(ColdDrinks ColdDrinks)
        {
            return Ok(await _coldDrinkRepository.UpdateDrink(ColdDrinks));
        }

        [HttpDelete("DeleteSpeed")]
        public async Task<ActionResult> DeleteProduct()
        {
            await _coldDrinkRepository.DeleteDrink();

            return null;
        }

        [HttpDelete("DeleteProductUnder500")]

        public async Task<ActionResult> DeleteProductUnder500()
        {
            await _coldDrinkRepository.DeleteDrinkUnder500();

            return null;
        }


        [HttpGet("totalPrice")]
        public async Task<ActionResult> totalPrice()
        {
            return Ok(await _coldDrinkRepository.totalPrice());
        }
    }
}

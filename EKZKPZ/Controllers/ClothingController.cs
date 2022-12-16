using AutoMapper;
using EKZKPZ.DTOs;
using EKZKPZ.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKZKPZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingController : Controller
    {
        private readonly ClothingContext _context;
        private readonly IMapper _mapper;

        public ClothingController(ClothingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Clothing> GetAll()
        {
            return _context.Clothing;
        }

        [HttpGet("{id}")]
        public ActionResult<Clothing> GetById(int id)
        {
            var clothing = _context.Clothing.Find(id);

            if (clothing == null)
            {
                return NotFound();
            }

            return clothing;
        }

        [HttpPost]
        public IActionResult AddClothing(ClothingDTO clothingDTO)
        {
            var clothing = _mapper.Map<Clothing>(clothingDTO);

            _context.Clothing.Add(clothing);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateClothing(int id, Clothing clothing)
        {
            clothing.Id = id;

            _context.Clothing.Update(clothing);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClothing(int id)
        {
            var clothing = _context.Clothing.Find(id);
            if (clothing == null)
            {
                return NotFound();
            }

            _context.Clothing.Remove(clothing);
            _context.SaveChanges();

            return Ok();
        }
    }
}
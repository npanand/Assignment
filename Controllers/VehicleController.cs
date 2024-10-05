using assignmentProject.Data;
using assignmentProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignmentProject.Controllers
{
    public class VehicleController : Controller
    {

        private readonly ApplicationDbContext _dbcontext;
        public VehicleController(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var VehicleData = await _dbcontext.VehicleDetails.ToListAsync();
                return View(VehicleData);
            }
            catch(Exception ex)
            {
                TempData["Error"] = "Db error";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
                return View();   
        }
        [HttpPost]
        public async Task<IActionResult> Create(VehicleDetails vehicle)
        {
            try
            {
                _dbcontext.VehicleDetails.Add(vehicle);
                await  _dbcontext.SaveChangesAsync();
                TempData["Success"] = "Added Successfully";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["Error"] = "Db error";
                return View();
            }
        }
       
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try {
                var filterVehicle = await _dbcontext.VehicleDetails
                         .FirstOrDefaultAsync(v => v.ID == id);

                return View(filterVehicle);
            }
            catch(Exception ex)
            {
                TempData["Error"] = "Db error";
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(VehicleDetails vehicleDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dbcontext.VehicleDetails.Update(vehicleDetails);
                    await _dbcontext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Db error";
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var filterVehicle = await _dbcontext.VehicleDetails
    .FirstOrDefaultAsync(v => v.ID == id);

                return View(filterVehicle);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Db error";
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(VehicleDetails vehicleDetails)
        {
            try
            {
                _dbcontext.VehicleDetails.Remove(vehicleDetails);

                await _dbcontext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Db error";
                return View();
            }
        }
    }
}

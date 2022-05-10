using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Models;
using OrderManagement.ViewModels;
using System;

namespace OrderManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISupplierRepository _supplierRepository;

        public HomeController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public ViewResult Index()
        {
            var model = _supplierRepository.GetAllSupplier();
            return View(model);
        }

        public ViewResult Details(string id)
        {
            int supplierId = Convert.ToInt32(id);

            Supplier supplier = _supplierRepository.GetSupplier(supplierId);

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Supplier = supplier,
                PageTitle = "Supplier Details"
            };

            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SupplierCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Supplier newSupplier = new Supplier
                {
                    Name = model.Name,
                    AddresslineOne = model.AddresslineOne,
                    AddresslineTwo = model.AddresslineTwo,  
                    City = model.City,
                    PostalCode = model.PostalCode,
                    State = model.State
                };

                _supplierRepository.Add(newSupplier);
                return RedirectToAction("details", new { id = newSupplier.Id });
            }

            return View();
        }


        [HttpGet]
        public ViewResult Edit(int id)
        {
            Supplier supplier = _supplierRepository.GetSupplier(id);
            SupplierEditViewModel supplierEditViewModel = new SupplierEditViewModel
            {
                Id = supplier.Id,
                Name = supplier.Name,
                AddresslineOne = supplier.AddresslineOne,
                AddresslineTwo = supplier.AddresslineTwo,
                City = supplier.City,
                PostalCode = supplier.PostalCode,
                State = supplier.State
        };
            return View(supplierEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(SupplierEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Supplier supplier = _supplierRepository.GetSupplier(model.Id);

                supplier.Name = model.Name;
                supplier.AddresslineOne = model.AddresslineOne;
                supplier.AddresslineTwo = model.AddresslineTwo;
                supplier.City = model.City;
                supplier.PostalCode = model.PostalCode;
                supplier.State = model.State;

                _supplierRepository.Update(supplier);
                return RedirectToAction("index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var supplierToDelete = _supplierRepository.GetSupplier(id);

                if (supplierToDelete == null)
                {
                    return NotFound($"Supplier with Id = {id} not found");
                }

                _supplierRepository.Delete(supplierToDelete.Id);

                return RedirectToAction("index");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}

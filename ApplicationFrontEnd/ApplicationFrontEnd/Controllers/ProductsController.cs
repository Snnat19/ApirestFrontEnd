﻿using ApplicationFrontEnd.Models.DTO;
using ApplicationFrontEnd.Repository.Interfaces;
using ApplicationFrontEnd.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationFrontEnd.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(new ProductDTO() { });
        }

        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                //Llama al repositorio
                var data = await _productRepository.GetAllAsync(UrlResources.UrlBase + UrlResources.UrlProducts);
                return Json(new { data });
            }
            catch (Exception ex)
            {
                // Log the exception, handle it, or return an error message as needed
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDTO product)
        {
            try
            {
                await _productRepository.PostAsync(UrlResources.UrlBase + UrlResources.UrlProducts, product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            var product = new ProductDTO();

            product = await _productRepository.GetByIdAsync(UrlResources.UrlBase + UrlResources.UrlProducts, id.GetValueOrDefault());
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.UpdateAsync(UrlResources.UrlBase + UrlResources.UrlProducts + product.Id, product);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(UrlResources.UrlBase + UrlResources.UrlProducts, id);
            if (product == null)
            {
                return Json(new { success = false, message = "Cliente no encontrado." });
            }

            var deleteResult = await _productRepository.DeleteAsync(UrlResources.UrlBase + UrlResources.UrlProducts, id);
            if (deleteResult)
            {
                return Json(new { success = true, message = "Producto eliminado correctamente." });
            }
            else
            {
                return Json(new { success = false, message = "Error al eliminar el producto." });
            }
        }
    }
}

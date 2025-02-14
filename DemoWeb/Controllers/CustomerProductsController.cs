﻿using DemoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace DemoWeb.Controllers
{
    public class CustomerProductsController : Controller
    {
        private DBSportStoreEntities db = new DBSportStoreEntities();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products;
            return View(products.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    }
}
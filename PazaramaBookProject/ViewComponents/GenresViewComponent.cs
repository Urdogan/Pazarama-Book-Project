﻿using Microsoft.AspNetCore.Mvc;
using PazaramaBookProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        private readonly BookContext _context;
        public GenresViewComponent(BookContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(_context.Genres.ToList());
        }
    }
}

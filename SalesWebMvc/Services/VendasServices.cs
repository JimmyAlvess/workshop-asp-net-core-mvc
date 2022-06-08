﻿using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class VendasServices 
    {
        private readonly SalesWebMvcContext _context;

        public VendasServices(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}
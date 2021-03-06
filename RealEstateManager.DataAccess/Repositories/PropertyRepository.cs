﻿using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database;
using RealEstateManager.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateManager.DataAccess.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RealEstateContext _dbContext;

        public PropertyRepository(RealEstateContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Property Add(Property property)
        {
            _dbContext.Add(property);
            _dbContext.SaveChanges();
            return property;
        }

        public bool Remove(int id)
        {
            var property = _dbContext.Properties.SingleOrDefault(x => x.Id == id);
            _dbContext.Properties.Remove(property);
            _dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Property> GetAll()
        {
            return _dbContext.Properties;
        }

        public Property GetById(int id)
        {
            return _dbContext.Properties.SingleOrDefault(x => x.Id == id);
        }
    }
}

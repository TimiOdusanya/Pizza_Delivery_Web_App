using ePizzaHub.Entities;
using ePizzaHub.Repositories.Interfaces;
using ePizzaHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Services.Implementations
{
    public class CatalogService : ICatalogService
    {
        private readonly IRepository<Item> _itemRepo;
        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<ItemType> _itemtypeRepo;

        public CatalogService(IRepository<Item> ItemRepo, IRepository<Category> CategoryRepo,IRepository<ItemType> ItemTypeRepo)
        {
            _itemRepo = ItemRepo;
            _categoryRepo = CategoryRepo;
            _itemtypeRepo = ItemTypeRepo;

        }
        public void AddItem(Item item)
        {
            _itemRepo.Add(item);
            _itemRepo.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            _itemRepo.Delete(id);
            _itemRepo.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepo.GetAll();
        }

        public Item GetItem(int id)
        {
            return _itemRepo.Find(id);
        }

        public IEnumerable<Item> GetItems()
        {
            return _itemRepo.GetAll().OrderBy(item => item.CategoryId).ThenBy(item => item.ItemTypeId);
        }

        public IEnumerable<ItemType> GetItemTypes()
        {
            return _itemtypeRepo.GetAll();
        }

        public void UpdateItem(Item item)
        {
            _itemRepo.Update(item);
            _itemRepo.SaveChanges();
        }
    }
}

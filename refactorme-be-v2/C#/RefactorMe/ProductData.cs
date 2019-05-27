using RefactorMe.DontRefactor.Data;
using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMe
{

    public class ProductData
    {
        public static IReadOnlyRepository<Lawnmower> _lawnRepo;
        public static IReadOnlyRepository<PhoneCase> _phoneCaseRepo;
        public static IReadOnlyRepository<TShirt> _tShirtRepo;
        public ProductData(IReadOnlyRepository<Lawnmower> lawnRepo,
                           IReadOnlyRepository<PhoneCase> phoneCaseRepo,
                           IReadOnlyRepository<TShirt> tShirtRepo)
        {
            _lawnRepo = lawnRepo;
            _phoneCaseRepo = phoneCaseRepo;
            _tShirtRepo = tShirtRepo;
        }

        public static List<Product> Get()
        {
            var l = _lawnRepo.GetAll().ToList();
            var p = _phoneCaseRepo.GetAll().ToList();
            var t = _phoneCaseRepo.GetAll().ToList();
            
            var ps = new List<Product>();

           
            foreach (var i in l)
            {
                ps.Add(new Product()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price,
                    Type = "Lawnmower"
                   
                });
            }

            foreach (var i in p)
            {
                ps.Add(new Product()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price,
                    Type = "Phone Case"
                    
                });
            }

            foreach (var i in t)
            {
                ps.Add(new Product()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Price = i.Price,
                    Type = "T-Shirt"
                    
                });
            }

            return ps;
        }
    }
      
}

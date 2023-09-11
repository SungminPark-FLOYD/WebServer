using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{  
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public interface IFoodService
    {
        IEnumerable<Food> GetFoods();
    }

    public class FoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>()
            {
                new Food() {Name = "Bibimbap", Price = 7000},
                new Food() {Name = "Kimbap", Price = 3000},
                new Food() {Name = "Bosam", Price = 9000}
            };

            return foods;
        }
    }
    public class FastFoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>()
            {
                new Food() {Name = "Hamburger", Price = 7000},
                new Food() {Name = "Fries", Price = 3000},
                new Food() {Name = "Chicken", Price = 9000}
            };

            return foods;
        }
    }

    public class PaymentService
    {
        IFoodService _service;

        public PaymentService(IFoodService service)
        {
            _service = service;
        }
    }

    //변하지 않는다
    public class SingletonService : IDisposable
    {
        public Guid ID { get; set; }

        public SingletonService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("SingletonService Disposed");
        }
    }

    //페이지가 바뀔때마다 변한다
    public class TransientService : IDisposable
    {
        public Guid ID { get; set; }

        public TransientService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("TransientService Disposed");
        }
    }

    //처음 접속할때 한번 변한다
    public class ScopedService : IDisposable
    {
        public Guid ID { get; set; }

        public ScopedService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("ScopedService Disposed");
        }
    }
}


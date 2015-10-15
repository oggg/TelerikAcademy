namespace Cars.Contracts
{
    using System.Collections.Generic;
    using Cars.Models;

    public interface ICarsRepository
    {
        int TotalCars { get; }

        void Add(Car car); // tested

        void Remove(Car car);

        Car GetById(int id); //tested

        ICollection<Car> All(); //tested

        ICollection<Car> SortedByMake(); //tested

        ICollection<Car> SortedByYear(); //tested

        ICollection<Car> Search(string condition);
    }
}

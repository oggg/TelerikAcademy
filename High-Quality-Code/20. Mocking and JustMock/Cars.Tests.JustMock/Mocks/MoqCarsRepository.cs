﻿namespace Cars.Tests.JustMock.Mocks
{
    using System;
    using System.Linq;
    using Cars.Contracts;
    using Cars.Models;
    using Moq;

    public class MoqCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);
            mockedCarsRepository.Setup(r => r.Search(It.IsAny<string>())).Returns(this.FakeCarCollection.Where(c => c.Make == "BMW").ToList());
            mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns(this.FakeCarCollection.First());
            mockedCarsRepository.Setup(r => r.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(x => x.Make).ToList());
            mockedCarsRepository.Setup(r => r.SortedByYear()).Returns(this.FakeCarCollection.OrderBy(y => y.Year).ToList());
            mockedCarsRepository.Setup(r => r.Search(It.IsAny<string>())).Throws(new ArgumentException("Invalid sorting parameter"));
            this.CarsData = mockedCarsRepository.Object;
        }
    }
}

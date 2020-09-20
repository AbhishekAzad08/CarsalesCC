using CarsalesCC.Controllers;
using CarsalesCC.Data;
using CarsalesCC.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CarsalesCC.Tests.Controllers
{
    public class CarsControllerTests
    {
        private MockRepository mockRepository;

        private Mock<ICarService> mockCarService;

        public CarsControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockCarService = this.mockRepository.Create<ICarService>();
        }

        private CarsController CreateCarsController()
        {
            return new CarsController(
                this.mockCarService.Object);
        }
        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            var initialCount = 0;
            // Arrange
            var carsController = this.CreateCarsController();

            CarGetResponseDto getResponse = new CarGetResponseDto() { Id = 1, Make = "Ford", Model = "Mustang 2020", VehicleType = "Car", Doors = 2, Engine = "1000cc", BodyType = "None", Wheels = 4 };
            List<CarGetResponseDto> getAllResponse = new List<CarGetResponseDto>();
            getAllResponse.Add(getResponse);
            this.mockCarService.Setup(i => i.GetAll())
                .Returns(getAllResponse);
           
            var result = carsController.Get();

            // Assert
            Assert.Equal(result.Count(), initialCount+1);
            this.mockCarService.Verify(i => i.GetAll(), Times.Once);
            this.mockRepository.VerifyAll();
        }
        [Fact]
        public async Task CreateCar_PassCarCreateRequest_Expected_Id_NotNull()
        {
            // Arrange
            var carsController = this.CreateCarsController();
            CarCreateRequestDto request = new CarCreateRequestDto() { make = "Ford", model = "Mustang 2020", vehicletype = "Car", doors = 2, engine = "1000cc", bodytype = "", wheels = 4 };
            CarCreateResponseDto response;
            this.mockCarService.Setup(i=>i.Create(request)).Returns(Task.FromResult(response=new CarCreateResponseDto() {Id=1,Vehicletype="Car" }));

            // Act
            var result = await carsController.CreateCar(
                request);

            // Assert
            Assert.NotNull(response);
            this.mockCarService.Verify(i => i.Create(request), Times.Once);
            this.mockRepository.VerifyAll();
        }
    }
}

using System.Threading;
using category.Application.Models;
using category.Application.Queries.Example;
using category.Application.Interfaces;
using Moq;
using Serilog;
using Xunit;

namespace category.Application.Tests.Queries.Example
{
    public class GetExampleByIdQueryHandlerTests
    {
        [Fact]
        public async void Request_With_No_Id_Should_Return_Invalid_Input()
        {
            // ARRANGE
            var validator = new GetExampleByIdQueryValidator();
            var exampleServiceClientMock = new Mock<IExampleServiceClient>();
            var mockLogger = new Mock<ILogger>();

            // ACT
            var handler = new GetExampleByIdQueryHandler(
                mockLogger.Object,
                exampleServiceClientMock.Object,
                validator
            );
            var response = await handler.Handle(new GetExampleByIdQuery(), new CancellationToken());

            // ASSERT
            Assert.Equal(QueryResultTypeEnum.InvalidInput, response.Type);
        }

        [Fact]
        public async void Should_Call_GetExampleById_In_Repository()
        {
            // ARRANGE
            var validator = new GetExampleByIdQueryValidator();
            var exampleServiceClientMock = new Mock<IExampleServiceClient>();
            var mockLogger = new Mock<ILogger>();

            exampleServiceClientMock.Setup(x => x.GetExampleById(It.IsAny<int>()))
                .ReturnsAsync(new Domain.Models.Example());

            var handler = new GetExampleByIdQueryHandler(
                mockLogger.Object,
                exampleServiceClientMock.Object,
                validator
            );

            // ACT
            var response = await handler.Handle(new GetExampleByIdQuery() { Id = 1 }, new CancellationToken());

            // ASSERT
            Assert.Equal(QueryResultTypeEnum.Success, response.Type);
            exampleServiceClientMock.Verify(x => x.GetExampleById(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public async void Should_Return_Not_Found_If_No_Example()
        {
            // ARRANGE
            var validator = new GetExampleByIdQueryValidator();
            var exampleServiceClientMock = new Mock<IExampleServiceClient>();
            var mockLogger = new Mock<ILogger>();

            var handler = new GetExampleByIdQueryHandler(
                mockLogger.Object,
                exampleServiceClientMock.Object,
                validator
            );

            // ACT
            var response = await handler.Handle(new GetExampleByIdQuery() { Id = 1 }, new CancellationToken());

            // ASSERT
            Assert.Equal(QueryResultTypeEnum.NotFound, response.Type);
            exampleServiceClientMock.Verify(x => x.GetExampleById(It.IsAny<int>()), Times.Once);
        }
    }
}
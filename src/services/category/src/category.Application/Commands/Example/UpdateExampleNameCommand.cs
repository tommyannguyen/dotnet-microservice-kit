using category.Application.Models;
using MediatR;

namespace category.Application.Commands.Example
{
    public class UpdateExampleNameCommand : IRequest<CommandResult<bool>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
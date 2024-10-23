using category.Application.Models;
using category.Domain.Models;
using MediatR;

namespace category.Application.Queries.Example
{
    public class GetExampleByIdQuery : IRequest<QueryResult<Domain.Models.Example>>
    {
        public int Id { get; set; }
    }
}
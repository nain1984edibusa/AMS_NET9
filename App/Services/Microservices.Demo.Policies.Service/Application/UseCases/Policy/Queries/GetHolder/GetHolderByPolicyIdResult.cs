using Microservices.Demo.Messages.Services.Policies.Dtos;
using Microservices.SharedKernel.Application.UseCases.Interfaces;

namespace Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetHolder
{
    public class GetHolderByPolicyIdResult : PersonDto, IQueryResult { }
}

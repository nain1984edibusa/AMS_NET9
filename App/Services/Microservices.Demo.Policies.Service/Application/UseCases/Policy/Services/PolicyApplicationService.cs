using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Commands.CreatePolicy;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Commands.TerminatePolicy;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Interfaces;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetPolicyDetailsByNumber;
using Microservices.SharedKernel.Application.UseCases.Interfaces;

namespace Microservices.Demo.Policies.Service.Application.UseCases.Policy.Services
{
    public class PolicyApplicationService: IPolicyApplicationService
    {
        public IQueryUseCase<GetPolicyDetailsByNumberQuery, GetPolicyDetailsByNumberResult> GetPolicyDetailsByNumber { get; }
        public ICommandUseCase<CreatePolicyCommand, CreatePolicyResult> CreatePolicy { get; }
        public ICommandUseCase<TerminatePolicyCommand, TerminatePolicyResult> TerminatePolicy { get; }

        public PolicyApplicationService(
            IQueryUseCase<GetPolicyDetailsByNumberQuery, GetPolicyDetailsByNumberResult> getPolicyDetailsByNumber,
            ICommandUseCase<CreatePolicyCommand, CreatePolicyResult> createPolicy,
            ICommandUseCase<TerminatePolicyCommand, TerminatePolicyResult> terminatePolicy
        )
        {
            GetPolicyDetailsByNumber = getPolicyDetailsByNumber;
            CreatePolicy = createPolicy;
            TerminatePolicy = terminatePolicy;
        }        
    }
}

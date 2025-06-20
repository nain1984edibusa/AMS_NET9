using AutoMapper;
using Microservices.Demo.Policies.Service.Framework.Rest.Models.Dtos;
using Microservices.Demo.Policies.Service.Framework.Rest.Models.Requests;
using Microservices.Demo.Policies.Service.Framework.Rest.Models.Responses;

using PersonRestDto = Microservices.Demo.Policies.Service.Framework.Rest.Models.Dtos.PersonDto;
using AddressRestDto = Microservices.Demo.Policies.Service.Framework.Rest.Models.Dtos.AddressDto;

using PersonAppDto = Microservices.Demo.Policies.Service.Application.UseCases.Policy.Dtos.PersonDto;
using AddressAppDto = Microservices.Demo.Policies.Service.Application.UseCases.Policy.Dtos.AddressDto;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Commands.TerminatePolicy;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Commands.CreatePolicy;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Dtos;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetPolicyDetailsByNumber;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetAllPolicies;

namespace Microservices.Demo.Products.Service.Framework.Rest.Mappings
{
    public class PolicyRestProfile : Profile
    {
        public PolicyRestProfile()
        {
            CreateMap<GetAllPoliciesRequest, GetAllPoliciesQuery>();
            CreateMap<GetPolicyDetailsByNumberRequest, GetPolicyDetailsByNumberQuery>();
            CreateMap<PolicyDto, GetPolicyDetailsByNumberResponse>();

            CreateMap<CreatePolicyRequest, CreatePolicyCommand>();
            CreateMap<PersonRestDto, PersonAppDto>();
            CreateMap<AddressRestDto, AddressAppDto>();
            CreateMap<PolicyDto, CreatePolicyResponse>();

            CreateMap<TerminatePolicyRequest, TerminatePolicyCommand>();
            CreateMap<TerminatePolicyResult, TerminatePolicyResponse>();
        }
    }
}

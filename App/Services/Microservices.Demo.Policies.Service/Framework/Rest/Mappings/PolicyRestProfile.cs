using AutoMapper;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Commands.CreatePolicy;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Commands.TerminatePolicy;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Dtos;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetAllPolicies;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetHolder;
using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetPolicyDetailsByNumber;
using Microservices.Demo.Policies.Service.Domain.Policies.Entities;
using Microservices.Demo.Policies.Service.Framework.Rest.Models.Dtos;
using Microservices.Demo.Policies.Service.Framework.Rest.Models.Requests;
using Microservices.Demo.Policies.Service.Framework.Rest.Models.Responses;
using AddressAppDto = Microservices.Demo.Policies.Service.Application.UseCases.Policy.Dtos.AddressDto;
using AddressRestDto = Microservices.Demo.Policies.Service.Framework.Rest.Models.Dtos.AddressDto;
using PersonAppDto = Microservices.Demo.Policies.Service.Application.UseCases.Policy.Dtos.PersonDto;
using PersonRestDto = Microservices.Demo.Policies.Service.Framework.Rest.Models.Dtos.PersonDto;

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

            CreateMap<GetHolderByPolicyIdRequest, GetHolderByPolicyIdQuery>();



            // ⚠️ ESTE ES CLAVE PARA EVITAR LA EXCEPCIÓN
            CreateMap<PolicyVersionDto, GetHolderByPolicyIdResponse>();

            CreateMap<GetHolderByPolicyIdResult, GetHolderByPolicyIdResponse>()
                .IncludeBase<PolicyVersionDto, GetHolderByPolicyIdResponse>();


        }
    }
}

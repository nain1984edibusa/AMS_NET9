using Microservices.Demo.Policies.Service.Framework.Rest.Handlers;

namespace Microservices.Demo.Policies.Service.Framework.Rest.Endpoints
{
    public static class PoliciesEndpoints
    {
        public static void MapPoliciesEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/policies").WithTags("Policies");

            group.MapGet("/{policyNumber:guid}", PoliciesHandlers.GetPolicyDetailsByNumberAsync);
            group.MapPost("/", PoliciesHandlers.CreatePolicyAsync);
            group.MapDelete("/terminate", PoliciesHandlers.TerminatePolicyAsync);
        }
    }
}

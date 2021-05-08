
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AuthorizationHandlerMultipleInvocations.Models
{
    public class CustomRequirementAuthorizationHandler : AuthorizationHandler<CustomRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomRequirement requirement)
        {
            // Put a breakpoint here
            // This gets called twice.
            // First time with a context.Resource of type Microsoft.AspNetCore.Http.DefaultHttpContext
            // Second time with a context.Resource of type Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.AuthorizationFilterContextSealed
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
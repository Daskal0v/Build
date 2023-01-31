namespace Build.Web.Services;

using System.Threading.Tasks;
using Build.Web.Protos;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;

[Authorize]
public class UserService : UserServiceGrpc.UserServiceGrpcBase
{
    [AllowAnonymous]
    public override Task<CreateUserResponse> CreateUser (CreateUserRequest request, ServerCallContext context)
    {
        return base.CreateUser(request, context);
    }

    public override Task<GetUserResponse> GetUser (GetUserRequest request, ServerCallContext context)
    {
        return base.GetUser(request, context);
    }

    public override Task<UpdateUserResponse> UpdateUser (UpdateUserRequest request, ServerCallContext context)
    {
        return base.UpdateUser(request, context);
    }

    public override Task<DeactivateUserResponse> DeactivateUser (DeactivateUserRequest request, ServerCallContext context)
    {
        return base.DeactivateUser(request, context);
    }

}

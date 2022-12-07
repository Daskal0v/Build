namespace Build.Web.Services;

using System.Threading.Tasks;
using Build.Web.Protos;
using Grpc.Core;

public class ProjectService : ProjectServiceGrpc.ProjectServiceGrpcBase
{
    public override Task<CreateProjectResponse> CreateProject (CreateProjectRequest request, ServerCallContext context)
    {
        return base.CreateProject(request, context);
    }

    public override Task<GetProjectResponse> GetProject (GetProjectRequest request, ServerCallContext context)
    {
        return base.GetProject(request, context);
    }

    public override Task<ListProjectsResponse> ListProjects (ListProjectsRequest request, ServerCallContext context)
    {
        return base.ListProjects(request, context);
    }

    public override Task<UpdateProjectResponse> UpdateProject (UpdateProjectRequest request, ServerCallContext context)
    {
        return base.UpdateProject(request, context);
    }

    public override Task<DeleteProjectResponse> DeleteProject (DeleteProjectRequest request, ServerCallContext context)
    {
        return base.DeleteProject(request, context);
    }
}

﻿using DevFreela.Application.DTOs.ViewModels.Project;
using DevFreela.Application.Repositories;
using MediatR;

namespace DevFreela.Application.Features.Queries.ProjectQueries.GetProject;

public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, ProjectDetailsViewModel?>
{
    private readonly IProjectRepository _projectRepository;

    public GetProjectQueryHandler(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<ProjectDetailsViewModel?> Handle(GetProjectQuery request, CancellationToken cancellationToken)
    {
        var project = await _projectRepository.GetWithDetailsAsync(request.Id);

        if (project is null) return null;

        return new ProjectDetailsViewModel(
            project.Id,
            project.Title,
            project.TotalCost,
            project.Description,
            project.StartedAt,
            project.FinishedAt,
            project.CancelledAt,
            project.Status,
            project.Client!.FullName,
            project.Freelancer!.FullName);
    }
}

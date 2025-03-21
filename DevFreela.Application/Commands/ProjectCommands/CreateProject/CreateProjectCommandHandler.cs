﻿using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.ProjectCommands.CreateProject;

public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
{
    private readonly IProjectRepository _projectRepository;

    public CreateProjectCommandHandler(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
        var project = new Project(request.Title, request.Description, request.IdClient, request.IdFreelancer, request.TotalCost);

        await _projectRepository.CreateAsync(project);
        await _projectRepository.CommitAsync();

        return project.Id;
    }
}

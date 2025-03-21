﻿using DevFreela.Application.InputModels.Project;
using DevFreela.Application.ViewModels.Project;

namespace DevFreela.Application.Services.Interfaces;

public interface IProjectService
{
    List<ProjectViewModel> GetAll(string query);
    ProjectDetailsViewModel? GetById(int id);
    int Create(CreateProjectInputModel inputModel);
    void Update(UpdateProjectInputModel inputModel);
    void Delete(int id);
    void CreateComment(CreateCommentInputModel inputModel);
    void Start(int id);
    void Finish(int id);
}

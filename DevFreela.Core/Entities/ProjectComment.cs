﻿namespace DevFreela.Core.Entities;

public class ProjectComment : BaseEntity
{
    public string Content { get; private set; }
    public int IdProject { get; private set; }
    public Project? Project { get; }
    public int IdUser { get; private set; }
    public User? User { get; }
    public DateTime CreatedAt { get; private set; }

    public ProjectComment(string content, int idProject, int idUser)
    {
        Content = content;
        IdProject = idProject;
        IdUser = idUser;

        CreatedAt = DateTime.Now;
    }
}
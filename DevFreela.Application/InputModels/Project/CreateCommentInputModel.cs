﻿namespace DevFreela.Application.InputModels.Project;

public class CreateCommentInputModel
{
    public string Content { get; set; }
    public int IdProject { get; set; }
    public int IdUser { get; set; }
}

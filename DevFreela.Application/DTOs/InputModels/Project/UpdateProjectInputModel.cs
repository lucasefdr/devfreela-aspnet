﻿namespace DevFreela.Application.DTOs.InputModels.Project;

public class UpdateProjectInputModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal TotalCost { get; set; }
}

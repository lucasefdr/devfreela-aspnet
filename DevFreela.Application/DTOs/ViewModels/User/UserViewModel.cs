﻿namespace DevFreela.Application.DTOs.ViewModels.User;

public record UserViewModel(int Id, string FullName, string Email, string IsActive, IReadOnlyCollection<string> Skills);
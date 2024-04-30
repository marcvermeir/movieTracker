﻿
namespace TT.Api.Models;

public class TodoItemDto
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }
}
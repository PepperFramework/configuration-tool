﻿using System.ComponentModel.DataAnnotations;

namespace ConfigurationTool.Model;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = String.Empty;

    public List<Answer> Answers { get; set; } = new();
}
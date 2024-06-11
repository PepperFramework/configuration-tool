﻿namespace ConfigurationTool.Model;

public class Assistant
{
    public int Id { get; set; }
    public int ConfigUserId { get; set; }
    public int ConfigUser { get; set; }
    public string Name { get; set; }
    public string BackgroundImage { get; set; }
    public string Language { get; set; }
    public double TalkingSpeed { get; set; }
    public string GreetingMessage { get; set; }
    public bool State { get; set; }
    public bool IsExpanded { get; set; }
}
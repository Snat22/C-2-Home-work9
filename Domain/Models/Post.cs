﻿namespace Domain;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }    
    public int VoteAmount { get; set; }
    public DateTime CreatedAt { get; set; }
}

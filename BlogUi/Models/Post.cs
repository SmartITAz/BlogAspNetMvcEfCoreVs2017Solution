//Copyright 2017 (c) SmartIT. All rights reserved.
//By John Kocer
// This file is for Swagger test, this application does not use this file

namespace BlogUi.Models
{
  public class Post
  {
    public int Id { get; set; }
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public Blog Blog { get; set; }
  }
}

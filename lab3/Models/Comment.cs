using System;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Comment
    {
      public int Id { get; set; }

      [Required]
      public string Text { get; set; }

      [Required]
      public bool Important { get; set; }

      public Movie Movie { get; set; }

      public int MovieId { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab3.Models
{
	public class Movie
	{
		[JsonConverter(typeof(JsonStringEnumConverter))]
		public enum GenreType
		{
			Action, Comedy, Horror, Thriller
		}

		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required, MinLength(10)]
		public string Description { get; set; }

		[Required]
		public GenreType Genre { get; set; }

		[Required]
		public float DurationMinutes { get; set; }

		[Required]
		public int ReleaseYear { get; set; }

		[Required]
		public string Director { get; set; }

		[Required]
		public DateTime AddedAt { get; set; }

		public int? Rating { get; set; }

		public bool Watched { get; set; } = false;

	  public List<Comment> Comments { get; set; }
	}
}

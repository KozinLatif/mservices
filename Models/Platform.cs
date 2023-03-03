using System;
using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
	public class Platform
	{
		[Key]
		[Required]
		public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Publisher { get; set; }
        [Required]
        public string? Cost { get; set; }

        public Platform()
        {
        }

        public Platform(int id, string name, string publisher, string cost)
        {
            Id = id;
            Name = name;
            Publisher = publisher;
            Cost = cost;
        }
    }
}
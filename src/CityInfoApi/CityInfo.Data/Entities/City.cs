﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.DAL.Entities
{
	public class City : IEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; }

		[MaxLength(200)]
		public string Description { get; set; }

		public virtual ICollection<PointOfInterest> PointsOfInterest { get; set; } = new List<PointOfInterest>();
	}
}

using System.ComponentModel.DataAnnotations;

namespace NGRU.ExpSite.Models.Entities
{
	public class EntityBasedClass
	{
		[Key]
		public long Id { get; set; }
	}
}
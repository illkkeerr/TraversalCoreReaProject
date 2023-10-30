using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Testimonial
	{
		[Key]
		public int TestimonialId { get; set; }
		public int Client { get; set; }
		public int Comment { get; set; }
		public int ClientImage { get; set; }
		public int Status { get; set; }
	}
}

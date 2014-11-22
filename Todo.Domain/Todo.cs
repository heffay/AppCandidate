using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain {
	public class Todo {

		public int Id { get; set; }
		public string Title { get; set; }
		public User User { get; set; }
		public DateTime Created { get; set; }
		public bool Completed { get; set; }

		public Todo() {
			Created = DateTime.Now;
		}
	}
}

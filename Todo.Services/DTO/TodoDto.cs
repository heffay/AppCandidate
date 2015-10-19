using System;

namespace Todo.Services.DTO {
	public class TodoDto {

		public int TodoId { get; set; }
		public string Title { get; set; }
		public string UserName { get; set; }
		public DateTime Created { get; set; }
	}
}

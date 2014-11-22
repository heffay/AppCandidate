using System.Collections.Generic;
using Todo.Domain;

namespace Todo.Data {
	public interface ITodoRepository {
		IList<Domain.Todo> GetAllTodos();
	}
}
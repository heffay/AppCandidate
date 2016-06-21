using System.Collections.Generic;

namespace Todo.Data {
	public interface ITodoRepository {
		IList<Domain.Todo> GetAllTodos();
	}
}
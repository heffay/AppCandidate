using System;
using System.Linq;
using Todo.Data;
using Todo.Services.DTO;

namespace Todo.Services {
	public class TodoService : ITodoService{

		private ITodoRepository _todoRepo;

		public TodoService(ITodoRepository todoRepo) {
			_todoRepo = todoRepo;
		}

		public TodoDto[] GetTodosNotCompletedForUser(int userId) {
			var allTodos = _todoRepo.GetAllTodos();
			throw new System.NotImplementedException();
		}

		public TodoDto[] GetTodosNewerThan(int numberOfDaysOld) {
			var allTodos = _todoRepo.GetAllTodos();
			throw new System.NotImplementedException();
		}
	}
}
﻿using Todo.Data;
using Todo.Services.DTO;

namespace Todo.Services {
	public class TodoService : ITodoService{

		private ITodoRepository _todoRepo;
	    LogginService _loggingService;

	    public TodoService(ITodoRepository todoRepo) {
			_todoRepo = todoRepo;
		    _loggingService = new LogginService();
		}

		public TodoDto[] GetTodosNotCompletedForUser(int userId) {			
			throw new System.NotImplementedException();
		}

		public TodoDto[] GetTodosNewerThan(int numberOfDaysOld) {
			throw new System.NotImplementedException();
		}
	}
}
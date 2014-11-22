using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Services.DTO;

namespace Todo.Services {
	public interface ITodoService {
		TodoDto[] GetTodosNotCompletedForUser(int userId);
		TodoDto[] GetTodosNewerThan(int numberOfDaysOld);
	}
}

using Todo.Services.DTO;

namespace Todo.Services {
	public interface ITodoService {
		TodoDto[] GetTodosNotCompletedForUser(int userId);
		TodoDto[] GetTodosNewerThan(int numberOfDaysOld);
	}
}

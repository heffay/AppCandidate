using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Todo.Data;
using Todo.Domain;
using Todo.Services;

namespace Todo.Tests {

	[TestClass]
	public class TodoServiceTestFixture {

		private ITodoService _sut;
		private Mock<ITodoRepository> _todoRepo;

		[TestInitialize]
		public void Setup() {
			_todoRepo = new Mock<ITodoRepository>();
			_todoRepo.Setup(e => e.GetAllTodos()).Returns(GetFakeTodos());

			_sut = new TodoService(_todoRepo.Object);
		}

		[TestMethod]
		public void GetTodosNotCompletedForUser_Returns_The_Correct_Number_Of_Dtos() {

			// Results for Mary
			var result1 = _sut.GetTodosNotCompletedForUser(71);
			// Results for John
			var result2 = _sut.GetTodosNotCompletedForUser(77);

			Assert.AreEqual(1, result1.Length);
			Assert.AreEqual(2, result2.Length);

			Assert.IsTrue(result1.Any(e=> e.Title == "Pay the bills"));
			Assert.IsTrue(result2.Any(e=> e.Title == "Mow the lawn"));
		}


		[TestMethod]
		public void GetTodosNewerThan_Retuns_Expected_Number_Of_Results() {

			var result = _sut.GetTodosNewerThan(5);

			Assert.AreEqual(2, result.Length);
			Assert.IsTrue(result.Any(e=> e.Title == "Mow the lawn"));
		}


		private Domain.Todo[] GetFakeTodos() {
			var mary = new User { Id = 71, Name = "Mary" };
			var john = new User { Id = 77, Name = "John" };

			return new[] {
			    new Domain.Todo{ Id = 1, Title = "Get the milk", User = john, Created = DateTime.Now.AddDays(-1)},
			    new Domain.Todo{ Id = 2, Title = "Mow the lawn", User = john, Created = DateTime.Now.AddDays(-1)},
			    new Domain.Todo{ Id = 3, Title = "Wash the car", User = john, Created = DateTime.Now.AddDays(-8), Completed = true},
			    new Domain.Todo{ Id = 4, Title = "Pay the bills", User = mary, Created = DateTime.Now.AddDays(-8)},
			    new Domain.Todo{ Id = 5, Title = "Give the dog a bath", User = mary, Created = DateTime.Now.AddDays(-10), Completed = true}
	       };
		}
	}
}
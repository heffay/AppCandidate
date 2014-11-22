Aescentia applicant solution
=========

This code repository contains a *very* simple VS 2012 .NET solution that is purposefully not complete. The goal is to make changes to the code base in order to have passing unit tests and some basic refactorings. For simplicity, this solution does not contain a database. For this exercise, please create some fake data in the data/repository layer (similar to what is used for fake data in the TodoServiceTestFixture class).

If you are not able to complete all of the requirements, that is fine. This is a level setting exersize. 

Required tools
-----
  - Visual Studio 2012 (minimum)
  - Nuget ( you may need to enable package restore on the solution)
  - ASP.NET MVC4
  

Rules
-----
- Please complete in 24 hours
- You may use any internet resource to do research
- Only one brain. Please don't use somebody else to complete

Minimum Requirements
--------------
- The entire solution should sucessfully compile
- 100% passing tests in the Todo.Tests project. 
- Add unit tests for any code added to the project that is not already covered
- The solution is intentionally not complete with failing unit tests. Your job is to figure out what is missing and implement the best solution to complete the stories below

Stories
-------
- Without modifying the unit test code, make the necessary changes to ensure that all of the unit tests pass
- The index page of the application should display all users todo's that are newer than 30 days old. 
    - You'll need to setup the proper references to the projects
    - The list should contain the Todo Title and who it belongs to (the user's name)
    - Please incorporate the IoC (inversion of control) principal when developing the web project. You may import a Nuget package to help you accomplish this.
- Develop a web page that allows a user to enter a UserId into a text box and click a submit button. The page should then display the non-completed Todo's for the UserId entered.
- Implement a service method to enable a user to mark a Todo item as complete (update the Completed bool on the Todo class)
    - This does not need to persist the data to a database, update an internal collection of fake data in the repository layer
    - Add a unit test that covers this behavior
    - A page is not necessary, the service methods and the unit test will suffice

Bonus
-----
- Refactor the application to use a generic repository
- Implement web integration tests

#### When complete, please zip the solution files up and email to the contact that sent you the link to this project ####

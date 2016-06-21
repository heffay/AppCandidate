Aescentia applicant solution
=========

This code repository contains a *very* simple VS 2012 .NET solution that is purposefully not complete. The goal is to make changes to the code base in order to have passing unit tests and complete some refactoring that promotes best practices. For simplicity, this solution does not contain a database. For this exercise, please create some fake data in the data/repository layer (similar to what is used for fake data in the TodoServiceTestFixture class).

If you are not able to complete all of the requirements, that is fine. This is a level setting exercise. 

Required tools
-----
  - Visual Studio 2012 (minimum)
  - Nuget ( you may need to enable package restore on the solution)
  - ASP.NET MVC4
  

Rules
-----
- Please complete as much as you can in 24 hours from receiving the notice
- You may use any internet resource to do research
- Only one brain. Please don't use somebody else to complete. You will be asked about the results
- Complete as much as you can. If you get stuck, just move onto the next requirement
	- Depending on the position the candidate is applying for, some stories may be considered more advanced and that will be taken into consideration. Just do your best

Minimum Requirements
--------------
- The entire solution should successfully compile
- 100% passing tests in the Todo.Tests project. 
- Add unit tests for any code added to the project that is not already covered
- The solution is intentionally not complete with failing unit tests. Your job is to figure out what is missing and implement the best solution to complete the stories below
- The solution is intentionally not following the SOLID principles. You need to determine where these principles can be applied and refactor the code accordingly.

Stories
-------
- Without modifying the unit test code, make the necessary changes to ensure that all of the unit tests pass
- The index page of the application should display all users todo's that are newer than 30 days old. 
    - You'll need to setup the proper references to the projects
    - The list should contain the Todo Title and who it belongs to (the user's name)
    - This list should be grouped by user then by create date
    - Please incorporate the IoC (inversion of control) principal when developing the web project. You may import a Nuget package to help you accomplish this.
- Develop a web page that allows a user to select a user from a drop down list and click a submit button. The page should then display the non-completed Todo's for the UserId entered.
    - This page should be able to be called in an asynchronous fashion, and have only the needed UI components update accordingly.
    - The page should be able to support displaying appropriate error and success messages that could occur from creating an asynchronous work flow.
- Implement a service method to enable a user to mark a Todo item as complete (update the Completed bool on the Todo class)
    - This does not need to persist the data to a database, update an internal collection of fake data in the repository layer
    - Add a unit test that covers this behavior
    - A page is not necessary, the service methods and the unit test will suffice.
- Add the ability to log messages within the application. Modify the included LoggingService and ensure logging is performed at the correct level of the application based on the intent of the type of logging being performed (Error, Warn, Info, Debug).
    - The output location of the loggingService should be dynamic and not specific to the file system (ie. could be azure, local db, file system).
- Add the appropriate unit tests in the solutions to cover the logging behaviors used within the code

Bonus
-----
- Refactor the application to use a generic repository
- Implement web integration tests
- Implement on the search results page the ability to mark a task as complete.


#### When complete, please zip the solution files up and email to the contact that sent you the link to this project. If issues encountered sending any .exe files rename the zip with a .txt extension ####

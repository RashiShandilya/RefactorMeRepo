EXERCISE: The code in this Project is operational, but it is completed to a very poor standard. Your company's Quality Control
arm would like you to refactor the code to the company's stringent quality standards.

Explanation:
A client's business sells lawnmowers, phone cases and t-shirts. Their database is a mess but you have access to their various
product listings. The goal is to consolidate all of the client's products into a single list so that they can be sorted and
displayed on the client's website.

You must provide access to all of the same information, but you can change the functions as much as you like.

Your company values the following coding standards:
 - Maintainability
 - Readability
 - DRY (Don't Repeat Yourself)
 - SOLID design principles

 Please pay special attention to SOLID design principles. Research the concept well before starting, as it's weighted heavily
 in our evaluation criteria. Refactor this project to the best of your ability. You can write whatever extra classes that may
 be necessary to tidy up. Please also provide evidence that you have tested that your changes all work correctly.

 If you are invited to an interview, you may be asked to explain in depth how you refactored this project and why.



 ###############################################################################################################################################



 SOLVED EXERCISE:

 Explaination:

 - Implement SOLID desing principle like Open-closed principle, Interface Inversion principle, Repository design pattern and make the code loosly coupled and Maintainable
 - Implement Unity Dependency Injection in class name - ProductData
 - Improve the list items into single list and provide sorting on each column of grid using AngularJS. Please go to Index.html page, run it at Exproler from Visual Studio
 - Refactor the code at class - ProductDataConsolidator and remove the duplicate code of calculating currency amount, Intead, I calculate the currency amount(NZD,USD,Euro) at javascript file - productCtrl.js
 - Write one UNIT TEST to check the behaviour of functions that calling of service and test it should not resturn null data
 - I merged the front end library(front-end-test-v2) with the backend library(refactorme-be-v2) and named the front end library like RefactorMe.Web in the Solution Explorer window of Visual Studio
 
ASP.NET Core Complete Guide


1) Dependencies:- contains the posrt number.
2) wwwroot:- contains static files, we you this when we are adding any css, js or any other libraries. It will be the  root folder of your application.
appsettings.json:- We add all of the connection string and secerets of our application


3) .NET Core Pipeline
Request from browser to the server  via various middlewares(Auth, MVC, Static Files)


4) Model
Represents shape of the  data


5) View
Represents the user interface

5.1) Shared
It is used for partial views. It is  basically a view you can call within a view in multiple places in your application.

5.1.1)_Layout
It is  a special partial view which is the  default master page of your application

5.2) _ViewImport
If you want to access some namespaces everywhere inside your application you will add them in _ViewImport

5.2.1)Tag Helper
	-They are introduced with .NET Core.
	-They enables server-side code to participate in creating and rendering HTLML elements in Razor files.	
	-They are very much focused on HTML element and much more natural to use.


5.3) _ViewStart
This will define the default masterpage inside your application


6) Controllers
Handles the  user request and acts as an interface between Model and View



								User Click
							Request || Response
						Model	    Controller	   View
 						||	    ||    ||	   ||
  						Get Data	   Get Presentation



7) Route
What ever after the  port number  will be the route we use to load a page.
The URL pattern for routing is considered after the domain name.
-[(for example:- https://localhost:5590/home/Index) /home/Index is the route here
		     https://localhost:5590/{controller}/{action}/{Id}]
Id is  an optional feild Controller and action are compulsory. If action and controller are not defined index as action and homecontroller as  controller are taken by default.

8)Return Types

8.1)Action Result
	-It is a result of action methods/ pages or retun type of action methods/ pages handlers.
	-It is a parent class of many derived classes that have associated helpers.
	-The IActionResult return type is appropriate when multiple ActionResult return types are possible in an action.
*Use IAction result as a parent so that if you are returning/ using multiple action results it will work perfectly.

8.1.1) Action Result in Razor Pages
	- ContentResult:- Takes Sting and return it with plain text.
	- FileContentResult:- Return a file from byte array, stream or virtual path.
	- NotFoundResult:- Return a Http 404 (Not Found) status.
	- PageResult:- Will process andd return the resullt of current page.
	- PartialRsult:- Return a partial result.
	- RedirectToPageResult:- Redirect user to specific page.
	- ViewComponentResult:- Return the result of executing ViewComponent.

8.1.2) Action Result in MVC
	- ViewResult:- Renders view as a WebPage.
	- PartialViewResult:- Renders a partial view. which means a section of view can be rendered into another view.
	- RedirectResult:- redirect to another action method using it's URL.
	- RedirectToRouteResult:- Redirect to another action menthod.
	- ContentResult:- Return a user defined content type.
	- JsonResult:- Return a serilized JSON object.
	- JavaScriptResult:- Return a script that can be executed on the client.
	- FileResult:- Return binary output to write to the response.
	- EmptyResult:- Repersents a return value that is used if the action method must return a null result(void).

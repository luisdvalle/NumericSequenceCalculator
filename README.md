# NumericSequenceCalculator
As a USER I want to enter a number and initiate the calculation of various numeric sequences so that I can view the results

## Background

Although the implementation to get the sequence of numbers is straightforward, I wanted to build my solution based in the structure commonly find in modern Web Applications. The components that are part of this solution are:

* Client WebApp: an Asp.Net Core 2.0 MVC applications with all the views and necessary controllers to display sequences according to an input number as well as the necessary logic to consume the Web API that will process the input number and return the sequences
* Web API: an Asp.Net Core 2.0 WebAPI application with the endpoint to get the input number and generate the sequences needed and returning the results in JSON format.
* Auth Server: an Asp.Net Core 2.0 application that protects the Web API the IdentityServer4 package and the 'Client Credentials' flow. To simplify this solution, the user of the Client WebApp doesn't need to register and login in order to use the application and process input numbers but the necessary logic has been put in place in order to implement the Grant Type Client Credentials in order to protect the API endpoint and allow only this Client WebApp to consume it. If the API endpoint is called from the browser (e.g. http://localhost:5001/api/sequences?number=20) the browser will get a 401 (unauthorised access) response.
* Three libraries: using .Net Core Standard to provide abstractions, models and services to this solution
* Test Project: using .Net Core 2.0 providing the necessary unit tests for the service that will process the input number and generate the sequences

## To run this solution

<ul>
<li>For this three projects in this solution: AuthServer, WebApi and WebApp projects, select the following profiles to be used when running the projects (this will avoid that the web browser is run when running AuthServer and WebApi - this profile can be selected in the Toolbar underneath the menu in VS):
  <ul>
    <li>AuthServer -> Profile: LuisDelValle.Calculator.AuthServer (Not IIS Express) - <strong>Change port to http://localhost:5000/</strong></li>
    <li>WebApi -> Profile: LuisDelValle.Calculator.WebApi (Not IIS Express) - <strong>change port to http://localhost:5001/</strong></li>
    <li>WebApp -> Profile: IIS Express</li>
  </ul>
</li>
<li>Open the properties of this solution (right click on solution in the Solution Explorer and select 'Properties'). In 'Start Project' section, select 'Multiple startup projects' and select 'Start' action for AuthServer, WebApi and WebApp projects</li>
</ul>

## Acceptance Criteria

<ul>
  <li>Input shall accept positive, whole numbers only.</li>
  <li>Where an input is invalid an error message shall be displayed.</li>
  <li>
    Upon entering the input they system shall display the following four numeric sequences:
    <ol>
      <li>All numbers up to and including the number entered</li>
      <li>All odd numbers up to and including the number entered</li>
      <li>All even numbers up to and including the number entered</li>
      <li>
        All numbers up to and including the number entered
        <ul>
          <li>except when a number is a multiple of 3 output C,</li>
          <li>and when a number is a multiple of 5 output E,</li>
          <li>and when a number is a multiple of both 3 and 5 output Z</li>
        </ul>
      </li>
    </ol>
  </li>
</ul>
 
 
 






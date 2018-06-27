AngularWebApp

# MongoDB:

* Steps to install MongoDB Community Server on MacOS:
https://docs.mongodb.com/manual/tutorial/install-mongodb-on-os-x/?_ga=2.228035741.144025711.1529372460-1183798152.1529372460&_gac=1.162137934.1529372460.CjwKCAjwsJ3ZBRBJEiwAtuvtlIyLnH0B0X5aCalZ-vgw7WyM1mwcff6RZP1z4Puk2wIVXil2hMMFthoCB1EQAvD_BwE

* Standard js documentation: https://docs.mongodb.com/manual/reference/method/js-collection/

* A simple tutorial on how to use MongoDB (Not necessarily to be in our case):
http://www.dotnetcurry.com/aspnet-mvc/1267/using-mongodb-nosql-database-with-aspnet-webapi-core

* To add mongoDB driver, there is an offical drive we can use add executing this line:
dotnet add package MongoDB.Driver --version 2.6.1

* Another good and simple mongoDB c# CRUD example can be found here: http://selfdocumenting.net/a-quick-mongodb-repository/

# Docker
* Docker tutorial: https://docs.docker.com/get-started/

* Good examples for docker with microservices (There are also many other projects that using docker and angular there): https://github.com/DanWahlin/Angular-NodeJS-MongoDB-CustomersService

* “Containerizing” Angular with Docker 
    - Dan Wahlin: https://www.youtube.com/watch?v=cLT7eUWKZpg
    - Tutorial found that did similarly to above video (Good to have some step by step explanation): https://medium.com/@tiangolo/angular-in-docker-with-nginx-supporting-environments-built-with-multi-stage-docker-builds-bb9f1724e984

* Docker Documentation about how to containerize a ASP.NET Core application: https://docs.docker.com/engine/examples/dotnetcore/
 - One thing learned from the process is that Dockerfile should be better at root folder level if just to containerize a single application since you can't specify parent directory within the Dockerfile.

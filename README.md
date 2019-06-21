# TestYoubim
These are the instructions for the project setup.
Requirements: 
NodeJs 10+.
Angular CLI.
SQLServer database.

# Frontend
Navigate to the Frontend folder and run 

> npm install

When the dependencies are installed and the node_modules folder is created, you can run :
> ng serve

to start a test server.



# Backend

Create your database and modify the connection string in appsettings.json, then run:
> Update-Database

to run the migrations and update your database schema.

## Test the application

You can register, log in, and the CRUD in the Nodes section.

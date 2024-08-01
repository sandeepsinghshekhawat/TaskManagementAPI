# Task Manager Application

This project has two parts - Front End and Back End and this is Beackend part.
To run the Task Manager Application you need to run the backend application first.


## Steps to Execute

### Update Connection String in appsettings.json

```
"ConnectionStrings": {
    "DefaultConnection": "Server=LAPTOP-EA6HGDNF;Database=TasksDb;Trusted_Connection=True;TrustServerCertificate=True"
  },
```

To

```
"ConnectionStrings": {
    "DefaultConnection": "Server={Your_Server_Name};Database=TasksDb;Trusted_Connection=True;TrustServerCertificate=True"
  },
```

### Update/Create Database & Scripts

In the project directory, you can run:
```
dotnet ef migrations add InitialCreate

dotnet ef database update
```

### Run the Project

Press the F5, you will see the swagger screen as below:





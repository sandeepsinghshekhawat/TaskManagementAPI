# Task Manager Application

This project has two parts - Front End and Back End and this is Beackend part.
To run the Task Manager Application you need to run the backend application first.


## Steps to Execute Project

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

![image](https://github.com/user-attachments/assets/06298b4e-230c-484a-ac3e-241f541b1c25)


## Steps to Run XUnit Test Project

Open package manager console and run following command

```
dotnet test
```

![image](https://github.com/user-attachments/assets/6e641497-27c5-4fd6-94b3-6e0eb786bb26)


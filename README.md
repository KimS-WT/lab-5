## Your Name:


# CIDM 3312 Lab 5: EF Core Relationships 1

You are starting a new movie streaming service. You must ink a contract with two large movie studioes before you can go live. Create a proof of concept app using EF Core that can store information about movies and the movie studios.

Complete the following tasks:

Development tip: Don't forget your `using` directives.

Development tip: Delete the database and then create it fresh each time by placing `db.Database.EnsureDeleted();` right before `db.Database.EnsureCreated();`.
```
db.Database.EnsureDeleted();
db.Database.EnsureCreated();
```

## Task 0: Prep your project
Clone this repository and create a new EF Core app within Visual Studio Code:

```
dotnet new console
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Task 1
Implement the following Entity Relationship Diagram (ERD) in a new EF Core app. 
![Image of ERD](https://i.imgur.com/LdbMBC7.png)
Remember,
  1. Place your entity classes and dbContext class in a `Models/` folder.
  2. Add two `DBSet<>` properties to the dbContext class - one for each entity class.
  3. Add the NAVIGATION PROPERTIES specific to EF Core that are not included on the ERD.
  
## Task 2
Add the studio "20th Century Fox" with the following movies:
1. Avatar Genre: Action
2. Deadpool Genre: Action
3. Apollo 13 Genre: Drama
4. The Martian Genre: Sci-Fi

## Task 3
Add the studio "Universal Pictures" with no movies.

## Task 4
Add a new movie "Jurassic Park" (Genre. Action) to the Universal Pictures studio.

## Task 5
Remove the movie Deadpool

## Task 6
List all studios and their movies.

## Submit your assignment
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Edit `README.md` and put your name at the top.
3. Push your changes to GitHub:
    - Click the source control icon in VS Code
    - Type in a commit message
    - Click the checkbox icon to commit. (Click yes on the message box to stage your commit)
    - Click the 3 dots icon (...) for more actions and click Push.
4. Or you can push your changes to GitHub using the Terminal:
    ```
    git add -A
    git commit -m "Ready for grading"
    git push
    git status
    ```
4. Verify that your changes are on GitHub.
6. Congratulations! Your lab 5 assignment is complete. 

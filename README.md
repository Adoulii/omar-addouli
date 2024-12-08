# omar-addouli

Part 1 :
has a code solution for our palindrome problem

Part 2 :

- For handling our task system, we used the OOP Concept for better code decoupling and making our app scalable we defined a Task Class that handles the different class properties of a Task(title,...);
- We separate the task category and task status making them enumrable class ( for managing these properties later if we want to add a new property or new status of a task) now each task has a TaskCategory property and Status property
-  Moving to our system Architecture, we used the Repostory Pattern for handling the CRUD Operations of our system making these operations ready to use by any class in our system and making is less decoupled by using the UnitOfWork design pattern which handles the db connection ad a time by this solution we minimise the db call each time in our app, where we inject oud DbContext. We inject these serviec into our app in Program.cs file wehre we used AddScoped for handling only one request each time of a specific class

TASK 1:
2024-02-15 (Thrusday) (1400)
We were given our topic "Drawers" on which we need to create an application. Then we three as a group has done
some research about the topic to find certain entities that are suitable for the topic.We have decided our 
project name as "InfiniteDraws Creation"We found a list of entities from which we have discussed and selected 
Types, Drawer Material, Color, Price, Rating and Reviews. Then we created just a sample project with title and
ran the code. It was successfully executed with welcome page.
 
TASK 2: Add a Controller
2024-02-18 (Sunday) (1502)

HelloWorldController is the name we will give to the controllers that we are going to add to the project as part of this job. 
With the help of his laptop, Sharath initiated the project, and Shreyas and Parvindor are serving as his navigators thus far. 
After that, we were able to modify the welcome method in the HelloWordControoler, and then we moved on to the subsequent procedure. 

TASK 3: Add a view
2024-02-18 (Sunday) (1530)

The index method of the HelloWorldController was modified during this task. 
The next step is to add the views, and in order to do so, we first create a new folder and give it the name HelloWorld. 
After that, we add the new item with the name Index.cshtml to the folder that contains the HelloWorld folder. 
After completing this step, we are able to get the necessary result. 
Subsequently, we modify the layout file in views/shared by modifying the title, footer, and menu link. 
This is done in order to show the privacy policy on the output website. Finally, we modify the index.cshtml file. 
Following that, we added a new item to the views/HelloWorld folder, where it was given the name welcome.cshtml.

TASK 4: Add a Model
2024-02-18 (Sunday) (1630)

During this task, we added a class to the models folder that was called Drawer.cs. 
We also updated the code for adding the drawer type, material, price, rating, and reviews. 
After that, we added the NuGet packages by adding the new scaffolded item to the controller drawer controller.cs file. 
Finally, we went to the NuGet package manager> package manager console and added the migration initialCreate. 
After we have created and updated the database, we will test the application, and after we have obtained the necessary result 
from the automatic code that was generated during the migration process, we will examine each codes.
>Initial Migration
I Opened the Package Manager Console (PMC) from Tools > NuGet Package Manager > Package Manager Console.
Run the app.

TASK 5: Work with a Database
2024-02-18 (Sunday) (1700)

In this task, we began by examining the database using the SQL Server Object Explorer. 
This allowed us to get the table that we had constructed in the previous stage, which had information 
about the drawer types, material, price, rating, and reviews. And then we built a new class and gave it the name SeedData in the models folder. 
After that, we examined and altered a few things in order to include information about drawers on the output webpage. 
Finally, we adjusted the program.cs file, and the result was that we were able to get the desired output. 

TASK 6: Controller actions and views
2024-02-18 (Sunday) (1800)

During this Task, we reviewed the Drawer.cs file that was located in the models folder. 
After that, we checked the output to ensure that we were able to successfully modify the information associated with the drawers. 
Additionally, we made sure that we were able to edit the information from the output website.

TASK 7: Add search
2024-02-20 (Tuesday) (1402)

The index method that can be found inside the controllers>MovieController was modified as part of this task. 
These modifications will result in the creation of a LINQ query that will choose the movies that possess the searchstring. 
After that, we modified the index file in order to include the filler in the output webpage. 
Following that, we added the DrawerTypeViewModel class to the Models folder. 
This class will include a list of drawers, as well as a Selectlist that includes the list of types and the searchstring. 
Finally, we updated the Index method in the DrawersController.cs file, as well as the Index.cshtml file that can be found in the Views>Movies folder.  

Task 8
# Add a new field to an ASP.NET Core MVC app
2024-02-20 (1500)
=> In this section, it focuses on enhancing the MVC Movie App by incorporating a new field,
'Rating', using Entity Framework Code First Migrations. This process involves adding the field to the model,
updating the database schema, and ensuring synchronization between the model and the database.

Task 9
# Add validation to an ASP.NET Core MVC app
2024-02-20 (1530)
=> It demonstrates the seamless integration of validation rules into the UI. 
Both client-side and server-side validation are automatically enforced. 
The user receives immediate feedback through error messages when attempting to submit invalid data.

KEY LEARNING:
We worked on single system because when we cloned the repository, the other system was unable to run the code,
giving us https error. We able to find out the solution in the end. 
We have to login to the common github while cloning the repository, and after that, migration will be executed on each system to run the code.







# Anababi

Welcome to Anababi Library Management System. This application is designed to streamline the management of your library's resources with a user-friendly interface and a robust set of features. Whether you're a librarian looking to efficiently catalog and organize your collection or a reader searching for books and references, this application has you covered. Here are some of the key features that make this app stand out:

- **Database Storage:** All your library data is securely stored in a database, ensuring reliability and easy access.

- **Modern UI:** The application boasts a sleek and intuitive user interface developed with C#'s Winform, making navigation and interaction a breeze.

- **Powerful Search:** Find books and authors quickly with both linear and binary searching algorithms.

- **Flexible Sorting:** Sort your library by book title, author, or publication date using bubble sort, selection sort, and insertion sort algorithms.

- **Scalability:** With a well-structured codebase, you can effortlessly expand and enhance the application in the future.

- **Administrator Control:** Admins have the authority to add, modify, and remove references through the user-friendly interface.

- **User Authentication:** A simple login page ensures secure access to the application.

- **Detailed Reference Information:** Each reference is equipped with essential details such as title, author(s), publication date, and ISBN number.

- **Physical and Digital Resources:** Easily manage both physical and digital references within the library.

- **Location Tracking:** Quickly locate physical references within your library.

- **Digital File Viewing:** Seamlessly view digital files directly from the application.

This Library Management System is a versatile solution designed to cater to the needs of both librarians and readers, simplifying the management and accessibility of your library's resources. Dive into the documentation to get started, and feel free to contribute or customize the app according to your requirements.

## Limitations of this software

- The actual files of the digital references are not included. It was surprisingly difficult to store PDF files on a database and display them on the app. We intend to resolve it soon enough.
- The form window is not resizable. Certain UI components would ruin the user experience if the window was resizable. We intend to resolve it soon enough.

## Collaborators

1. **Finhas Yohannes, ZD0728**
2. **Yanet Abrham, PM9785**
3. **Zelalem Amare, NV3369**

## What you need to install first

1. [Visual Studio](https://visualstudio.microsoft.com/downloads/) (2019 or greater).
2. [Microsoft SQL Server Management Studio](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (19 or greater).

## Steps for running it

1. Clone this repository with Visual Studio.
    
   ![image](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/b2f623d8-1fdf-46c4-9eae-abc826e7462a)

    
3. Navigate to the repository’s directory on your machine and run this command on your preferred CLI:
    
    ```bash
    dotnet restore
    ```
    
4. Go to `Tools` >> `NuGet Package Manager` >> `Manage NuGet Packages for Solution` and check to see if the following packages are installed on your solution.

    1. `Guna.UI2.WinForms`
    2. `Microsoft.EntityFrameworkCore.Design`
    3. `Microsoft.EntityFrameworkCore.SqlServer`
    4. `Microsoft.EntityFrameworkCore.Tools`
    5. `PdfiumViewer`
6. Go to `Tools` >> `NuGet Package Manager` >> `Package Manager Console` and run the following commands to initialize the database with Entity Framework Core.

    _This creates a migration file for initializing the database structure and all the relationships between the entities._
    ```bash
    Add-Migration InitialCreate
    ```

    _This actually creates the database on your localhost._
    ```bash
    Update-Database
    ```
    
7. Open the project with Visual Studio and `Debug` >> `Start Debugging` (F5).

   
   ![image](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/5be2f01e-0c00-4a3a-a022-90cdfad72131)



8. Login to the app as an admin.

    **Username = "abebe123"**
    
    **Password = "password123"**

9. Login to the app as a normal user.
    
    **Username = "sara123"**

    **Password = "letmein"**


### Steps to traverse the references with a linked list

1. Login with one of the credentials listed above.
3. Click `Linked References` on the navigational panel.

   ![Linked References](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/0e6b8bff-b3ca-4c05-8f2c-34f31b317e01)

5. To go to the next reference in the linked list, click `Next`.

   ![Next](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/032fd0e1-fab9-4001-8ab5-c82812c73f96)

7. To go to the previous reference in the linked list, click `Previous`.

   ![Previous](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/6e9e16fe-3dd3-4fa5-b402-4c52dc9417dc)

9. To remove a reference in the linked list, click `Remove`. This functionality is only available for admin users.

    ![Remove](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/0dc15543-7aa1-42fa-b075-9ad5f921cc2f)

11. To add a reference to the linked list, click `Add a reference` on the navigational panel, fill in the properties and save. This functionality is only available for admin users.

    ![Add a Reference](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/971d6ceb-baf6-4adc-85e1-996e0cad93c1)


> Bye... for now.
> 
> -Collaborators
     

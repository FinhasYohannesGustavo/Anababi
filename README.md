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

## What you need to install first

1. [Visual Studio](https://visualstudio.microsoft.com/downloads/) (2019 or greater).
2. [Microsoft SQL Server Management Studio](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (19 or greater).

## Steps for running it

1. Clone this repository with Visual Studio.
    
   ![image](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/544d398b-4445-4205-930e-05f256a1322d)

    
3. Navigate to the repository’s directory on your machine and run this command on your preferred CLI:
    
    ```bash
    dotnet restore
    ```
    
4. Go to `Tools` >> `NuGet Package Manager` >> `Manage NuGet Packages for Solution` and check to see if the following packages are installed on your solution.
    1. `Bunifu.UI.WinForms`
    2. `DrakeUI.Framework`
    3. `Guna.Charts.WinForms`
    4. `Guna.UI2.WinForms`
    5. `Microsoft.EntityFrameworkCore.Design`
    6. `Microsoft.EntityFrameworkCore.SqlServer`
    7. `Microsoft.EntityFrameworkCore.Tools`
    8. `PdfiumViewer`
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
   
   ![image](https://github.com/FinhasYohannesGustavo/Anababi/assets/96903785/9013ae6e-5bcb-4a4b-a370-5fd4b0b3b115)

### How to test sorting functionality

1. Navigate to the top of the app where you find the search button and click the drop down menu with the sorting icon next to it.

    ![Untitled](https://github.com/FinhasYohannesGustavo/Anababi/assets/89961977/a072bab8-1f3d-4552-ac18-65bb69e1b75f)
    
2. Choose either `Published Date`, `Author`, `Title` to tell the App on which property of the references it should sort the references with.
3. Navigate to each category to view the sorted references with the criteria that you have set.
4. The pages, which include `My Feed` and `Top References` will now be sorted with the sorting criteria that you have selected.

### How to test searching functionality

1. Navigate to the top of the app click the search button on the top right corner.
2. After Clicking on the search button you will have the option to search using binary or linear search.

    ![Untitled](https://github.com/FinhasYohannesGustavo/Anababi/assets/89961977/9d0dc310-f4d1-41b0-8289-99890fd4c6f8)

    
3. Click on the toggle switch to choose searching algorithm you want.
    
    ![Untitled](https://github.com/FinhasYohannesGustavo/Anababi/assets/89961977/c77ce072-b756-41aa-bff6-9e4751023674)

    
4. The only difference between the two types of searching is that `binary searching` only works on already `sorted data`.
5. To search by title you have to first sort by Title.
6. To search by Author you have to first sort by Author.

    1. Note if you do search by Author make sure to either search the first name only or the last name only.
    2. This is because a reference only has a first name or last name property and not a full name property.
        
       ![Untitled](https://github.com/FinhasYohannesGustavo/Anababi/assets/89961977/2dd59134-a93a-4a3d-9d9a-0dca281c5066)

        
7. Lastly to search by published data you have to first sort by Published date.

<aside>
📌 The searches must be exactly what is found on the references properties to be found as a result of the search.

</aside>
     

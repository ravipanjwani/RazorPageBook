RazorPagesBook Assignment to create Database of Books working with seedData.

Author: Ravi Panjwani
Date Created: 01.Mar.2022

Columns created: 1.ID, 2.Title, 3. Author, 4. Language, 5. Price.

Commands used:

GETTING STARTED:
dotnet new webapp -o RazorPagesBook  //Creating webapp for Books database
code -r RazorPagesBook      //Jump to root directory of webapp
dotnet dev-certs https --trust   //Trust the HTTPS development certificate 
dotnet run  //Run the webapp in browser

ADDING A MODEL:
Create folder Models and Book model in the folder.


dotnet tool install --global dotnet-ef  //install tool entity FRAMEWORK
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*	//intial creation of DATABASE
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

dotnet-aspnet-codegenerator razorpage -m Book -dc RazorPagesBookContext -udl -outDir Pages/Books --referenceScriptLibraries -sqlite

dotnet ef migrations add InitialCreate
dotnet ef database update



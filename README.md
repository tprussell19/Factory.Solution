# _Dr. Sillystringz's Factory_

#### _An app to manage engineers and machines in a factory_

#### By _Thomas Russell_

## Technologies Used

- _C#_
- _ASP.NET Core_
- _Razor_
- _MySQL_
- _Entity_
- _EF Core_
- _CSS_
- _Bootstrap_
- _Markdown_

## Description

_This is a C#/ASP.NET Core application that allows a factory manager to keep track of their engineers and their machines as well as which engineers are licensed to repair certain machines. It is an MVC application that allows the user to add, edit, delete, and view the details of both the engineers and the machines. It also allows the user to add licensed engineers to a machine and/or machines to an engineer._

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A browser like Chrome or Firefox
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

### Installation

1. Clone the repository: `$ git clone https://github.com/tprussell19/Factory.Solution`
2. Navigate to the `Factory.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base
4. Create a database using SQL via Entity:
   - Navigate to `Factory.Solution/Factory` in your command line
   - Create a file named `appsettings.json` and paste the following code:
     ```
     {
        "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=thomas_russell;uid=root;pwd=[YOUR-PASSWORD-GOES-HERE];"
        }
     }
     ```
     Note: Be sure to change `[YOUR-PASSWORD-GOES-HERE]` to your actual MySQL password.
   - Run the command `dotnet ef migrations add Initial`. (If this command throws and error, you might have to run the command `dotnet tool install --global dotnet-ef` first.)
   - Once the migration has been added, run the command `dotnet ef database update` to setup your database.
5. To run the app:
   - Navigate to `Factory.Solution/Factory` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
   - Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the app and launch
   - If the application does not automatically launch in your browser, you will need to open a browser window and navigate to "localhost:5000"

## Known Bugs

- _No known bugs_

## License

_MIT © Thomas Russell 2021_

## Contact Information

Thomas Russell _t.p.russell19@gmail.com_

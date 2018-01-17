# Cake Shop

A sample Cake Shop Website built with ASP.NET Core (Multi-Page Application)

## Features 
- Only Admin can perform Create/Edit/Delete cakes & manage Orders.
- Normal User can only can buy cakes & view their orders.
- Managing Cart System using cookie.
- Client Side & Server side validation

## Demo Link :
 Live Demo: (Soon)

## Framework / Library 
- ASP.NET Core 2.0 *(Backend)*
- Razor View *(For generating markup)*
- Entity Framework Core *(ORM)*
- ASP.NET Identity *(Cookie Based Athentication & Authorization - not session)*
- AutoMapper *(For mapping into Domain Model & DTO)*
- jQuery & Bootstap 4

## To run the project locally:
   > admin account : `EXAMPLE@EXAMPLE.COM` and Password: `Passw@rd!123` (You can change it from `DbInitializer.cs` file or using SSMS)

- **Using VS2017**
     ``` 
       > git clone https://github.com/ritwickdey/Cake-Shop.git
       > cd Cake-Shop/
    ```
    - Now Open the `CakeShop.sln` through `VS2017`.
    - Open `appsettings.json` & change the connection string. (But wait! you may not need to change it as this the default connection string of `SQL Server Express` that comes with `Visual Studio`).
    - Hit `Ctrl+Shift+B` to build.
    - Open `Package Manager Console` from `Tools` and enter `update-database`.
    - Hit `Ctrl+F5` to run without debugging.

- **Using CLI**
    ```
        > git clone https://github.com/ritwickdey/Cake-Shop.git
        > cd Cake-Shop/Cake-Shop/
        > npm install
        > dotnet restore
        > set ASPNETCORE_ENVIRONMENT=Development
        > set ConnectionStrings:DefaultConnection="<YOUR CONNECTION STRING>"
        > npm i webpack -g
        > webpack --config webpack.config.js
        > npm run build
        > dotnet build 
        > dotnet ef database update
        > dotnet run 
    ```

## Sceenshots
![screenshot1](./images/screenshot1.png)
![screenshot2](./images/screenshot2.png)
![screenshot3](./images/screenshot3.png)
![screenshot4](./images/screenshot4.png)
![screenshot5](./images/screenshot5.png)
![screenshot6](./images/screenshot6.png)

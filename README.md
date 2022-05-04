ASP.NET_CORE_6_REST_API_Shop_Example

How to create basic sets Rest Api for ASP.NET Core 6, with async responds?

1. Create new "Internetowy interfejs API platformy ASP.NET Core".

2. Add folders for Rest Architecture "", and install NuGet Pakets: Microsoft.EntityFrameworkCore.SqlServer; 
Microsoft.AspNetCore.Identity.EntityFrameworkCore; Microsoft.EntityFrameworkCore.Tools; Microsoft.EntityFrameworkCore.Design

3. Add new Class model in Models folder.

4. Create interface for Database Entity Context.

5. Create class with DBContext, and 3 data "products" examples.

6. Create interface with Product Service.

7. Add Service in services folder.

8. Add http Controller, in Controllers folder.

9. In Program.cs remove unnecessary route for "/weatherforecast", record, and summaries string Array. Next Add:

10. In appsettings.json add "ConnectionStrings", from Database Connection.

11. Create migration with command "Add-Migration Shop_Example_DBSet", in Pakete Menager, and Create Database do Model with command "Update-Database".

Done.
Now We can test ASP.NET Web API, with Postman, swagger, browser, etc.
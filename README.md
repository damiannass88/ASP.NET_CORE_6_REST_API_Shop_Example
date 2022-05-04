
ASP.NET_CORE_6_REST_API_Shop_Example

How to create basic sets Rest Api for ASP.NET Core 6, with async responds?

1. Create new "Internetowy interfejs API platformy ASP.NET Core".
 
![Screenshot - 04_05](https://user-images.githubusercontent.com/55595642/166802562-7225eab0-5124-4554-bbf2-199eebda681b.png)

2. Add folders for Rest Architecture "", and install NuGet Pakets: Microsoft.EntityFrameworkCore.SqlServer; 
Microsoft.AspNetCore.Identity.EntityFrameworkCore; Microsoft.EntityFrameworkCore.Tools; Microsoft.EntityFrameworkCore.Design

![Screenshot - 04_05 002](https://user-images.githubusercontent.com/55595642/166802849-27632ded-c508-4fa3-a034-1c35c48e526f.png)


3. Add new Class model in Models folder.

![Screenshot - 04_05 003](https://user-images.githubusercontent.com/55595642/166802879-8c127dcf-d732-4eee-b706-a03290dbe7ef.png)


4. Create interface for Database Entity Context.

![Screenshot - 04_05 004](https://user-images.githubusercontent.com/55595642/166802897-5982c1e5-c11b-41bb-b787-bbd4bab132ec.png)


5. Create class with DBContext, and 3 data "products" examples.

![Screenshot - 04_05 005](https://user-images.githubusercontent.com/55595642/166802908-153df7ba-66ce-4f90-ba3c-e47fff9c5bb7.png)


6. Create interface with Product Service.

![Screenshot - 04_05 006](https://user-images.githubusercontent.com/55595642/166802928-fc11ce84-413d-4c20-9e1c-87b78300372a.png)


7. Add Service in services folder.

![Screenshot - 04_05 007](https://user-images.githubusercontent.com/55595642/166802944-c74da961-6851-46c8-ba0b-febd07e0c88d.png)


8. Add http Controller, in Controllers folder.

![Screenshot - 04_05 009](https://user-images.githubusercontent.com/55595642/166802991-49608077-0c50-4f5d-b1a3-23a30d399bf7.png)


9. In Program.cs remove unnecessary route for "/weatherforecast", record, and summaries string Array. Next Add:

![Screenshot - 04_05 011](https://user-images.githubusercontent.com/55595642/166803028-ab2544ab-ffdd-4dba-8978-f938fdc1f1ed.png)
![Screenshot - 04_05 012](https://user-images.githubusercontent.com/55595642/166803039-70405708-2969-4553-a5e3-27a60313c6f0.png)

10. In appsettings.json add "ConnectionStrings", from Database Connection.

![Screenshot - 04_05 013](https://user-images.githubusercontent.com/55595642/166803073-981d9ddf-7c60-4375-a363-cb683342931c.png)

11. Create migration with command "Add-Migration Shop_Example_DBSet", in Pakete Menager, and Create Database do Model with command "Update-Database".

Done.
Now We can test ASP.NET Web API, with Postman, swagger, browser, etc.

![Screenshot - 04_05 014](https://user-images.githubusercontent.com/55595642/166804294-21d20dd3-fe98-4fa2-8c6d-dfcda241b23e.png)




Adwers.com Damian Nass

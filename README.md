# Sample_EntityFrameworkCore_DataFirstApproach

Create the context and entity classes for an existing database in Entity Framework Core. Creating entity & context classes for an existing database is called Database-First approach.

we need to do reverse engineering using the Scaffold-DbContext command. This reverse engineering command creates entity and context classes (by deriving DbContext) based on the schema of the existing database.

Install Below Package

Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer

Scaffold-DbContext Command
Use Scaffold-DbContext to create a model based on your existing database. The following parameters can be specified with Scaffold-DbContext in Package Manager Console:

Scaffold-DbContext [-Connection] [-Provider] [-OutputDir] [-Context] [-Schemas>] [-Tables>] 
                    [-DataAnnotations] [-Force] [-Project] [-StartupProject] [<CommonParameters>]

Scaffold-DbContext "Server=.\SQLExpress;Data Source=SAYANTANGHOSH;Initial Catalog=Sample_WebAPI;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
  
![image](https://github.com/sayantan2017/Sample_EntityFrameworkCore_DataFirstApproach/assets/26603086/fe409545-a4d6-4028-8357-95d66697f1a0)
  
You can re-scaffold the model by running the command that you originally ran with the -Force option added. That will result in the contents of the specified folder being over-written. Using the Package Manager Console example from the EF Core docs, the revised command becomes:

Alter table in the in Database Table and need to reflect this changes in Models class

Scaffold-DbContext "Server=.\SQLExpress;Data Source=SAYANTANGHOSH;Initial Catalog=Sample_WebAPI;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
  

Assignment-2

******************************
Date:25/10/2023  Time:1:43

Created project and readme files


******************************
Date:25/10/2023  Time:1:43


Change in startup file and remove the following code
options => options.SignIn.RequireConfirmedAccount = true


******************************
Date:25/10/2023  Time:1:46
Revirew the controller and Views



******************************
Date:25/10/2023  Time:1:58

Run the project working fine



******************************
Date:25/10/2023  Time:2:04

Downloaded bootstrap.css file
Theme name: Darkly

******************************
Date:25/10/2023  Time:2:11

Change the css code in site.css

******************************
Date:25/10/2023  Time:2:23

replace the bootstrap.css file with existing file
change file name to bootstrap in layout file


******************************
Date:25/10/2023  Time:2:25
change the nav bar class to bg-primary
remove text-dark
and properties on footer

******************************
Date:25/10/2023  Time:2:29

3rd party tools

 Added externeal style sheet iin layout file
 added js files to layout files

 ******************************
Date:25/10/2023  Time:3:07
added dropdwon in nav bar but not working



 ******************************
Date:25/10/2023  Time:3:31
Drop down menu working

 ******************************
Date:29/10/2023  Time:19:23

Added 3 project and pushed to github


 ******************************
Date:29/10/2023  Time:19:25
added data folder to dataaccess 

 ******************************
Date:29/10/2023  Time:19:29

Downloaded NuGet packes
deleted migration folder


 ******************************
Date:29/10/2023  Time:19:34

Downloaded packed
change namespace
deleted all class1.cs files


 ******************************
Date:29/10/2023  Time:19:45.

Moved models folder to class library
modifed error.cshtml file
added project refrences
rename  models  folders to viewmodels
change the namespace in error view model


 ******************************
Date:29/10/2023  Time:19:51

Remove using statement from startup file
using NiharsBookstore.Data;



 ******************************
Date:29/10/2023  Time:19:54

Changed the name space from default refrence to new refrences

 ******************************
Date:29/10/2023  Time:20:10

Added sd.cs file
added project refrense


 ******************************
Date:29/10/2023  Time:20:14

added new area
Change routes in startup.cs

 ******************************
Date:29/10/2023  Time:20:16

shifted home controller and deleted model and view
Edited homecontroller and  moved  Home folder in area


 ******************************
Date:29/10/2023  Time:20:27

Added admin area
added views files
deleted model controller folders


 ******************************
Date:30/10/2023  Time:17:38


Was having error
solved by spelling correction
Project was running fine



 ******************************
Date:2/11/2023  Time:19:00
Changed in appsetting.json file


 ******************************
Date:2/11/2023  Time:19:10

Added migration from nuget packet manager
add-migration AddDefaultIdentityMigration
follwings are files
20231102232811_AddDefaultIdentityMigration.cs
ApplicationDbContextModelSnapshot.cs

 ******************************
Date:2/11/2023  Time:19:16

Updated the database using follwing commands
update-database



 ******************************
Date:2/11/2023  Time:19:38

Added new class file called category.cs
added migration for category 
`add-migration AddCategoryToDb


 ******************************
Date:2/11/2023  Time:20:01
rerun the migration command and updated te database


 ******************************
Date:2/11/2023  Time:20:08

Adde 2 folder called repository
added interface in repository folder called it Irepository.cs


 ******************************
Date:2/11/2023  Time:20:15

Modified the IRepository.cs
Added object to reposity interface


 ******************************
Date:2/11/2023  Time:20:22
Added new class in repository
implemented new interfce in file
added provided code into repository



 ******************************
Date:3/11/2023  Time:17:42

Added new repos in Repository folder
Modified CategoryRepository file
Modified ICategoryRepository file




 ******************************
Date:3/11/2023  Time:20:38
added new repo
isp_call.cs
install Dapper nuget pakcet


 ******************************
Date:3/11/2023  Time:20:44
edited new repo file


 ******************************
Date:3/11/2023  Time:21:24
Added new connectionDb 
Updated the code 
Added wrapper of unit of work

added new repo
edited code in new repo file

edited startup.cs file


 ******************************
Date:5/11/2023  Time:12:52

Created Controller in Admin Area
Edited Code

 ******************************
Date:5/11/2023  Time:13:20


created new folder called Category in Views
Added Razor View
replace the code with the provided code
Changed code in layout file 
Run it works fine


 ******************************
Date:5/11/2023  Time:13:37

Modified index.cshtml
check for the buttons it works fine
commented out that piece of code
Added new js file in wwwroot folder
paste the provided code from blackboard in js file
link the script file in index.cshtml




 ******************************
Date:5/11/2023  Time:13:45
Added code in  category controller
created new partian views
named them _CreateAndBackToListButton
_EditAndBackToListButton
added code in bothe of the view


 ******************************
Date:5/11/2023  Time:14:00
Modifed upsert.cshtml
added new asp action  to upsert
Added section call to upseret.cshtml


 ******************************
Date:5/11/2023  Time:14:30
Added code in category controller

 ******************************
Date:5/11/2023  Time:15:00
Run the application and its working fine

******************************
Date:5/11/2023  Time:15:05
added delete function in categorycontroller
added delete button functionality in js file

******************************
Date:5/11/2023  Time:15:12
Added provided piecc of code for delete button 
run the application works fine
tried updating and deleting 
works fine
push to github


******************************
Date:16/11/2023  Time: 9:15

Created Covertype.cs file
Created Covertype repository class and interface and added it to the  unitofwork and iunitofwork

******************************
Date:16/11/2023  Time: 9:17
added migration using follwing command
Add-migration AddCoverTypeToDB
Migration file name: 20231117022051_AddCoverTypeToDB
20231117021646_AddCoverTypeToDB

updated the database
Check sql Server object explorer got the table

******************************
Date:16/11/2023  Time: 9:20
Added covertype in Nav bar

******************************
Date:16/11/2023  Time: 9:20
Added Covertype controller with add required method



******************************
Date:16/11/2023  Time: 9:38
Created new folder in Views named it as Covetype
added view in covertype named it as index
added view in covertype named it as upsert





******************************
Date:16/11/2023  Time: 10:00
Created new covertype.js file
linked that js file to the index file

******************************
Date:16/11/2023  Time: 4:33 pm
Added new class named it as product


******************************
Date:16/11/2023  Time: 4:39 pm
Added required code in product class and added new piece in applicationdb context


******************************
Date:16/11/2023  Time: 4:42 pm
added migration using follwing command
add-migration addProductToDb
Migration files: 20231117214228_addProductToDb

Updated the database
check in SQL server got the table


******************************
Date:16/11/2023  Time: 4:47 pm
added validation rules to product class

Added validationmigration using follwing command
add-migration addValidationToProduct
migration file: 20231117214841_addValidationToProduct

updated the database


******************************
Date:16/11/2023  Time: 5:05 pm
Added Product to repository
added IproductRepository to Irepository interface
Added Update method in product class
Added Product to unitofwork and Iunitofwork

******************************
Date:16/11/2023  Time: 5:16 pm

Added Product controller
added WebhostingEnvironment 

******************************
Date:16/11/2023  Time: 5:22 pm

added ProdcutVM  in ViewModel
install Microsoft.AspNetCore.Mvc.ViewFeatures packages

******************************
Date:16/11/2023  Time: 5:46 pm
Modified product controller , updated code in Iactionresult


******************************
Date:16/11/2023  Time: 6:02 pm

Added new index view
Added neccesory code to index view 
added new product.js file 
added product in nav bar 



******************************
Date:16/11/2023  Time: 6:18 pm
created Upsert.cs for products in view
added richtext box using tiny.cloud


# RoleBaseAuthApp

It contains a ASP.NET Core applications with extra code to implement feature or data authorization. All the ASP.NET Core applications use in-memory databases which are seeded on startup so it should run anywhere.

Here is a example of the first application, [TestWebApp](https://github.com/saifilali/RoleBaseAuthWebApp/tree/master/TestWebApp), that covers feature authorization.

![permission access](https://github.com/saifilali/RoleBaseAuthWebApp/blob/master/PermissionAccessControlHomePage.png)

## Feature authorization

Select the [TestWebApp](https://github.com/saifilali/RoleBaseAuthWebApp/tree/master/TestWebApp)
as your startup application. When you run it you will see a list of users that you can log in as.
Here are some comments on these:

- Staff@g1.com: 
   - This user can  read the data in the Color controller, but can't change it (you get a "Access denied" error)
   - This user has "bought" access to Feature1, so a "Feature1" link is added to the nav block when they log in.
- Manager@g1.com:
   - This user can  read and write the data in the Color controller.
   - This user hasn't "bought" access to Feature1, so no "Feature1" link appears for them (and they get an "Access denied" error if you try to access it).

## Data authorization

Select the [DataAuthWebApp](https://github.com/saifilali/RoleBaseAuthWebApp/tree/master/DataAuthWebApp)
as your startup application. When you run it you will see a list of users that you can log in as.
Here are some comments on these:

- Any user:
   - If you log in you can create some personal data via the "Personal Data" link in the nav block. That data is protected so only the user that created it can see it.  
_Remember - its a in-memory database so it loses anything you put in when you stop the application._
- Users D4u@g1.com, S4u@g1.com, T4u@g1.com, and Power@g1.com
   - These users can each access to the shops Dress4U, Shirt4U, Tie4U and DressPower respectively. You can list the shop's stock via the "Shop Stock" link in the nav bar.
- 4uMan@g1.com:
   - This user is a district manager for the three ...4U shops (but not the DressPower shop)
When that user list the stock via the "Shop Stock" link they get the stock of all three shops that they are a manager of. This shows how hierarchical access can be implemented.


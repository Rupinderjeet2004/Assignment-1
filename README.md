 "#Assignment-1" 
This Website Provide Computer Hardware Products to Customers. From this website customers can purchase various computer hardware parts like Rams, Motherboards, CPU coolers and many more. It has to options on nav bar one is for adding products and one for manufacturers.
Link to the website with working database.
https://assignmentasp120200223093150.azurewebsites.net/

"Assignment-2a"
1. Used Identity.sql script to create the necessary ASPNET Identity tables in database.
2.  
  a.) Configured Identity in Startup.cs.
  b.) Changed DbContext class so it inherits from IdentityDbContext.

3. Used Authentication 
    a.) Register and Login show when the user is anonymous. Done
    b.) Register and Login are replaced in the header by the username and Logout when the user is authenticated. Done 
    c.) Created an account with these credentials:
 	-> marie@gc.ca / Test123$
4. 
  a.) Only authenticated users can now add, edit and delete data.
  b.) Only anonymous users can view the list of data but cannot see the Create, Edit, or Delete links.
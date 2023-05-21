# Pierres-Vendors.Solution
#### This program is a C# web app. It uses two classes, "Vendor" and "Order." A user can add vendors to a running list, and update orders for each vendor in the list. Orders are further detailed by title, kind, price, and purchase date.  

#### By Thomas McDowell  

## Technologies Used:
* C#
* .NET 6.0
* MSTest

## Description:
A user should be able to tell how many vendors they've entered and, by clicking on each vendor, see what orders are associated with that vendor. Vendors are added by clicking on an appropriately titled link and filling out a form. Orders can then be added to those vendors by clicking on an additional link prompting to do so. Users should be able to navigate back to the home / splash page from any given view, and the vendor list should be retained if the user leaves the vendor view.  

## Setup/Installation Req's:
Follow these setup instructions: 

For C# and .NET => https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net  

For dotnet-script => https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script  

INSTRUCTIONS:  
1. Clone this repo.  
2. Open Terminal, GitBash, or a shell of your choice, and navigate to this project's production directory called "Pierres-Vendors".  
3. Run "dotnet watch run" (without quotes) in the command line and await the UI's instructions. A window of your browser should open onto a splash page welcoming "Pierre".  
4. Click on the links to navigate to areas where you can enter info about Vendors.  
5. Click on Vendor links in the "Vendor Directory" to create Orders.
6. Create Orders by clicking on a link asking if you want to make a new Order, and fill out the form on that page.
7. Orders can be viewed by clicking on a Vendor's link, and then clicking on an Order's link.
8. Close the program at any time by typing "ctrl + c" into your terminal.

## Known Bugs:
**update**
Fixed issue below by using the HTML date entry method. Was giving myself more work than necessary by making a DateTime and then re-converting it back into a string.

<!-- I had to do a bit of a dubious workaround to get the Date and Time to update properly. This involved making a new overloaded Order object that doesn't get added to the Orders list(s), but does let me run the PurchaseDate() function on it. I think this has something to do with the timing window of when an Order object is instantiated, and the scope of the PurchaseDate() function. I might have played it a little fast and loose with public/private/static. I'm not sure if I'm inadvertently making a bunch of "load-bearing potatoes." Otherwise, everything seems to be working fine. -->

## License:
(C) 2023 Thomas McDowell ; MIT

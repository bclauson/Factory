
# Branden Clauson Factory Management

### ***By Branden Clauson***
### A MVC project to manage a factories machines and engineers

<p>&nbsp<p>

## **Technologies used**

* C#
* .NET 5.0
* dotnet
* MySql
* MySql workbench

<p>&nbsp<p>

## **Description**

#### Program that manages and organizes a database of machines and engineers


<p>&nbsp<p>

## **Setup/Installation Requirements**
* Clone to folder
* Navagate to directory within your terminal
* Create appsettings.json file within the SalonTracker directory with the code:
 <code> 
 {
  
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=Branden_Clauson;uid=[User Id];pwd=[UserPassword];"
  }
}
</code>

* make sure to install <code> $ dotnet tool install --global dotnet-ef --version 5.0.1 </code>
* run <code> $ dotnet ef database update </code>
* Return to the directory in the terminal and input <code> dotnet run <code>


<p>&nbsp<p>

## **Known Bugs**

#### Stles.css not currently functional

## **License**

[MIT](LICENSE.txt)

Copyright (c) 2022 Branden Clauson

<p>&nbsp<p>
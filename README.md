# **Vendor and Order Tracker**
By _Olha Hizhytska_

## Description
An MVC web application to help user to track vendors and their orders.This application will include a splash page welcoming Pierre(user) and providing links to view the list of venders he has and a link with a form to add a new vendor.
When user click on a link of a specific vendor name it will display the page with a list of orders corresponding to a given vendor. If there are no orders, the user will be able to create a new order and check their details. Clicking on a Home back link it will bring the user to a Home page. 

![Image](Tracker/wwwroot/img/tracker.png)

This application demonstrates:

- Using MVC with Razor
- MVC Forms
- practising HTTP CRUD methods
- RESTful routing
- Test-Driven Development
- using objects whithin objects Interface
- using static content and layout

## Setup

#### To open this application:

- Clone this repository to your desktop, using next command:

  git clone https://github.com/OlgaHi/Vendor-Order-Tracker.Solution.git

- Navigate to the top level of the directory.

  cd Vendor-Order-Tracker.Solution

#### To run this application:

To run this application you need to install .NET Core. Please follow this steps:
 - Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
 - Open the file. Follow the installation steps.
 - Confirm the installation is successful by opening your terminal and running the command $ dotnet --version. You should see something like this in response: 5.0.100. This means .NET was successfully installed.
 - Navigate to the /Tracker folder 
 - Run the following command: dotnet build
 - Run the following command to execute this compiled code: dotnet run
 - In browser navigate to http://localhost:5000

## Run Tests

- Navigate to Bakery.Tests folder 
- To retrieve and install the packages run the command: dotnet restore
- Run the following command to run tests on all test methods: dotnet test 

## Technologies Used:

* C#
* .NET Core
* ASP.NET Core MVC
* HTTP
* RESTful
* Razor
* HTML
* CSS
* Bootstrap
* MSTest
* TDD

## Known Bugs

- No known issues

## License

[MIT](https://en.wikipedia.org/wiki/MIT_License)
Copyright (c) 2021 _Olha Hizhytska_

## Contact Information

- Olha Hizhytska olgainfotech@gmail.com

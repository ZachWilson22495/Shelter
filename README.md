# _Shelter_

#### By **Zach Wilson**

#### _A C# API that keeps track of all animals that can be found at a local animal shelter_

## Technologies Used

* HTML
* C#
* .NET
* Entity
* Sql

## Description

_An API built to house information in regards to all the wonderful animals available for adoption at your local animal shleter. By tapping into this API, you can view a list of animals and information about each potential pet such as their gender or breed. If you're more of a cat or dog person, you can also search by species to view only dogs or cats._

## Setup/Installation Requirements

* Clone this repository to your Desktop
* Download Postman
* Open 'Shelter' in your code editor
* Use your terminal to navigate to 'Shelter.Solution/Shelter' and create a file called 'appsettings.json'
* Fill your appsettings.json file with the code below:

{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=Shelter;uid=root;pwd=[YOUR PASSWORD];"
}
}

* Download MySQL and MySQL Workbench to set up a local database
* Once installed, open MySQL Workbench and open a local server

* Navigate to the project folder in VS code and access your terminal. Type 'dotnet ef database update' to create your database on MySQL

* Run 'dotnet restore' in your terminal to install bin & obj folders.

* Use your terminal to navigate back to 'Shelter.Solution/Shelter' and run 'dotnet run' to activate application.
* Use Postman to view and edit the API's list of animals.

## Endpoints

Base URL: https://localhost:5000/api

Example Query
https://localhost:5000/api/animals/4

Sample JSON Response
{
    "animalId": 4,
    "name": "Tater Tot",
    "species": "Dog",
    "breed": "Pomeranian",
    "age": 2,
    "sex": "Male"
}

## Path Parameters

Parameter	| Type | Default | Required |	Description
  Name	  |string|	none   |	 true   |	Return matches by name.
  species	|string|	none	 |   true	  | Return any animal who matches selected species.
  breed	  |string|	none	 |   true	  | Return animals of inputted breed.
  age     | int  |  none   |   true   | Return any animal who's age matches input
  sex	    |string|	none	 |   true	  | Return all animals of selected breed.

## Known Bugs

Currently no known bugs.

## License

MIT License

Copyright (c) [2021] [Zachary Wilson]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

### Feel free to fix/edit all contained code to your liking. If you encounter and problems, contact me at zwilson22495@gmail.com
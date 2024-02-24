<br>
<h1 align="center">
  <u><big><b>Park Lookup Api</b></big></u>
</h1>

<!-- Project Shields -->
<p align="center">
  <a href="https://img.shields.io/github/issues/tdietzel/ParkLookupAPI?style=plastic">
      <img src="https://img.shields.io/github/issues/tdietzel/ParkLookupAPI?style=plastic">
  </a>
  <a href="https://github.com/tdietzel/ParkLookupAPI/blob/main/LICENSE">
      <img src="https://img.shields.io/github/license/tdietzel/ParkLookupAPI?color=orange&style=plastic">
  </a>
</p>

<p align="center">
  <small>Initiated February 23rd, 2024</small>
</p>

<!-- Project Links -->
<p align="center">
  <a href="https://github.com/tdietzel/ParkLookupAPI/issues"><big>Report Bug</big></a> ·
  <a href="https://github.com/LunsfordSpace/ParkLookupAPI/issues"><big>Request Feature</big></a>
</p>

------------------------------

### Table of Contents
* [About the Project](#about-the-project)
    * [Description](#description)
    * [Known Bugs](#known-bugs)
    * [Built With](#built-with)
* [Getting Started](#getting-started)
    * [Prerequisites](#prerequisites)
    * [Setup and Use](#setup-and-use)
* [API Documentation](#api-documentation)
* [Auxiliary](#auxiliary)
    * [Contributors](#contributors)
    * [Contact and Support](#contact-and-support)
    * [License](#license)

------------------------------

## 🌐 About the Project
### 📖 Description

The Park Lookup API provides endpoints for managing and accessing information about national parks and state parks across different regions. This RESTful API allows users to perform various operations such as registering and authenticating users, retrieving information about national parks and state parks, adding new parks, updating existing park details, and deleting parks.

### Authentication

The API supports user authentication using JWT (JSON Web Tokens) for secure access to protected endpoints. Users can register for an account, sign in using their credentials, and sign out when done with their session. Tokens last for 60 minutes.


### 🦠 Known Bugs
* If any bugs are discovered, please contact the author.

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 6.0.0 for Windows](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Entity Framework Core Identity 6.0.0](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)
* [Swagger - NSwag 6.5.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

------------------------------

## 🏁 Getting Started
### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the following command in Terminal for macOS or PowerShell for Windows.
```
$ dotnet tool install -g dotnet-script
```

#### Install dotnet-ef
 Enter the following command in Terminal for macOS or PowerShell for Windows.
```
$ dotnet tool install --global dotnet-ef --version 6.0.0
```

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. A popular open-source choice for a code editor is VisualStudio Code.

  1) Code Editor Download:
    [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)
  
------------------------------

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [ParkLookup API repository here](https://github.com/tdietzel/ParkLookupAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/tdietzel/ParkLookupAPI`
  5) Run the command `cd ParkLookup` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [ParkLookup API repository here](https://github.com/tdietzel/ParkLookupAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the ParkLookupAPI/ParkLookup directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=YourServerName;database=YourDatabaseName;uid=YourUsername;pwd=YourPassword;"
    },
    "JwtSettings": {
    "ValidIssuer": "ParkLookup-audience",
    "ValidAudience": "ParkLookup-issuer",
    "SecretKey": "256_BIT_SECRET_REQUIRED"
    }
}
  ```
  3) Replace `YourServerName`, `YourDatabaseName`, `YourUsername`, and `YourPassword` with your actual MySQL Server instance details.
  4) Replace the ValidIssuer with the URL where your authentication server is hosted, and ValidAudience with the URL where your API server is hosted. For instance:
  ```
  "ValidIssuer": "https://localhost:7050",
  "ValidAudience": "http://localhost:5208",
  ```
  5) Make sure the `SecretKey` is atleast 16 characters long.
  
  #### Database
  1) Navigate to ParkLookupAPI/ParkLookup directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParkLookupAPI/ParkLookup`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to ParkLookupAPI/ParkLookup directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParkLookupAPI/ParkLookup`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the Park Lookup API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `https://localhost:7050/swagger/index.html`

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
##### Registration
* Open Postman and create a POST request using the URL: `https://localhost:7050/api/Accounts/register`
* Add the following query to the request as raw data in the Body tab:
```
{
  "email": "user@example.com",
  "userName": "string",
  "password": "string",
  "confirmPassword": "string"
}
```
* The password must contain at least `six characters`, `one non-alphanumeric character`, at least `one digit lowercase letter`, at least `one uppercase letter` and at least `two unique characters`.

##### Sign In
Now that you've registered an account with the API, you'll need to authenticate your account and generate the JSON Web Token. I'll be using Postman again for this example.

Let's setup another POST request using the URL: `https://localhost:7050/api/Accounts/signin`
* Add the following query to the request as raw data in the Body tab:
```
{
  "email": "user@example.com",
  "password": "string"
}
```
* Successfully logging in will generate a token in the response.

##### Using the JSON Web Token
Copy the token from the response, and add it as an authorization header to your POST, PUT or DELETE query. On the authorization 'Type', make sure that is set to 'Bearer Token', and then paste in the token in the field on the right.

### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

------------------------------

### Endpoints
Base URL: `https://localhost:7050`

#### HTTP Request Structure

|          |                     🏛️National                             |
|  :---:   |                      :---                                  |
| GET      | <a href="#get-nationalpark"> /national/park </a>           |
| POST     | <a href="#post-nationalpark"> /national/park </a>          |  
| PUT      | <a href="#put-nationalparkid"> /national/park/{id} </a>    |
| DELETE   | <a href="#delete-nationalparkid"> /national/park/{id} </a> |

|          |                    🏞️State                           |
|  :---:   |                      :---                            |
| GET      | <a href="#get-statepark"> /state/park </a>           |
| GET      | <a href="#get-stateid"> /state/{id} </a>             |
| POST     | <a href="#post-statepark"> /state/park </a>          |  
| PUT      | <a href="#put-stateparkid"> /state/park/{id} </a>    |
| DELETE   | <a href="#delete-stateparkid"> /state/park/{id} </a> |

|          |                     Accounts                               |
|  :---:   |                      :---                                  |
| POST     | <a href="#registration"> /api/accounts/register </a>       |  
| POST     | <a href="#sign-in"> /api/accounts/signin </a>              |
| POST     | <a href="#log-out"> /api/accounts/logout </a>              |

------------------------------
## 🏞️ State Parks
Access information on available State Parks.

------------------------------
### `GET` /state/park
Any user may access this `GET` endpoint of the API. This endpoint returns a list of available state parks in the database.

#### Example Query
`https://localhost:7050/state/park`

#### Sample Successful JSON Response
`Status: 200 OK`
```
{
    "stateId": 1,
    "name": "Alabama",
    "parks": [
        {
            "stateParkId": 2,
            "stateId": 1,
            "parkName": "Blue Springs"
        },
        {
            "stateParkId": 1,
            "stateId": 1,
            "parkName": "Bladon Springs"
        }
    ]
}
```

------------------------------

### `GET` /state/{id}
Any user may access this `GET` endpoint of the API. This endpoint returns a list of available state parks in the database according to the state id entered.

#### Example Query
`https://localhost:7050/state/1`

#### Sample Successful JSON Response
`Status: 200 OK`
```
[
    {
        "stateParkId": 4,
        "stateId": 3,
        "parkName": "Alamo Lake"
    }
]
```

------------------------------

### `POST` /state/park
Authenticated users, when including their Token in the authorization header of the request, may POST new state park entries to the database when using the following format:

#### Example Query
`https://localhost:7050/state/park`
#### Sample JSON Request Body
```
{
    "stateId": stateId,
    "parkName": "string"
}
```
> NOTE: When sending a `POST` request, there's no need to enter a stateParkId because its set up to be the auto incrementing primary key.
#### Sample Successful JSON Response
`Status: 201 Created`
```
{
    "stateParkId": AI PK,
    "stateId": stateId,
    "parkName": "string"
}
```

------------------------------

### `PUT` /state/park/{id}
Authenticated users, when including their Token in the authorization header of the request, may PUT state park entries already in the database when using the following format:

#### Example Query
`https://localhost:7050/state/park/{id}`
#### Sample JSON Request Body
```
{
  "stateParkId": parkId,
  "stateId": stateId,
  "parkName": "string"
}
```
#### Sample Successful JSON Response
`Status: 204 No Content`

------------------------------

### `DELETE` /state/park/{id}
Authenticated users, when including their Token in the authorization header of the request, may DELETE state park entries already in the database when using the following format:

#### Example Query
`https://localhost:7050/state/park/{id}`
> NOTE: When sending a `DELETE` request, the Park's ID in the query is the only thing _required_.
#### Sample Successful JSON Response
`Status: 204 No Content`

------------------------------
## 🏛️ National Parks
Access information on available National Parks.

------------------------------
### `GET` /national/park
Any user may access this `GET` endpoint of the API. This endpoint returns a list of available national parks in the database.

#### Example Query
`https://localhost:7050/national/park`

#### Sample Successful JSON Response
`Status: 200 OK`
```
{
"nationalId": 1,
"name": "National Parks Conservation Association",
"parks": [
  {
    "nationalParkId": 1,
    "nationalId": 1,
    "parkName": "Death Valley"
  },
  {
    "nationalParkId": 2,
    "nationalId": 1,
    "parkName": "Grand Canyon"
  }
]
}
```

------------------------------

### `POST` /national/park
Authenticated users, when including their Token in the authorization header of the request, may POST new national park entries to the database when using the following format:

#### Example Query
`https://localhost:7050/national/park`
#### Sample JSON Request Body
```
{
  "nationalId": 1,
  "parkName": "string"
}
```
> NOTE: When sending a `POST` request, there's no need to enter a nationalParkId because its set up to be the auto incrementing primary key.
#### Sample Successful JSON Response
`Status: 201 Created`
```
{
    "nationalParkId": 3,
    "nationalId": 1,
    "parkName": "string"
}
```

------------------------------

### `PUT` /national/park/{id}
Authenticated users, when including their Token in the authorization header of the request, may PUT national park entries already in the database when using the following format:

#### Example Query
`https://localhost:7050/national/park/{id}`
#### Sample JSON Request Body
```
{
  "nationalParkId": parkId,
  "nationalId": stateId,
  "parkName": "string"
}
```
#### Sample Successful JSON Response
`Status: 204 No Content`

------------------------------

### `DELETE` /state/park/{id}
Authenticated users, when including their Token in the authorization header of the request, may DELETE national park entries already in the database when using the following format:

#### Example Query
`https://localhost:7050/national/park/{id}`
> NOTE: When sending a `DELETE` request, the Park's ID in the query is the only thing _required_.
#### Sample Successful JSON Response
`Status: 204 No Content`

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Trent Dietzel](https://linkedin.com/in/trentdietzel) | [tdietzel](https://github.com/tdietzel) |  [dietzelbiz@outlook.com](mailto:dietzelbiz@outlook.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact **Trent Dietzel** at _dietzelbiz@outlook.com_.

<p>
    <a href="https://github.com/tdietzel/ParkLookupAPI/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/LunsfordSpace/ParkLookupAPI/issues"><big>Request Feature</big></a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2024 Trent Dietzel. All Rights Reserved.

```
MIT License

Copyright (c) 2024 Trent Dietzel.

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
```

<center><a href="#">Return to Top</a></center>

# School Data Importer

This is the project for importing School Data from Microsoft Access databases through ADO.

## Stack
This project contains references to the following packages.

### Serilog
A very simple yet powerful logging library with fully structured events.

### Microsoft Dependency Injection
Used to inject dependencies between classes instead of directly referencing objects.

### Meziantou.Framework.Win32.CredentialManager
Credential manager that shows the default Windows credentials prompt when connecting to databases. This works on Windows XP upwards.

### DeviceId
Used to calculate a unique identifier for the machine that is used to encode the passwords for databases. This allows storage of the passwords in an "encrypted" format that is only readable on the machine that created it.

## Debugging

To debug this project, make sure you are running Visual Studio 2017 or later and have the .NET Framework 4.6.1 SDK and Runtime installed.

In order to simulate the queries that are returned from a remote API, I've used `json-server`.

To install json-server, you need to have NodeJS and NPM installed.

Once installed, open PowerShell and install the json-server package:
```
npm install -g json-server
```
Once this package is installed, navigate to the `fake-api` directory and run the server:
```
json-server --watch db.json
```
This service will serve the JSON payload containing the current queries.

## Logging

This project makes use of `Serilog` to log to a rolling file which can be found at the executing assembly's path under a `Logs` directory.

I have also included metrics logging (duration for making calls) which can be seen when reading the logs.

To reduce the number of logs produced by the application, modify the app.config file and set the `serilog:minimum-level` value to `Information`.

## To-do list

- [X] Fetch remote queries from a server
- [X] Connect to a file-based Access database through ADO
- [X] Execute queries and read the results into memory
- [X] Map DB entity values to models in the API
- [X] Show the rows to the user to visualize data
- [X] Allow users to filter the data based on preset filters
- [X] Export results to clipboard
- [ ] Write unit tests 
- [X] Create an installer package
- [X] Test the installer on various versions of Windows that supports .NET Framework 4.6.1
  - Tested this on Windows 7 SP 1 and Windows 10 - all versions inbetween should work as expected, but had to download installer for .NET Framework 4.6.1 as it's not bundled with Windows 7
- [X] Test the application on each of the above Windows environments

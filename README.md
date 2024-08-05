## Introduction:
Using [Refit](https://github.com/reactiveui/refit) with an ASP.NET Core Minimal API lets you interact with Google Sheets simply and effectively, leveraging clean and maintainable code. This approach can be extended to other operations and integrated with additional services or custom logic within your application.
## API Endpoints:
- ```GET/sheets/{spreadsheetId}/{range}``` -> Get specified range of data.
- ```POST /sheets/{spreadsheetId}/{range}/append``` -> Appends data to the specified range.
- ```PUT /sheets/{spreadsheetId}/{range}/update``` -> Updates data in the specified range.
- ```DELETE /sheets/{spreadsheetId}/{range}/clear``` -> Clears data from the specified range.

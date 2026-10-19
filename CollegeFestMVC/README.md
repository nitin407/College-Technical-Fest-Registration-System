# CollegeFestMVC
Simple ASP.NET Core MVC project for CIE-1 College Technical Fest Registration.

## Run
1. Install .NET 8 SDK.
2. Open this folder in VS Code.
3. Open Terminal.
4. Run:
   dotnet restore
   dotnet run --urls "https://localhost:5001;http://localhost:5000"
5. Open http://localhost:5000/Fest/Welcome

Data is stored temporarily in a List<Participant>; it resets when the app restarts.

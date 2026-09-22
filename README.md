# EventEase - Blazor Event Management App

This project was developed with the assistance of **Microsoft Copilot**.

## Features

- **Event Card Component** with fields and two-way data binding
- **Routing** between Home, Events, Register and Attendance pages
- **Registration Form** with input validation (DataAnnotations)
- **State Management** for user sessions (`UserSessionService`)
- **Attendance Tracker** to manage event capacity and registrations
- Performance-oriented structure and error handling for routing

## How to Run

1. Make sure you have .NET 8 SDK installed
2. Open a terminal in this folder
3. Run: `dotnet restore`
4. Run: `dotnet run`
5. Open the URL shown in the terminal (usually https://localhost:5xxx)

## Project Structure

- `Components/` – Reusable UI components (EventCard, RegistrationForm, AttendanceTracker)
- `Pages/` – Routed pages
- `Services/` – State management and business logic
- `wwwroot/` – Static files (CSS, index.html)

EventsDemo
==========

A small .NET 10 console application demonstrating C# events, delegates, and event-driven design patterns using a simple employee separation scenario.

Contents
- Overview
- Features
- Prerequisites
- Build and run
- Project structure
- How it works
- Contributing
- License

Overview

EventsDemo illustrates how to declare, subscribe to, and raise events in C#. The sample models an employee separation workflow where components can react to an employee being separated (for example: logging, notifications, cleanup).

Features

- Example of defining and invoking events and delegates
- Decoupled subscriber implementations to demonstrate separation of concerns
- Small, easy-to-follow codebase suitable for learning and experimentation

Prerequisites

- .NET 10 SDK
- Visual Studio 2026 (recommended) or any editor that supports .NET 10

Build and run

From the solution directory:

- Open the solution in Visual Studio: EventsDemo.slnx and run the project
- Or use the CLI:
  - dotnet build
  - dotnet run --project EventsDemo

Project structure

- EventsDemo.slnx — Visual Studio solution file
- EventsDemo/ — main project (console application)
  - Program.cs — application entry point
  - EmployeeSeperator.cs — core example showing event declaration and raising
  - Other classes — subscribers, helpers, and supporting code

How it works

The sample defines an event that is raised when an employee is separated. Multiple subscriber classes register event handlers to receive the notification and perform actions such as logging or sending notifications. This demonstrates how to create loosely-coupled components using events and delegates.

Contributing

Contributions, improvements, and bug reports are welcome. Open a GitHub issue or submit a pull request on the repository.

License

This repository does not include a license file. Add a LICENSE if you plan to publish or share this project publicly.

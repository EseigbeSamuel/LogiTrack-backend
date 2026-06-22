# LogiTrack API - Project Memory

## Project Overview
LogiTrack is a modern backend API for a **Logistics and Fleet Management System**. It is designed to orchestrate the day-to-day operations of a company managing vehicles and drivers, such as a trucking or delivery service.

## Tech Stack
* **Framework**: .NET 10.0 (ASP.NET Core Web API)
* **Database**: PostgreSQL (using Entity Framework Core & Npgsql)
* **Authentication**: JWT Bearer Tokens

## Core Modules Architecture
The application is structured in a modular fashion, with each module generally implementing an Entity, Dto, Interface Service, Service, Interface Repository, Repository, and Controller.

### 1. Auth & Users
* **Purpose**: Secure access to the platform and user management.
* **Key Features**: Login, Registration, Profile Management, Email/Phone Verification, Password Resets.

### 2. Fleet
* **Purpose**: Inventory and status management of all vehicles.
* **Entity Features**: Tracks vehicle type, license plate, and operational status (e.g., InTransit, Available, Maintenance).

### 3. Map
* **Purpose**: Real-time GPS tracking engine.
* **Entity Features**: Records latitude, longitude, speed, and timestamp bounds mapped to specific fleets, allowing for live location tracking and historical route plotting.

### 4. Scheduler
* **Purpose**: The dispatching core.
* **Entity Features**: Assigns drivers to specific fleets and schedules trips from an origin to a destination, tracking start times, end times, and trip status.

### 5. Chat & Notification
* **Purpose**: System communication layer.
* **Entity Features**: 
  * `Chat`: Direct messaging (e.g., between dispatchers and drivers) with read/unread tracking.
  * `Notification`: System-wide alerts and updates pushed to specific users.

### 6. Dashboard
* **Purpose**: Administrative command center.
* **Features**: Aggregates data from other modules to provide high-level metrics (e.g., active trips, total fleets, pending alerts). Does not rely on a standalone database entity.

### 7. Setting
* **Purpose**: System-wide configuration management.
* **Features**: Manages global dynamic variables using a key-value store architecture.

## Architectural Decisions

### Clean Architecture Separation (Repositories & Services)
To maintain clean separation of concerns, the project follows these rules for repositories and services:
* **Repositories (`IRepository` / `Repository`)**: Handle pure database operations using Entity Framework Core. They interact only with database entities and basic types (e.g. `Guid`). They do **not** handle DTO mapping, validations, business exception raising, or date/time generations.
* **Services (`IService` / `Service`)**: Contain the core business logic. They process controllers' requests, perform parameter validations, orchestrate CRUD operations through repositories, enforce domain rules (such as setting `UpdatedAt` timestamp or raising business exceptions), and map database entities to/from Data Transfer Objects (DTOs) before returning them to controllers.

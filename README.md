# .NET Core MVC Application Projects

This repository contains projects developed to practically reinforce the .NET Core MVC architecture, modern web development fundamentals, and project management processes.

## 📂 Project Directory

Within the repository, there are two projects representing different stages of the learning process:

### 1. Basics
A starter project created to understand the fundamental building blocks of the .NET Core MVC architecture.
* **Objective:** To grasp the core concepts of MVC, HTTP request lifecycles, and front-end integration within a .NET environment.
* **Key Concepts:**
  * **MVC Architecture:** Understanding the distinct roles and interactions of Controllers, Views, and Models.
  * **Web Protocols:** Fundamentals of how HTTP works.
  * **Navigation:** Configuring Routing mechanisms and utilizing Route Links.
  * **Data Management:** Handling Model lists and implementing a basic Repository pattern for data access.
  * **UI & Styling:** Integrating Static Files and designing with Bootstrap.
  * **View Modularity:** Structuring reusable user interfaces using Layouts, Partial Views, and Sections.
  * **Dynamic Content:** Creating detail pages and mastering Razor Syntax for server-side HTML generation.

### 2. MeetingApp
A meeting/event participation management system where fundamental MVC knowledge is applied to a concrete and functional scenario.
* **Objective:** To collect data from users via forms, process this data, and list it dynamically on the interface.
* **Highlighted Features:**
  * Participant registration form (Model Binding & Data Validation).
  * Dynamic rendering of the participant list using collections.
  * Integration and management of static files (CSS, Bootstrap) via `wwwroot`.

---

## 🚀 Technologies and Tools
* **Backend:** C#, .NET 8
* **Frontend:** HTML5, CSS3, Bootstrap (Client-side libraries)
* **Architecture:** MVC (Model-View-Controller)

## ⚙️ How to Run the Projects

To run the projects in your local environment (localhost), you can follow the steps below:

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/egeyolsal/FullStack-DotNet-Core.git
   ```

2. Navigate to the directory of the project you want to inspect:
   ```bash
   cd MeetingApp 
   # or cd basics
   ```

3. Build and run the project:
   ```bash
   dotnet run
   ```

4. Open the `http://localhost:XXXX` address that appears in the terminal in your browser to view the application.

Receipt Reimbursement App

This project is a full-stack web application that allows university employees to submit reimbursement requests for their purchases. It includes an HTML form frontend and a .NET 8 Web API backend. Submitted data is stored in a SQL Server database and receipt files are saved locally on the server.

GitHub Repository Link
Repository: paste the repository link
This repository is public and accessible.
The repository includes:
  A complete Visual Studio solution
  A README.md with instructions on how to run the application
  Migrations and seed data
  HTML + JS form under wwwroot/index.html

Estimated vs. Actual Hours
Estimated time:  3  hours  
Actual time taken: 5 hours

Breakdown:
Backend (API + EF Core): 2.5 hours  
Frontend (form + styling): 1.5 hours  
Database integration & testing: 1 hour  
Debugging (SQL Server to SQL Server migration issues): 1.5 hours  
Final touches + Git setup: 0.5 hour

Reason for Tech Stack:
Based on my previous experience, I have chosen the below tech stack: Did not use any scripting language, because the requirement did not mention any.
> NET 8 Web API
> Aligned with the task’s preferred technologies
> Ideal for rapid API development
> Supports file uploads and EF Core natively
SQL Server
> Works seamlessly with Entity Framework Core
> Easy to inspect and query using SQL Server Management Studio (SSMS)
> Scales well for enterprise environments
HTML
> Lightweight and quick to implement
> Focuses on functionality rather than frontend complexity
> Keeps the UI clean and easy to test

Comments

Assumptions Made
> The app is used internally by trusted university employees, so no authentication was implemented for this version.
> File uploads are stored locally on the server in a public directory (wwwroot/Uploads/).
> All reimbursements are stored in a single SQL Server table for simplicity.

Problems Encountered and Solutions
> SQL Server Authentication didn’t work initially. The project was successfully reconfigured to use Windows Authentication (Trusted_Connection=True) instead.
> EF Core migration issues: Resolved by cleaning up old migrations, resetting the connection string, and applying fresh migrations to SQL Server.

Highlights in Code
> File upload uses IFormFile and saves files with Guid names to avoid conflicts.
> DTOs are used to keep models clean and allow for validation separation.
> Frontend fetches data dynamically and shows a live table of submissions.
> Project structured in clear MVC style with folders: Controllers, Models, DTOs, Data.

Additional Notes
> Future improvements could include authentication, admin approval workflows, and export to Excel/PDF.
> The front end can easily be migrated to Angular/React if needed.
> The app is deployable to IIS or Azure App Services with minimal config changes.

How to Run This App Locally
1. Clone the Repository
```bash
git clone https://github.com/yourusername/receipt-reimbursement-app.git
cd receipt-reimbursement-app

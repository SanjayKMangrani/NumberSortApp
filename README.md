# NumberSortApp

## Database

### Database Setup

To set up the database for the NumberSortApp project, follow these steps:

1. Create a new database instance using your preferred database management system (e.g., SQL Server, MySQL, PostgreSQL).
2. Run the database migration scripts to create the necessary tables and schema.
3. Optionally, populate the database with initial data using the provided SQL scripts.

### Database Configuration

To configure the NumberSortApp to connect to your database, follow these steps:

1. Open the `appsettings.json` file in the project root directory.
2. Update the `ConnectionString` value with the connection string for your database.
3. Save the changes and restart the application.

### Technologies Used

The NumberSortApp project uses SQL Server as its database backend. Entity Framework Core is used as the ORM framework for database interaction.

### Migration

NumberSortApp uses Entity Framework Core Migrations for database version control.


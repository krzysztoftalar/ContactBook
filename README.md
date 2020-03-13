ContactBook

Installation guide:

1. In solution CBData/PublishLocations create publish.xml file. Right click on project -> Publish... ->
   Edit -> Browse -> Local -> select MSSQLLocalDB. Enter Database name. Save Profile As../PublishLocations -> Save. Publish.
2. In solution CBDesktopUI/App.config set your connection string and database name.
3. In solution CBDesktopUI.Library/Internal/DataAccess/SqlDataAccess in GetConnectionString method set database name.
4. Build and run CBDesktopUI solution.

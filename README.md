---
languages:
- csharp
- aspx-csharp
page_type: sample
description: "This is a sample application you can use to follow along w/ the Build a .NET Core and SQL Database web app in Azure Web Apps for Containers tutorial."
products:
- azure
- aspnet-core
- azure-app-service
---

# .NET Core MVC sample for Azure App Service

This is a sample application that you can use to follow along with the tutorial at 
[Build a .NET Core and SQL Database web app in Azure Web Apps for Containers](https://docs.microsoft.com/azure/app-service/containers/tutorial-dotnetcore-sqldb-app). 

## License

See [LICENSE](LICENSE.md).

## Contributing

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
  
# DEPLOY #
## 0 Visit for more info
https://docs.microsoft.com/pt-pt/azure/app-service/app-service-web-tutorial-dotnetcore-sqldb

## 1 clone
git clone https://github.com/jaumendes/dotnetcore-sqldb.git
cd dotnetcore-sqldb

## 2 install packages 
dotnet tool install -g dotnet-ef

## 3 (re) create DB
dotnet ef database update

# 4 run
dotnet run

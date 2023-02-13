# CSharp_Learning_Temp

一些C#學習過程中所寫的代碼，其中會使用到.NetFramework或者Unity的框架，非純Vanilla；

以及有部分檔案是還在撰寫修改中，是未完成狀態。



主要有用到Northwind資料庫範本作為資料來源。
其中的資料表如下

```
Categories : 
    CategoryID 
    CategoryName 
    Description 
    Picture 
  
Customers : 
    CustomerID 
    CompanyName 
    ContactName 
    ContactTitle 
    Address
    City
    Region 
    PostalCode 
    Country 
    Phone 
    Fax 


Employees :
    EmployeeID 
    LastName
    FirstName 
    Title
    TitleOfCourtesy 
    BirthDate 
    HireDate
    Address 
    City 
    Region 
    PostalCode 
    Country 
    HomePhone 
    Extension 
    Photo 
    notes 
    ReportsTo 

EmployeeTerritories :
    EmployeeID 
    TerritoryID 

Order Details : 
    OrderID 
    ProductID 
    UnitPrice 
    Quantity 
    Discount

Orders :
    OrderID 
    CustomerID
    EmployeeID
    OrderDate
    RequiredDate
    ShippedDate
    ShipVia
    Freight
    ShipName
    ShipAddress
    ShipCity
    ShipRegion
    ShipPostalCode
    ShipCountry

Products :
    ProductID
    ProductName 
    SupplierID 
    CategoryID 
    QuantityPerUnit 
    UnitPrice 
    UnitsInStock 
    UnitsOnOrder 
    ReorderLevel
    Discontinued

Region : 
    RegionID
    RegionDescription

Shippers :
    ShipperID 
    CompanyName 
    Phone 

Suppliers :
    ShipperID
    CompanyName
    Phone

Territories :
    TerritoryID 
    TerritoryDescription
    RegionID

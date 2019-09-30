<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the product and category names in a "flat" list
from data in Products
select new
{
   Product = data.ProductName,
   Category = data.Category.CategoryName
}
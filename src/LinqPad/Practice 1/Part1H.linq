<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//H) List all the discontinued products, specifying the product name and unit price.

from data in Products
where data.Discontinued == true
	select new{
		Product = data.ProductName,
		Price = data.UnitPrice
	}
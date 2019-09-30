<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//G) List all the product names that contain the word "chef" in the name.

from data in Products
where data.ProductName.Contains("chef")
select data.ProductName
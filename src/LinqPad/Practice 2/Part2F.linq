<Query Kind="Expression">
  <Connection>
    <ID>713f7813-7fb4-413b-9754-bda6ff6364b3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// F) List all the Suppliers, by Country

from data in Suppliers
select new{
	country = data.Address.Country,
	Supplier = data.CompanyName
}
<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//I) List the company names of all Suppliers in North America (Canada, USA, Mexico)
from data in Suppliers
where data.Address.Country == "Canada"
|| data.Address.Country == "USA" 
|| data.Address.Country == "Mexico"
select data.CompanyName
<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// A) List all the customer company names for those with more than 5 orders.

from data in Customers

where data.Orders.Count>5

select data.CompanyName



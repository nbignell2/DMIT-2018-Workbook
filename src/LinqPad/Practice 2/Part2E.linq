<Query Kind="Expression">
  <Connection>
    <ID>f9b4831a-f366-461b-b4fd-5847b5fc580d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// E) Group all customers by city. Output the city name, aalong with the company name, contact name and title, and the phone number.

from person in Customers
group person by person.Address.City into customercities
select new
{
	Cities = customercities.Key,
	Customer = from customer in customercities
		select new
		{
			Company = customer.CompanyName,
			Contact = customer.ContactName,
			Title = customer.ContactTitle,
			Number = customer.Phone
		}
	
}
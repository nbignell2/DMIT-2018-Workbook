<Query Kind="Expression">
  <Connection>
    <ID>f9b4831a-f366-461b-b4fd-5847b5fc580d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// B) List all the Customers by Company Name. Include the Customer's company name, contact name, and other contact information in the result.

from person in Customers
group person by person.CompanyName into CustomerCompany
select new
{
    Company = CustomerCompany.Key,
	Customer = from customer in CustomerCompany
//				\ customer /  \ customers [] /

	           select new
               {
			       contact = customer.ContactName,
				   title = customer.ContactTitle,
				   email = customer.ContactEmail,
				   phone = customer.Phone
               }
}
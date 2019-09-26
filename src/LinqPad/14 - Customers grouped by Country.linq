<Query Kind="Expression">
  <Connection>
    <ID>5265d1f5-021e-4878-9587-a78d45e7824e</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Display all the company names and contact names for our customers, grouped by country
from row in Customers
group  row   by   row.Address.Country
//    \what/      \       how    	/
//						 (key)
// The ressult of the above gives an
// IOrderedQueryable<IGrouping<string, Customers>>
into CustomersByCountry
select new
{
   Country = CustomersByCountry.Key, // the key is "how" we have sorted the data
   Customers = from data in CustomersByCountry
   //			customer		customer[]
               select new
               {
			       Company = data.CompanyName,
				   Contact = data.ContactName
               }
}
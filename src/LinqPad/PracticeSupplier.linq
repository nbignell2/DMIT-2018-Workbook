<Query Kind="Expression">
  <Connection>
    <ID>f9b4831a-f366-461b-b4fd-5847b5fc580d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

/* "Supplier"

Company Name
Contact Name
Phone Number
"Product Summary"
Product Name
Category Name
Unit Price
Quantity/Unit
*/

from company in Suppliers
select new
{
	CompanyName = company.CompanyName,
	ContactName = company.ContactName,
	PhoneNumber = company.Phone,
	Product = from item in company.Products
		select new //
		{
			name= item.ProductName,
			price = item.UnitPrice,
			Qty = item.QuantityPerUnit
		}
}

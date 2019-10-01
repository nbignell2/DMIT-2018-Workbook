<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// B) List all the Customers by Company Name. Include the Customer's company name, contact name, and other contact information in the result.

from person in Employees
group person by person.Address.Region into EmployeeGroups
select new
{
    Region = EmployeeGroups.Key,
	Employee = from staff in EmployeeGroups
//				\ staff /  \ staff [] /

	           select new
               {
			       FirstName = staff.FirstName,
				   LastName = staff.LastName,
				   JobTitle = staff.JobTitle
               }
}
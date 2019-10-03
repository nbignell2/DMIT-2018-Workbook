<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// C) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.

from person in Employees
orderby person.LastName ascending, person.FirstName ascending 
select new{
	Last = person.LastName,
	First = person.FirstName,
	CustOrders = person.SalesRepOrders.Count
}
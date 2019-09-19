<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List the full name of all the employees who look after 7 or more territories
from person in Employees
where person.EmployeeTerritories.Count >= 7
//   \ type /
select person.FirstName + " " + person.LastName
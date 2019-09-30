<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// A) Group employees by region and show the results in this format:
/* ----------------------------------------------
 * | REGION        | EMPLOYEES                  |
 * ----------------------------------------------
 * | Eastern       | ------------------------   |
 * |               | | Nancy Devalio        |   |
 * |               | | Fred Flintstone      |   |
 * |               | | Bill Murray          |   |
 * |               | ------------------------   |
 * |---------------|----------------------------|
 * | ...           |                            |
 * 
 */
 
from row in Employees


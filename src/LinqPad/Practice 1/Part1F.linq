<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//F) List all the region and territory names as an "object graph"
  // - use a nested query
  
from data in Regions
select new
{
    Region = data.RegionDescription,
    Territory = from item in data.Territories
               select item.TerritoryDescription
}
<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//D) List all the regions and the number of territories in each region

from data in Regions
select new{
		Region = data.RegionDescription,
		TerritoryCount = data.Territories.Count()
	}
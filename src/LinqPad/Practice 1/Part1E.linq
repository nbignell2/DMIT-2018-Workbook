<Query Kind="Expression">
  <Connection>
    <ID>bafaf330-32cb-432e-af33-e5bdf4070172</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// E) List all the region and territory names in a "flat" list

from data in Territories
select new{
	Territory = data.TerritoryDescription,
	Region = data.Region.RegionDescription
	}


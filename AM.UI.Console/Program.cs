
using AM.Core.Domain;

Plane plane = new Plane();
plane.Flights = null;
plane.Capacity = 0;
plane.ManufactureDate = DateTime.Now; 
plane.MyPlaneType = PlaneType.Boing;
plane.PlaneId = 1;


Plane plane2 = new Plane(PlaneType.Boing,2,DateTime.Now);
Plane plane3 = new Plane() 
{   MyPlaneType = PlaneType.Boing,
    Capacity = 2,
    ManufactureDate=DateTime.Now};
Console.WriteLine(plane);
Console.WriteLine(plane2);
Console.WriteLine(plane3);
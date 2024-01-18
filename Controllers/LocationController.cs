using Google.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class LocationController : Controller
{
    public IActionResult GetLocation()
    {
        // Implement logic to retrieve locations from a database or other source
        var locations = new List<Location>
        {
            new Location { Name = "Location 1", Latitude = 37.7749, Longitude = -122.4194 },
            new Location { Name = "Location 2", Latitude = 34.0522, Longitude = -118.2437 },
            // Add more locations as needed
        };

        return View(locations);
    }

    [HttpPost] // Handle post requests (button click)
    public IActionResult ShowLocations()
    {
        return RedirectToAction("Index"); // Redirect to the Index action (showing locations)
    }
}

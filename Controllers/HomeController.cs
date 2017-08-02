using Microsoft.AspNetCore.Mvc;
using JobHistory.Models;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace JobHistory.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/JobAdd")]
    public ActionResult JobAdd()
    {
      return View();
    }

    [HttpGet("/JobHistory")]
    public ActionResult JobHistoryView()
    {
      List<Job> allJobs = Job.GetAll();

      return View("JobHistory", allJobs);
    }

    [HttpPost("/JobHistory")]
    public ActionResult JobHistory()
    {
      CultureInfo provider = CultureInfo.InvariantCulture;

      string employer = Request.Form["employer"];
      string title = Request.Form["title"];
      DateTime startDate = DateTime.Parse(Request.Form["startDate"]);
      DateTime endDate = DateTime.Parse(Request.Form["endDate"]);
      string description = Request.Form["description"];
      Job newJob = new Job(employer, title, startDate, endDate, description);
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }
  }
}

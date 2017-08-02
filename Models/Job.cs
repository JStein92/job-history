using System;
using System.Collections.Generic;

namespace JobHistory.Models
{
  public class Job
  {
    private string _employer;
    private string _title;
    private DateTime _startDate;
    private DateTime _endDate;
    private string _description;
    private static List<Job> _jobList = new List<Job>() {};

    public Job(string employer, string title, DateTime start, DateTime end, string description)
    {
      _employer = employer;
      _title = title;
      _startDate = start;
      _endDate = end;
      _description = description;
      _jobList.Add(this);
    }

    public string GetEmployer()
    {
      return _employer;
    }
    public string GetTitle()
    {
      return _title;
    }
    public DateTime GetStartDate()
    {
      return _startDate;
    }
    public DateTime GetEndDate()
    {
      return _endDate;
    }
    public string GetDescription()
    {
      return _description;
    }
    public static List<Job> GetAll()
    {
      return _jobList;
    }
    public static Job Find(int id)
    {
      return _jobList[id - 1];
    }
  }
}

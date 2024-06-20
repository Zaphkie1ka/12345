using System;

namespace CbIHNIIIA.Models;

public class Events
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime Start_Date { get; set; }
    public DateTime End_Date { get; set; }
    public int CommandID { get; set; }
    public string Location { get; set; }
    public string Boss { get; set; }
}
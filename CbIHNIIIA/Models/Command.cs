using System;

namespace CbIHNIIIA.Models;

public class Command
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime Date_Registration { get; set; }
    public string Address { get; set; }
    public int Count { get; set; }
}
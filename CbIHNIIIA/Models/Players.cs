using System;

namespace CbIHNIIIA.Models;

public class Players
{
    public int ID { get; set; }
    public string First_Name { get; set; }
    public string Middle_Name { get; set; }
    public string Last_Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Address { get; set; }
    public long Number { get; set; }
    public int CommandID { get; set; }
}
using System;
using SQLite;

namespace SQLiteCarPage.MVVM.Models;

public class Car
{
    [PrimaryKey , AutoIncrement]
    public int ID { get ; set ;}
    
    public string Models { get; set; }
    
    public string Color { get; set; }
    

}

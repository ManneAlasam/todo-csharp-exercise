using System;
using System.Xml.Linq;

//namespace med ; kallas File-Scoped
namespace Todo.Models;

// class låter oss definiera nya datatyper - En datatyp av data och beteende
public class Task
{
  // konstruktor ansvarar för att säkerställa att projektet skapas i ett giltigt tillstånd
  // den anropas när man skapar ett objekt (new Task())
  public Task(string name)
  {
    // Vi behöver säkerställa att name inte är null eller tom sträng ("") - vi kallar detta för validering

    Name = name;
  }

  public Task(string name, bool completed)
  {
    // Vi behöver säkerställa att name inte är null eller tom sträng ("") - vi kallar detta för validering
    Name = name;
    Completed = completed;
  }

  public Task(int id, string name, bool completed)
  {
    // Vi behöver säkerställa att name inte är null eller tom sträng ("") - vi kallar detta för validering
    Id = id;
    Name = name;
    Completed = completed;
  }
  public int? Id { get; set; }

  private string _name = string.Empty;
  public string Name
  {
    get => _name;
    set
    {
      // Behöver säkerställa att det inte är null
      if (string.IsNullOrWhiteSpace(value) || value.Trim().Length > 50)
      {
        // Throw låter oss lyfta exekeringen från en punkt till en annan
        throw new Exception($"{nameof(value)} must be a string between 1-50 characters");
      }
      _name = value;
    }
  }

  // Auto-implemented property
  // Den automatiskt skapar ett bakomliggande fält (backing field) där värdet lagras.
  public bool Completed { get; set; }
}



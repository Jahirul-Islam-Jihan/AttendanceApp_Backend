//In the name of Allah

using System.ComponentModel.DataAnnotations.Schema;

namespace attendence_app.Models;

public class Book
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
}//cls

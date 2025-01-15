using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Titanic;

public partial class Titanic
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Passengerid { get; set; }

    public int Survived { get; set; }

    public int Pclass { get; set; }

    public string Passenger { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public int? Age { get; set; }

    public int Sibsp { get; set; }

    public int Parch { get; set; }

    public string Ticket { get; set; } = null!;

    public float Fare { get; set; }

    public string? Cabin { get; set; }

    public char Embarced { get; set; }
}

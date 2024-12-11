using System;
using System.Collections.Generic;

namespace WindowsForm.Models;

public partial class Riddle
{
    public int RiddleId { get; set; }

    public string QuestionText { get; set; } = null!;

    public string CorrectAnswer { get; set; } = null!;

    public string WrongAnswer1 { get; set; } = null!;

    public string WrongAnswer2 { get; set; } = null!;

    public string WrongAnswer3 { get; set; } = null!;

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}

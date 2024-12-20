﻿using System;
using System.Collections.Generic;

namespace ZH3.Models;

public partial class Score
{
    public int ScoreId { get; set; }

    public string UserName { get; set; } = null!;

    public int FinalScore { get; set; }

    public DateTime PlayedAt { get; set; }
}

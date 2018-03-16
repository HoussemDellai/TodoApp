﻿using System;

namespace TodoMobileApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public bool IsDone { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace TodoApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }
}

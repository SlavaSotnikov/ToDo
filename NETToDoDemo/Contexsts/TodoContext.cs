﻿using Microsoft.EntityFrameworkCore;
using NETToDoDemo.Models;

namespace NETToDoDemo.Contexsts
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) {}

        public DbSet<ToDo> ToDos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoList_API.Models;

namespace ToDoList_API.Data
{
    public class ToDoList_APIContext : DbContext
    {
        public ToDoList_APIContext (DbContextOptions<ToDoList_APIContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoList_API.Models.TaskModel> Task { get; set; } = default!;
    }
}

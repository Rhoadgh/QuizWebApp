using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizWebApp.Models;

namespace QuizWebApp.Data
{
    public class QuizWebAppContext : IdentityDbContext
    {
        public QuizWebAppContext (DbContextOptions<QuizWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<QuizWebApp.Models.Participant> Participant { get; set; } = default!;

        public DbSet<QuizWebApp.Models.Question> Question { get; set; } = default!;

        public DbSet<QuizWebApp.Models.Category> Category { get; set; } = default!;
    }
}

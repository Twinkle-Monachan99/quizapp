﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizBackend.Models;

namespace QuizBackend
{
    public class QuizDbContext :DbContext
    {
            public QuizDbContext(DbContextOptions<QuizDbContext>options) :base(options) { }

            public DbSet<Models.Question>Questions{ get; set; }


            public DbSet<QuizBackend.Models.Quiz> Quiz { get; set; }
    }
}
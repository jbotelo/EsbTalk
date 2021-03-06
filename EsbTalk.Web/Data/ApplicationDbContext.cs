﻿using System;
using System.Collections.Generic;
using System.Text;
using EsbTalk.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EsbTalk.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Message>()
                .HasOne<AppIdentityUser>(m => m.Sender)
                .WithMany(aiu => aiu.Messages)
                .HasForeignKey(m => m.UserId);
        }
    }
}

using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Papricash;

namespace Papricash.Migrations
{
    [DbContext(typeof(SpendContext))]
    partial class SpendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("Papricash.Spending", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("amount");

                    b.Property<int>("cat");

                    b.Property<string>("comment");

                    b.Property<DateTime>("date");

                    b.HasKey("id");
                });
        }
    }
}

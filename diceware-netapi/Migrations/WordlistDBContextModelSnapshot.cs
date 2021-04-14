﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using diceware_netapi.Models;

namespace diceware_netapi.Migrations
{
    [DbContext(typeof(WordlistDBContext))]
    partial class WordlistDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("diceware_netapi.Models.Wordlist", b =>
                {
                    b.Property<int>("Roll")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Word")
                        .HasColumnType("TEXT");

                    b.HasKey("Roll");

                    b.ToTable("Wordlist");
                });
#pragma warning restore 612, 618
        }
    }
}

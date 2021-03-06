﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XrnCourse.BucketList.WebApi.Data;

namespace XrnCourse.BucketList.WebApi.Migrations
{
    [DbContext(typeof(BucketlistContext))]
    [Migration("20191117154954_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XrnCourse.BucketList.WebApi.Domain.Bucketlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Bucketlists");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-0000-0000-0000-000000000001"),
                            Description = "Advancing my programming skills",
                            IsFavorite = true,
                            OwnerId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "Programming Dreams"
                        },
                        new
                        {
                            Id = new Guid("11111111-0000-0000-0000-000000000002"),
                            Description = "How I'm gonna spend the money earned from programming",
                            IsFavorite = true,
                            OwnerId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "World Travels"
                        });
                });

            modelBuilder.Entity("XrnCourse.BucketList.WebApi.Domain.BucketlistItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BucketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BucketId");

                    b.ToTable("BucketlistItems");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-1111-0000-0000-000000000001"),
                            BucketId = new Guid("11111111-0000-0000-0000-000000000001"),
                            CompletionDate = new DateTime(2019, 5, 17, 16, 49, 53, 777, DateTimeKind.Local).AddTicks(8522),
                            ItemDescription = "Become better in C#"
                        },
                        new
                        {
                            Id = new Guid("11111111-1111-0000-0000-000000000002"),
                            BucketId = new Guid("11111111-0000-0000-0000-000000000001"),
                            CompletionDate = new DateTime(2019, 10, 17, 16, 49, 53, 780, DateTimeKind.Local).AddTicks(6502),
                            ItemDescription = "Learn Xamarin"
                        },
                        new
                        {
                            Id = new Guid("11111111-1111-0000-0000-000000000003"),
                            BucketId = new Guid("11111111-0000-0000-0000-000000000001"),
                            ItemDescription = "Publish my first mobile app"
                        },
                        new
                        {
                            Id = new Guid("22222222-1111-0000-0000-000000000001"),
                            BucketId = new Guid("11111111-0000-0000-0000-000000000002"),
                            ItemDescription = "Hiking New Zealand"
                        });
                });

            modelBuilder.Entity("XrnCourse.BucketList.WebApi.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Email = "siegfried@bucketlists.test",
                            UserName = "Siegfried"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Email = "deidre@bucketlists.test",
                            UserName = "Deidre"
                        });
                });

            modelBuilder.Entity("XrnCourse.BucketList.WebApi.Domain.Bucketlist", b =>
                {
                    b.HasOne("XrnCourse.BucketList.WebApi.Domain.User", "Owner")
                        .WithMany("OwnedBuckets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XrnCourse.BucketList.WebApi.Domain.BucketlistItem", b =>
                {
                    b.HasOne("XrnCourse.BucketList.WebApi.Domain.Bucketlist", "ParentBucket")
                        .WithMany("Items")
                        .HasForeignKey("BucketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

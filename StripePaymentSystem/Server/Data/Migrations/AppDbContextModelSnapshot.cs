﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4");

            modelBuilder.Entity("Shared.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "6af72135-a1f2-42c6-ae27-4cc90d65ad2f",
                            Description = "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/1/500",
                            Price = 1000L,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = "f5ec669f-3c32-49a1-8b44-3761873f091c",
                            Description = "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/2/500",
                            Price = 2000L,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = "18f2a1f3-a92e-4f0c-8755-35e6f38dcf6c",
                            Description = "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/3/500",
                            Price = 3000L,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = "fc09a836-4619-4a64-a098-d92ff9e14c10",
                            Description = "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/4/500",
                            Price = 4000L,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = "1edab72e-a2ed-41a5-9890-670884dbd65d",
                            Description = "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/5/500",
                            Price = 5000L,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = "fe27cae6-e443-4767-9aab-33eecf196ba5",
                            Description = "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/6/500",
                            Price = 6000L,
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = "1118d34b-6e2c-4f5d-b622-2a2a5871c362",
                            Description = "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/7/500",
                            Price = 7000L,
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = "23b00b78-087e-4b98-b5ba-05edb01065cb",
                            Description = "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/8/500",
                            Price = 8000L,
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = "88319215-e505-40ec-b7ba-9b95bfad1de0",
                            Description = "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/9/500",
                            Price = 9000L,
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = "4bc8c646-9753-4a6b-ba59-309ed5b5489f",
                            Description = "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/10/500",
                            Price = 10000L,
                            Title = "Product 10"
                        },
                        new
                        {
                            Id = "b9baadfc-c06c-49c1-a0cd-9cd761c5b653",
                            Description = "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/11/500",
                            Price = 11000L,
                            Title = "Product 11"
                        },
                        new
                        {
                            Id = "a4adfa48-568f-47d8-b2de-0cc37e765b96",
                            Description = "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/12/500",
                            Price = 12000L,
                            Title = "Product 12"
                        },
                        new
                        {
                            Id = "58073f5b-4cbf-4507-9fae-e728f1fde8ae",
                            Description = "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/13/500",
                            Price = 13000L,
                            Title = "Product 13"
                        },
                        new
                        {
                            Id = "5db1ffa3-07b5-403f-8503-0364927198cc",
                            Description = "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/14/500",
                            Price = 14000L,
                            Title = "Product 14"
                        },
                        new
                        {
                            Id = "e0fef6e1-d010-4f64-9bcf-9eddb112537c",
                            Description = "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/15/500",
                            Price = 15000L,
                            Title = "Product 15"
                        },
                        new
                        {
                            Id = "3ed5e145-b50a-4564-b9f3-98717fea98d2",
                            Description = "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/16/500",
                            Price = 16000L,
                            Title = "Product 16"
                        },
                        new
                        {
                            Id = "eeeb3763-286f-4f4b-9312-3e9e98a1171b",
                            Description = "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/17/500",
                            Price = 17000L,
                            Title = "Product 17"
                        },
                        new
                        {
                            Id = "b2cb802f-7620-461e-b6e7-0c39891ac45b",
                            Description = "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/18/500",
                            Price = 18000L,
                            Title = "Product 18"
                        },
                        new
                        {
                            Id = "4fe7c437-1900-4d8a-b78b-89ba17a56573",
                            Description = "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/19/500",
                            Price = 19000L,
                            Title = "Product 19"
                        },
                        new
                        {
                            Id = "79e33f48-9410-4fcc-83c5-d5b3115d0b1f",
                            Description = "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/20/500",
                            Price = 20000L,
                            Title = "Product 20"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

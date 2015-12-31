using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using NettlesApi.Models;

namespace NettlesApi.Migrations
{
    [DbContext(typeof(NettlesContext))]
    [Migration("20151231011647_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NettlesApi.Models.Caller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<int?>("ShowId");

                    b.Property<string>("Url");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("NettlesApi.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Picture")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("NettlesApi.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ImageId");

                    b.Property<string>("Note");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Url");

                    b.Property<int?>("VenueId")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("NettlesApi.Models.Venue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Url");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("NettlesApi.Models.Caller", b =>
                {
                    b.HasOne("NettlesApi.Models.Show")
                        .WithMany()
                        .HasForeignKey("ShowId");
                });

            modelBuilder.Entity("NettlesApi.Models.Show", b =>
                {
                    b.HasOne("NettlesApi.Models.Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("NettlesApi.Models.Venue")
                        .WithMany()
                        .HasForeignKey("VenueId");
                });
        }
    }
}

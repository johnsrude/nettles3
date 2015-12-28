using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using NettlesApi.Models;

namespace NettlesApi.Migrations
{
    [DbContext(typeof(NettlesContext))]
    [Migration("20151222192018_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NettlesApi.Models.Caller", b =>
                {
                    b.Property<int>("CallerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.Property<int?>("ShowShowId");

                    b.Property<string>("Url");

                    b.HasKey("CallerId");
                });

            modelBuilder.Entity("NettlesApi.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Picture");

                    b.HasKey("ImageId");
                });

            modelBuilder.Entity("NettlesApi.Models.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ImageImageId");

                    b.Property<string>("Note");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<int?>("VenueVenueId");

                    b.HasKey("ShowId");
                });

            modelBuilder.Entity("NettlesApi.Models.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Url");

                    b.HasKey("VenueId");
                });

            modelBuilder.Entity("NettlesApi.Models.Caller", b =>
                {
                    b.HasOne("NettlesApi.Models.Show")
                        .WithMany()
                        .HasForeignKey("ShowShowId");
                });

            modelBuilder.Entity("NettlesApi.Models.Show", b =>
                {
                    b.HasOne("NettlesApi.Models.Image")
                        .WithMany()
                        .HasForeignKey("ImageImageId");

                    b.HasOne("NettlesApi.Models.Venue")
                        .WithMany()
                        .HasForeignKey("VenueVenueId");
                });
        }
    }
}

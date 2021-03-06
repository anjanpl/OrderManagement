// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Models;

namespace OrderManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220510155053_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderManagement.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddresslineOne")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("AddresslineTwo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddresslineOne = "Houston",
                            AddresslineTwo = "AB",
                            City = "Texas",
                            Name = "Anjan",
                            PostalCode = "5458878",
                            State = 4
                        },
                        new
                        {
                            Id = 2,
                            AddresslineOne = "California",
                            AddresslineTwo = "ABC",
                            City = "California",
                            Name = "Ashis",
                            PostalCode = "8898989",
                            State = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

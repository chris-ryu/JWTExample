// <auto-generated />
using JWTExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JWTExample.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JWTExample.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            FirstName = "FirstName1",
                            LastName = "LastName1"
                        },
                        new
                        {
                            EmployeeID = 2,
                            FirstName = "FirstName2",
                            LastName = "LastName2"
                        },
                        new
                        {
                            EmployeeID = 3,
                            FirstName = "FirstName3",
                            LastName = "LastName3"
                        },
                        new
                        {
                            EmployeeID = 4,
                            FirstName = "FirstName4",
                            LastName = "LastName4"
                        },
                        new
                        {
                            EmployeeID = 5,
                            FirstName = "FirstName5",
                            LastName = "LastName5"
                        },
                        new
                        {
                            EmployeeID = 6,
                            FirstName = "FirstName6",
                            LastName = "LastName6"
                        },
                        new
                        {
                            EmployeeID = 7,
                            FirstName = "FirstName7",
                            LastName = "LastName7"
                        },
                        new
                        {
                            EmployeeID = 8,
                            FirstName = "FirstName8",
                            LastName = "LastName8"
                        },
                        new
                        {
                            EmployeeID = 9,
                            FirstName = "FirstName9",
                            LastName = "LastName9"
                        },
                        new
                        {
                            EmployeeID = 10,
                            FirstName = "FirstName10",
                            LastName = "LastName10"
                        },
                        new
                        {
                            EmployeeID = 11,
                            FirstName = "FirstName11",
                            LastName = "LastName11"
                        },
                        new
                        {
                            EmployeeID = 12,
                            FirstName = "FirstName12",
                            LastName = "LastName12"
                        },
                        new
                        {
                            EmployeeID = 13,
                            FirstName = "FirstName13",
                            LastName = "LastName13"
                        },
                        new
                        {
                            EmployeeID = 14,
                            FirstName = "FirstName14",
                            LastName = "LastName14"
                        },
                        new
                        {
                            EmployeeID = 15,
                            FirstName = "FirstName15",
                            LastName = "LastName15"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

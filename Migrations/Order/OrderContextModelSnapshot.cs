﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using order.Infrastructure.EF;

namespace mvccoresb.Migrations.Order
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("order.Domain.Models.Ordering.AdressDAL", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30000000-0000-0000-0000-000000000000"),
                            Name = "Some address one"
                        },
                        new
                        {
                            Id = new Guid("30000000-0000-0000-0000-000000000001"),
                            Name = "Some address two"
                        });
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.DeliveryItemDAL", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DeliveryItem");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20000000-0000-0000-0000-000000000000"),
                            Name = "Item1"
                        },
                        new
                        {
                            Id = new Guid("20000000-0000-0000-0000-000000000001"),
                            Name = "Item2"
                        });
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.DeliveryItemDimensionUnitDAL", b =>
                {
                    b.Property<Guid>("DeliveryItemId");

                    b.Property<Guid>("DimensionalItemId");

                    b.Property<float>("Amount");

                    b.Property<Guid>("Id");

                    b.HasKey("DeliveryItemId", "DimensionalItemId");

                    b.HasIndex("DimensionalItemId");

                    b.ToTable("DeliveryItemDimensionUnitDAL");

                    b.HasData(
                        new
                        {
                            DeliveryItemId = new Guid("20000000-0000-0000-0000-000000000000"),
                            DimensionalItemId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Amount = 0f,
                            Id = new Guid("40000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.DimensionalUnitDAL", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DimensionalUnit");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "wight in kg",
                            Name = "kg"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "wight in pounds",
                            Name = "lbs"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Description = "lenght in sm",
                            Name = "sm"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            Description = "lenght in inches",
                            Name = "inch"
                        });
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.OrderItemDAL", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("DaysToDelivery");

                    b.Property<float>("DeliveryPrice");

                    b.Property<int>("ItemsOrderedAmount");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = new Guid("50000000-0000-0000-0000-000000000000"),
                            DaysToDelivery = 0f,
                            DeliveryPrice = 0f,
                            ItemsOrderedAmount = 0,
                            Name = "Order one"
                        },
                        new
                        {
                            Id = new Guid("50000000-0000-0000-0000-000000000001"),
                            DaysToDelivery = 0f,
                            DeliveryPrice = 0f,
                            ItemsOrderedAmount = 0,
                            Name = "Order two"
                        });
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.OrdersAdresses", b =>
                {
                    b.Property<Guid>("AddressFromId");

                    b.Property<Guid>("AddressToId");

                    b.Property<Guid>("OrderId");

                    b.Property<Guid>("Id");

                    b.HasKey("AddressFromId", "AddressToId", "OrderId");

                    b.HasIndex("AddressToId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersAdresses");

                    b.HasData(
                        new
                        {
                            AddressFromId = new Guid("30000000-0000-0000-0000-000000000000"),
                            AddressToId = new Guid("30000000-0000-0000-0000-000000000001"),
                            OrderId = new Guid("50000000-0000-0000-0000-000000000000"),
                            Id = new Guid("60000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            AddressFromId = new Guid("30000000-0000-0000-0000-000000000000"),
                            AddressToId = new Guid("30000000-0000-0000-0000-000000000001"),
                            OrderId = new Guid("50000000-0000-0000-0000-000000000001"),
                            Id = new Guid("60000000-0000-0000-0000-000000000001")
                        });
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.OrdersDeliveryItemsDAL", b =>
                {
                    b.Property<Guid>("OrderId");

                    b.Property<Guid>("DeliveryId");

                    b.Property<Guid>("Id");

                    b.HasKey("OrderId", "DeliveryId");

                    b.HasIndex("DeliveryId");

                    b.ToTable("OrdersDeliveryItemsDAL");
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.UnitsConvertionDAL", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("ConvertionRate");

                    b.Property<Guid>("FromId");

                    b.Property<Guid>("ToId");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("UnitsConvertion");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10000000-0000-0000-0000-000000000000"),
                            ConvertionRate = 2.20462f,
                            FromId = new Guid("00000000-0000-0000-0000-000000000001"),
                            ToId = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            Id = new Guid("10000000-0000-0000-0000-000000000001"),
                            ConvertionRate = 0.220462f,
                            FromId = new Guid("00000000-0000-0000-0000-000000000002"),
                            ToId = new Guid("00000000-0000-0000-0000-000000000001")
                        });
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.DeliveryItemDimensionUnitDAL", b =>
                {
                    b.HasOne("order.Domain.Models.Ordering.DeliveryItemDAL", "DelivertyItem")
                        .WithMany("Parameters")
                        .HasForeignKey("DeliveryItemId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("order.Domain.Models.Ordering.DimensionalUnitDAL", "Unit")
                        .WithMany("DeliveryItems")
                        .HasForeignKey("DimensionalItemId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.OrdersAdresses", b =>
                {
                    b.HasOne("order.Domain.Models.Ordering.AdressDAL", "AddressFrom")
                        .WithMany("Orders")
                        .HasForeignKey("AddressFromId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("order.Domain.Models.Ordering.AdressDAL", "AddressTo")
                        .WithMany()
                        .HasForeignKey("AddressToId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("order.Domain.Models.Ordering.OrderItemDAL", "Order")
                        .WithMany("Directions")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.OrdersDeliveryItemsDAL", b =>
                {
                    b.HasOne("order.Domain.Models.Ordering.DeliveryItemDAL", "Delivery")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("order.Domain.Models.Ordering.OrderItemDAL", "Order")
                        .WithMany("DeliveryItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("order.Domain.Models.Ordering.UnitsConvertionDAL", b =>
                {
                    b.HasOne("order.Domain.Models.Ordering.DimensionalUnitDAL", "From")
                        .WithMany()
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("order.Domain.Models.Ordering.DimensionalUnitDAL", "To")
                        .WithMany("Convertions")
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

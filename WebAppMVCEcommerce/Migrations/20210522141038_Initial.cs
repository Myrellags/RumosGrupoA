using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMVCEcommerce.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "MethodOfPayments",
                columns: table => new
                {
                    MethodOfPaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMethodOfPayment = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TypeMethodOfPayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodOfPayments", x => x.MethodOfPaymentID);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    District = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SocialMidia = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PassUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    District = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SocialMidia = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionWarehouse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseID);
                });

            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    CostumerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginUser = table.Column<int>(type: "int", nullable: false),
                    Delete = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.CostumerID);
                    table.ForeignKey(
                        name: "FK_Costumers_Users_LoginUser",
                        column: x => x.LoginUser,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightProduct = table.Column<double>(type: "float", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    DiscontinuedProduct = table.Column<bool>(type: "bit", nullable: false),
                    PricePurchaseProduct = table.Column<double>(type: "float", nullable: false),
                    PriceSellProduct = table.Column<double>(type: "float", nullable: false),
                    CategoryProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<byte>(type: "tinyint", nullable: false),
                    Delete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventoryID = table.Column<int>(type: "int", nullable: true),
                    InvoicesReceivableID = table.Column<int>(type: "int", nullable: true),
                    IsOnSaleID = table.Column<int>(type: "int", nullable: true),
                    ProductsShoppingCarID = table.Column<int>(type: "int", nullable: true),
                    QuotationID = table.Column<int>(type: "int", nullable: true),
                    SalesPriceID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCarID = table.Column<int>(type: "int", nullable: true),
                    UnlockedStockUnlockedID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categorys_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categorys",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_Products_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID");
                });

            migrationBuilder.CreateTable(
                name: "Inventorys",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameInventory = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NewQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorys", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_Inventorys_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_Inventorys_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID");
                });

            migrationBuilder.CreateTable(
                name: "IsOnSales",
                columns: table => new
                {
                    IsOnSaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    CostProduct = table.Column<double>(type: "float", nullable: false),
                    ValueSalePercent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsOnSales", x => x.IsOnSaleID);
                    table.ForeignKey(
                        name: "FK_IsOnSales_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_IsOnSales_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID");
                });

            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    QuotationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MethodOfPaymentID = table.Column<int>(type: "int", nullable: false),
                    NameUser = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<double>(type: "float", nullable: false),
                    QuantityProduct = table.Column<int>(type: "int", nullable: false),
                    DataReq = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Delete = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.QuotationID);
                    table.ForeignKey(
                        name: "FK_Quotations_MethodOfPayments_MethodOfPaymentID",
                        column: x => x.MethodOfPaymentID,
                        principalTable: "MethodOfPayments",
                        principalColumn: "MethodOfPaymentID");
                    table.ForeignKey(
                        name: "FK_Quotations_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_Quotations_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID");
                });

            migrationBuilder.CreateTable(
                name: "SalesPrices",
                columns: table => new
                {
                    SalesPriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoID = table.Column<int>(type: "int", nullable: false),
                    PriceSellProduct = table.Column<double>(type: "float", nullable: false),
                    CostsProduct = table.Column<double>(type: "float", nullable: false),
                    CostsOthers = table.Column<double>(type: "float", nullable: false),
                    TypeOfCosts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delete = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPrices", x => x.SalesPriceID);
                    table.ForeignKey(
                        name: "FK_SalesPrices_Products_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCars",
                columns: table => new
                {
                    ShoppingCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumerID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MethodOfPaymentID = table.Column<int>(type: "int", nullable: false),
                    QuantityOfProdut = table.Column<int>(type: "int", nullable: false),
                    PriceProduct = table.Column<double>(type: "float", nullable: false),
                    WeightProduct = table.Column<double>(type: "float", nullable: false),
                    Delete = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCars", x => x.ShoppingCarID);
                    table.ForeignKey(
                        name: "FK_ShoppingCars_Costumers_CostumerID",
                        column: x => x.CostumerID,
                        principalTable: "Costumers",
                        principalColumn: "CostumerID");
                    table.ForeignKey(
                        name: "FK_ShoppingCars_MethodOfPayments_MethodOfPaymentID",
                        column: x => x.MethodOfPaymentID,
                        principalTable: "MethodOfPayments",
                        principalColumn: "MethodOfPaymentID");
                    table.ForeignKey(
                        name: "FK_ShoppingCars_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "UnlockedStocks",
                columns: table => new
                {
                    UnlockedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnlockedStocks", x => x.UnlockedID);
                    table.ForeignKey(
                        name: "FK_UnlockedStocks_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseRequests",
                columns: table => new
                {
                    PurchaseRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuotationID = table.Column<int>(type: "int", nullable: false),
                    Okay = table.Column<bool>(type: "bit", nullable: false),
                    MethodOfPayment = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CampaignProvider = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseRequests", x => x.PurchaseRequestID);
                    table.ForeignKey(
                        name: "FK_PurchaseRequests_Quotations_QuotationID",
                        column: x => x.QuotationID,
                        principalTable: "Quotations",
                        principalColumn: "QuotationID");
                });

            migrationBuilder.CreateTable(
                name: "InvoicesReceivables",
                columns: table => new
                {
                    InvoicesReceivableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumerID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ShoppingCarID = table.Column<int>(type: "int", nullable: false),
                    MethodOfPaymentID = table.Column<int>(type: "int", nullable: false),
                    AmountProduct = table.Column<int>(type: "int", nullable: false),
                    PriceProduct = table.Column<double>(type: "float", nullable: false),
                    WeightProduct = table.Column<double>(type: "float", nullable: false),
                    Delete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountCoupon = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicesReceivables", x => x.InvoicesReceivableID);
                    table.ForeignKey(
                        name: "FK_InvoicesReceivables_Costumers_CostumerID",
                        column: x => x.CostumerID,
                        principalTable: "Costumers",
                        principalColumn: "CostumerID");
                    table.ForeignKey(
                        name: "FK_InvoicesReceivables_MethodOfPayments_MethodOfPaymentID",
                        column: x => x.MethodOfPaymentID,
                        principalTable: "MethodOfPayments",
                        principalColumn: "MethodOfPaymentID");
                    table.ForeignKey(
                        name: "FK_InvoicesReceivables_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_InvoicesReceivables_ShoppingCars_ShoppingCarID",
                        column: x => x.ShoppingCarID,
                        principalTable: "ShoppingCars",
                        principalColumn: "ShoppingCarID");
                });

            migrationBuilder.CreateTable(
                name: "ProductsShoppingCars",
                columns: table => new
                {
                    ProductsShoppingCarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ShoppingCarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsShoppingCars", x => x.ProductsShoppingCarID);
                    table.ForeignKey(
                        name: "FK_ProductsShoppingCars_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_ProductsShoppingCars_ShoppingCars_ShoppingCarID",
                        column: x => x.ShoppingCarID,
                        principalTable: "ShoppingCars",
                        principalColumn: "ShoppingCarID");
                });

            migrationBuilder.CreateTable(
                name: "InputInvoices",
                columns: table => new
                {
                    InputInvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseRequestID = table.Column<int>(type: "int", nullable: false),
                    NameProvider = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MethodOfPayment = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NumberII = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateII = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    QtdProduct = table.Column<int>(type: "int", nullable: false),
                    PriceProduct = table.Column<double>(type: "float", nullable: false),
                    CampaignProvider = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputInvoices", x => x.InputInvoiceID);
                    table.ForeignKey(
                        name: "FK_InputInvoices_PurchaseRequests_PurchaseRequestID",
                        column: x => x.PurchaseRequestID,
                        principalTable: "PurchaseRequests",
                        principalColumn: "PurchaseRequestID");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceOrders",
                columns: table => new
                {
                    InvoiceOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoicesReceivableID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceOrders", x => x.InvoiceOrderID);
                    table.ForeignKey(
                        name: "FK_InvoiceOrders_InvoicesReceivables_InvoicesReceivableID",
                        column: x => x.InvoicesReceivableID,
                        principalTable: "InvoicesReceivables",
                        principalColumn: "InvoicesReceivableID");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceToPays",
                columns: table => new
                {
                    InvoiceToPayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InputInvoiceID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceToPays", x => x.InvoiceToPayID);
                    table.ForeignKey(
                        name: "FK_InvoiceToPays_InputInvoices_InputInvoiceID",
                        column: x => x.InputInvoiceID,
                        principalTable: "InputInvoices",
                        principalColumn: "InputInvoiceID");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceToReceives",
                columns: table => new
                {
                    InvoiceToReceiveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceOrderID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceToReceives", x => x.InvoiceToReceiveID);
                    table.ForeignKey(
                        name: "FK_InvoiceToReceives_InvoiceOrders_InvoiceOrderID",
                        column: x => x.InvoiceOrderID,
                        principalTable: "InvoiceOrders",
                        principalColumn: "InvoiceOrderID");
                });

            migrationBuilder.CreateTable(
                name: "SendOrders",
                columns: table => new
                {
                    SendOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceOrderID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendOrders", x => x.SendOrderID);
                    table.ForeignKey(
                        name: "FK_SendOrders_InvoiceOrders_InvoiceOrderID",
                        column: x => x.InvoiceOrderID,
                        principalTable: "InvoiceOrders",
                        principalColumn: "InvoiceOrderID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costumers_LoginUser",
                table: "Costumers",
                column: "LoginUser");

            migrationBuilder.CreateIndex(
                name: "IX_InputInvoices_PurchaseRequestID",
                table: "InputInvoices",
                column: "PurchaseRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventorys_ProductID",
                table: "Inventorys",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventorys_WarehouseID",
                table: "Inventorys",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceOrders_InvoicesReceivableID",
                table: "InvoiceOrders",
                column: "InvoicesReceivableID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesReceivables_CostumerID",
                table: "InvoicesReceivables",
                column: "CostumerID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesReceivables_MethodOfPaymentID",
                table: "InvoicesReceivables",
                column: "MethodOfPaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesReceivables_ProductID",
                table: "InvoicesReceivables",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesReceivables_ShoppingCarID",
                table: "InvoicesReceivables",
                column: "ShoppingCarID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceToPays_InputInvoiceID",
                table: "InvoiceToPays",
                column: "InputInvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceToPays_InvoiceToPayID",
                table: "InvoiceToPays",
                column: "InvoiceToPayID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceToReceives_InvoiceOrderID",
                table: "InvoiceToReceives",
                column: "InvoiceOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceToReceives_InvoiceToReceiveID",
                table: "InvoiceToReceives",
                column: "InvoiceToReceiveID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IsOnSales_ProductID",
                table: "IsOnSales",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_IsOnSales_WarehouseID",
                table: "IsOnSales",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InventoryID",
                table: "Products",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InvoicesReceivableID",
                table: "Products",
                column: "InvoicesReceivableID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IsOnSaleID",
                table: "Products",
                column: "IsOnSaleID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductsShoppingCarID",
                table: "Products",
                column: "ProductsShoppingCarID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_QuotationID",
                table: "Products",
                column: "QuotationID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SalesPriceID",
                table: "Products",
                column: "SalesPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShoppingCarID",
                table: "Products",
                column: "ShoppingCarID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnlockedStockUnlockedID",
                table: "Products",
                column: "UnlockedStockUnlockedID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WarehouseID",
                table: "Products",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsShoppingCars_ProductID",
                table: "ProductsShoppingCars",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsShoppingCars_ShoppingCarID",
                table: "ProductsShoppingCars",
                column: "ShoppingCarID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequests_QuotationID",
                table: "PurchaseRequests",
                column: "QuotationID");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_MethodOfPaymentID",
                table: "Quotations",
                column: "MethodOfPaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_ProductID",
                table: "Quotations",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_ProviderID",
                table: "Quotations",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesPrices_ProdutoID",
                table: "SalesPrices",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_SendOrders_InvoiceOrderID",
                table: "SendOrders",
                column: "InvoiceOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCars_CostumerID",
                table: "ShoppingCars",
                column: "CostumerID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCars_MethodOfPaymentID",
                table: "ShoppingCars",
                column: "MethodOfPaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCars_ProductID",
                table: "ShoppingCars",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_UnlockedStocks_ProductID",
                table: "UnlockedStocks",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LoginUser",
                table: "Users",
                column: "LoginUser",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Inventorys_InventoryID",
                table: "Products",
                column: "InventoryID",
                principalTable: "Inventorys",
                principalColumn: "InventoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_InvoicesReceivables_InvoicesReceivableID",
                table: "Products",
                column: "InvoicesReceivableID",
                principalTable: "InvoicesReceivables",
                principalColumn: "InvoicesReceivableID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_IsOnSales_IsOnSaleID",
                table: "Products",
                column: "IsOnSaleID",
                principalTable: "IsOnSales",
                principalColumn: "IsOnSaleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsShoppingCars_ProductsShoppingCarID",
                table: "Products",
                column: "ProductsShoppingCarID",
                principalTable: "ProductsShoppingCars",
                principalColumn: "ProductsShoppingCarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Quotations_QuotationID",
                table: "Products",
                column: "QuotationID",
                principalTable: "Quotations",
                principalColumn: "QuotationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SalesPrices_SalesPriceID",
                table: "Products",
                column: "SalesPriceID",
                principalTable: "SalesPrices",
                principalColumn: "SalesPriceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShoppingCars_ShoppingCarID",
                table: "Products",
                column: "ShoppingCarID",
                principalTable: "ShoppingCars",
                principalColumn: "ShoppingCarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnlockedStocks_UnlockedStockUnlockedID",
                table: "Products",
                column: "UnlockedStockUnlockedID",
                principalTable: "UnlockedStocks",
                principalColumn: "UnlockedID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Costumers_Users_LoginUser",
                table: "Costumers");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventorys_Products_ProductID",
                table: "Inventorys");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesReceivables_Products_ProductID",
                table: "InvoicesReceivables");

            migrationBuilder.DropForeignKey(
                name: "FK_IsOnSales_Products_ProductID",
                table: "IsOnSales");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsShoppingCars_Products_ProductID",
                table: "ProductsShoppingCars");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotations_Products_ProductID",
                table: "Quotations");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesPrices_Products_ProdutoID",
                table: "SalesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCars_Products_ProductID",
                table: "ShoppingCars");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlockedStocks_Products_ProductID",
                table: "UnlockedStocks");

            migrationBuilder.DropTable(
                name: "InvoiceToPays");

            migrationBuilder.DropTable(
                name: "InvoiceToReceives");

            migrationBuilder.DropTable(
                name: "SendOrders");

            migrationBuilder.DropTable(
                name: "InputInvoices");

            migrationBuilder.DropTable(
                name: "InvoiceOrders");

            migrationBuilder.DropTable(
                name: "PurchaseRequests");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Inventorys");

            migrationBuilder.DropTable(
                name: "InvoicesReceivables");

            migrationBuilder.DropTable(
                name: "IsOnSales");

            migrationBuilder.DropTable(
                name: "ProductsShoppingCars");

            migrationBuilder.DropTable(
                name: "Quotations");

            migrationBuilder.DropTable(
                name: "SalesPrices");

            migrationBuilder.DropTable(
                name: "UnlockedStocks");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "ShoppingCars");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "MethodOfPayments");
        }
    }
}

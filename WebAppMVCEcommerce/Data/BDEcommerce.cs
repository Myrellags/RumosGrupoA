using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Accounting;
using WebAppMVCEcommerce.Models.Billing;
using WebAppMVCEcommerce.Models.Personal;
using WebAppMVCEcommerce.Models.Purchase;
using WebAppMVCEcommerce.Models.Stock;

namespace WebAppMVCEcommerce.Data
{
	public class BDEcommerce : DbContext
	{
		#region "Mapeando as tabelas do BD através das classes"

		public DbSet<InvoiceToPay> InvoiceToPays { get; set; }
		public DbSet<InvoiceToReceive> InvoiceToReceives { get; set; }
		public DbSet<Costumer> Costumers { get; set; }
		public DbSet<InvoiceOrder> InvoiceOrders { get; set; }
		public DbSet<InvoicesReceivable> InvoicesReceivables { get; set; }
		public DbSet<ProductsShoppingCar> ProductsShoppingCars { get; set; }
		public DbSet<Provider> Providers { get; set; }
		public DbSet<SendOrder> SendOrders { get; set; }
		public DbSet<ShoppingCar> ShoppingCars { get; set; }
		public DbSet<UnlockedStock> UnlockedStocks { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categorys { get; set; }
		public DbSet<Inventory> Inventorys { get; set; }
		public DbSet<IsOnSale> IsOnSales { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<SalesPrice> SalesPrices { get; set; }
		public DbSet<Warehouse> Warehouses { get; set; }
		public DbSet<Quotation> Quotations { get; set; }
		public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
		public DbSet<MethodOfPayment> MethodOfPayments { get; set; }
		public DbSet<InputInvoice> InputInvoices { get; set; }

		#endregion

		#region "Conexão com o BD"
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BDEcommerce;Trusted_Connection=True;");
		}
		#endregion

		#region "Enforce On Delete ForeignKey"
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
			{
				foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
			}
		}
		#endregion
	}
}

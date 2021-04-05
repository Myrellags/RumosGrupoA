using System;

public class EcommerceContext : DBContext
{
	public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }
	public DbSet<Cost> Costs { get; set; }
	public DbSet<Costumer> Costumers { get; set; }
	public DbSet<InputInvoice> InputInvoices { get; set; }
	public DbSet<Inventory> Inventorys { get; set; }
	public DbSet<OrderNote> OrderNotes { get; set; }
	public DbSet<PaymentWay> PaymentWays { get; set; }
	public DbSet<People> Peoples { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<ProductCategory> ProductCategorys { get; set; }
	public DbSet<Provider> Provides { get; set; }
	public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
	public DbSet<Quotation> Quotations { get; set; }
	public DbSet<SalesOrder> SalesOrder { get; set; }
	public DbSet<TypeExit> TypeExit { get; set; }
	public DbSet<User> Users { get; set; }		

}

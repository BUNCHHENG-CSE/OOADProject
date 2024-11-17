namespace OOADPRO.Models;

public class OrderDetail
{
    public int OrderDetailID { get; set; }
    public int OrderQty { get; set; }
    public float UnitPrice { get; set; }
    public Category? CategoryID { get; set; }
    public Order? OrderID { get; set; }
    public Products? ProductsID { get; set; }


}

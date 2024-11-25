using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using OOADPRO.Models;

namespace OOADPRO.Utilities;

public static class OrderFunc
{
    public static IEnumerable<Order> GetAllOrder(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllOrder", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Order > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        if (reader != null && reader.HasRows == true)
        {
            var queryAbles = reader.Cast<IDataRecord>().AsQueryable();
            foreach (var record in queryAbles)
            {
                yield return reader.ToDisplayOrder();
            }
        }
        reader?.Close();
    }

    public static Order GetOneOrder(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneOrder", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting category with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Order? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayOrder();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddOrder(SqlConnection con, Order order)
    {
        SqlCommand cmd = new SqlCommand("spInsertOrder", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DateOrder", order.DateOrder);
        cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);

        try
        {
            int affectedRows = cmd.ExecuteNonQuery();
            return affectedRows > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to add new order > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool UpdateOrder(SqlConnection con, Order order)
    {
        SqlCommand cmd = new SqlCommand("spUpdateOrder", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
        cmd.Parameters.AddWithValue("@DateOrder", order.DateOrder);
        cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);

        try
        {
            int affectedRows = cmd.ExecuteNonQuery();
            return affectedRows > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to update order ID {order.OrderID} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool DeleteOrder(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spDeleteOrder", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@OrderID", id);

        try
        {
            int affectedRows = cmd.ExecuteNonQuery();
            return affectedRows > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete order ID {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool InsertOrderDetail(SqlConnection con, OrderDetail order)
    {
        SqlCommand cmd = new SqlCommand("spInsertOrderDetail", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@oid", order.Order.OrderID);
        cmd.Parameters.AddWithValue("@pid", order.Products.ProductsID);
        cmd.Parameters.AddWithValue("@oq", order.OrderQty);
        cmd.Parameters.AddWithValue("@up", order.UnitPrice);

        try
        {
            int affectedRows = cmd.ExecuteNonQuery();
            return affectedRows > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to insert order detail > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }


    }

    public static int CreateNewOrder(SqlConnection con, DateTime dateOrder, float totalPrice, int customerId)
    {
        SqlCommand cmd = new SqlCommand("spCreateNewOrder", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DateOrder", dateOrder);
        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
        cmd.Parameters.AddWithValue("@CustomerID", customerId);
        SqlParameter outputParam = new SqlParameter("@NewOrderID", SqlDbType.Int)
        {
            Direction = ParameterDirection.Output
        };
        cmd.Parameters.Add(outputParam);
        cmd.ExecuteNonQuery();
        return Convert.ToInt32(outputParam.Value);
    }

    public static int CreateNewCustomer(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spCreateNewCustomer", con);
        cmd.CommandType = CommandType.StoredProcedure;

        try
        {
            int newCustomerId = Convert.ToInt32(cmd.ExecuteScalar());
            return newCustomerId; 
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to create new customer: {ex.Message}");
        }
    }

}

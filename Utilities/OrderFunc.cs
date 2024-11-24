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
    public static IEnumerable<Order> GetAllOrders(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spGetAllOrders", con);
        SqlDataReader? reader = null;

        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all orders > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }

        if (reader != null && reader.HasRows)
        {
            var queryAbles = reader.Cast<IDataRecord>().AsQueryable();
            foreach (var record in queryAbles)
            {
                yield return record.ToDisplayOrder();
            }
        }

        reader?.Close();
    }
    public static Order? GetOrderById(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spGetOrderById", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@OrderID", id);
        SqlDataReader? reader = null;

        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting order by ID {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }

        Order? result = null;
        if (reader != null && reader.HasRows && reader.Read())
        {
            result = reader.ToOrderAllData();
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
   

}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using OOADPRO.Models;

namespace OOADPRO.Utilities;

//public static class OrderFunc
//{
//    public static IEnumerable<Order> GetAllProducts(SqlConnection con)
//    {
//        SqlCommand cmd = new SqlCommand("spReadAllProducts", con);
//        SqlDataReader? reader = null;
//        try
//        {
//            reader = cmd.ExecuteReader();
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Error in getting all Products > {ex.Message}");
//        }
//        finally
//        {
//            cmd.Dispose();
//        }
//        if (reader != null && reader.HasRows == true)
//        {
//            var queryAbles = reader.Cast<IDataRecord>().AsQueryable();
//            foreach (var record in queryAbles)
//            {
//                yield return reader.ToDisplayProduct();
//            }
//        }
//        reader?.Close();
//    }
//    public static IEnumerable<Products> GetAllProductID(SqlConnection con)
//    {
//        SqlCommand cmd = new SqlCommand("spReadAllStaffID", con);
//        SqlDataReader? reader = null;
//        try
//        {
//            reader = cmd.ExecuteReader();
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Error in getting all Products ID > {ex.Message}");
//        }
//        finally
//        {
//            cmd.Dispose();
//        }
//        if (reader != null && reader.HasRows == true)
//        {
//            var queryAbles = reader.Cast<IDataRecord>().AsQueryable();
//            foreach (var record in queryAbles)
//            {
//                yield return reader.ToDisplayProductsID();
//            }
//        }
//        reader?.Close();
//    }

//    public static Products GetProductById(SqlConnection con, int id)
//    {
//        SqlCommand cmd = new SqlCommand("spReadOneProduct", con);
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.Parameters.AddWithValue("@id", id);

//        SqlDataReader reader = null;
//        Products product = null;

//        try
//        {
//            reader = cmd.ExecuteReader();
//            if (reader.HasRows)
//            {
//                reader.Read();
//                product = new Products
//                {
//                    ProductsID = reader.GetInt32(reader.GetOrdinal("ProductsID")),
//                    ProductName = reader.GetString(reader.GetOrdinal("ProductsName")),
//                    ProductsPrice = reader.GetDecimal(reader.GetOrdinal("Price")),
//                    ProductDescription = reader.GetString(reader.GetOrdinal("ProductsDescription")),
//                    ProductsStock = reader.GetInt32(reader.GetOrdinal("ProductsStock")),
//                    ProductImage = reader["ProductsImage"] as byte[]
//                };
//            }
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Error retrieving product: {ex.Message}");
//        }
//        finally
//        {
//            reader?.Close();
//        }

//        return product;
//    }




//    public static Products GetOneProducts(SqlConnection con, int id)
//    {
//        SqlCommand cmd = new SqlCommand("spReadOneProduct", con);
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.Parameters.AddWithValue("@id", id);
//        SqlDataReader? reader = null;
//        try
//        {
//            reader = cmd.ExecuteReader();
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Error in getting Products with id, {id} > {ex.Message}");
//        }
//        finally
//        {
//            cmd.Dispose();
//        }
//        Products? result = null;
//        if (reader != null && reader.HasRows == true)
//        {
//            if (reader.Read() == true)
//            {
//                result = reader.ToProductsAllData();
//            }
//        }
//        reader?.Close();
//        return result;
//    }

//    public static bool AddProducts(SqlConnection con, Products product)
//    {
//        SqlCommand cmd = new SqlCommand("spInsertProduct", con);
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.Parameters.AddWithValue("@pn", product.ProductName);
//        cmd.Parameters.AddWithValue("@pm", product.ProductsPrice);
//        cmd.Parameters.AddWithValue("@ps", product.ProductsStock);
//        cmd.Parameters.AddWithValue("@pd", product.ProductDescription);
//        cmd.Parameters.AddWithValue("@pi", product.ProductImage);
//        cmd.Parameters.AddWithValue("@cid", product.Category.CategoryID);
//        try
//        {
//            int effected = cmd.ExecuteNonQuery();
//            return effected > 0;
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Failed in adding new staff > {ex.Message}");

//        }
//        finally
//        {
//            cmd.Dispose();
//        }
//    }
//    public static bool UpdateProducts(SqlConnection con, Products product)
//    {
//        SqlCommand cmd = new SqlCommand("spUpdateProduct", con);
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.Parameters.AddWithValue("@pn", product.ProductName);
//        cmd.Parameters.AddWithValue("@pm", product.ProductsPrice);
//        cmd.Parameters.AddWithValue("@ps", product.ProductDescription);
//        cmd.Parameters.AddWithValue("@pi", product.ProductDescription);
//        cmd.Parameters.AddWithValue("@pd", product.ProductImage);
//        try
//        {
//            int effected = cmd.ExecuteNonQuery();
//            return (effected > 0);
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Failed in updating existing staff > {ex.Message}");
//        }
//        finally
//        {
//            cmd.Dispose();
//        }
//    }
//}

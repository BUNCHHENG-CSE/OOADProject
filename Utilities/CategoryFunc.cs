using Microsoft.Data.SqlClient;
using OOADPRO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPRO.Utilities;

public class CategoryFunc
{
    public static IEnumerable<Category> GetAllCategory(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllCategory", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Category > {ex.Message}");
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
                yield return reader.ToDisplayCategory();
            }
        }
        reader?.Close();
    }
    public static User GetOneCategory(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneCategory", con);
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
        User? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToCategoryAllData();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddCategory(SqlConnection con, Category category)
    {
        SqlCommand cmd = new SqlCommand("spInsertUser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@cateN", category.CategoryName);
        cmd.Parameters.AddWithValue("@cateDes",category.CategoryDescription);

        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new category > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }

    }
    public static bool UpdateCategory(SqlConnection con, Category category)
    {
        SqlCommand cmd = new SqlCommand("spUpdateCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", category.CategoryID);
        cmd.Parameters.AddWithValue("@cateN", category.CategoryName);
        cmd.Parameters.AddWithValue("@cateDes", category.CategoryDescription);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing category > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}

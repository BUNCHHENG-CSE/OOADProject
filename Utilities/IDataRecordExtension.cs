using OOADPRO.Models;
using System.Data;

namespace OOADPRO.Utilities;

public static class IDataRecordExtension
{
    #region Get Staff INFO. To Display On ListBox and Display Staff on TextBox When Click on ListBox
    public static Staff ToDisplayStaff(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);
        index = record.GetOrdinal("StaffName");
        string? staffname = record.GetString(index);
        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);
        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];
        return new Staff()
        {
            StaffID = id,
            StaffName = staffname,
            StaffPosition = staffposition,
            Photo = photo
        };
    }
    public static Staff ToDisplayStaffID(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);

        return new Staff()
        {
            StaffID = id,
        };
    }

    public static Staff ToStaffAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("StaffName");
        string? staffname = record.GetString(index);


        index = record.GetOrdinal("Gender");
        string? gender = record.GetString(index);

        index = record.GetOrdinal("BirthDate");
        DateTime birthdate = record.GetDateTime(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        index = record.GetOrdinal("StaffAddress");
        string? staffaddress = record.GetString(index);

        index = record.GetOrdinal("ContactNumber");
        string? contactnumber = record.GetString(index);


        index = record.GetOrdinal("HiredDate");
        DateTime hireddate = record.GetDateTime(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];



        return new Staff()
        {
            StaffID = id,
            StaffName = staffname,
            Gender = gender,
            BirthDate = birthdate,
            StaffPosition = staffposition,
            StaffAddress = staffaddress,
            ContactNumber = contactnumber,
            HiredDate = hireddate,
            Photo = photo,

        };
    }

    public static Staff ToStaffNameKHandPosition(this IDataReader record)
    {

        int index = record.GetOrdinal("StaffName");
        string? staffname = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        return new Staff()
        {
            StaffName = staffname,
            StaffPosition = staffposition,
        };
    }

    #endregion

    #region Get Staff INFO. To Display On ListBox and Display Product
    public static Products ToDisplayProduct(this IDataRecord record)
    {
        return new Products
        {
            ProductsID = record.GetInt32(record.GetOrdinal("ProductsID")),
            ProductName = record.GetString(record.GetOrdinal("ProductsName")),
            ProductsPrice = record.GetDecimal(record.GetOrdinal("Price")),
            ProductDescription = record.IsDBNull(record.GetOrdinal("ProductsDescription")) ? null : record.GetString(record.GetOrdinal("ProductsDescription")),
            ProductsStock = record.IsDBNull(record.GetOrdinal("ProductsStock")) ? 0 : record.GetInt32(record.GetOrdinal("ProductsStock")),
            ProductImage = record.IsDBNull(record.GetOrdinal("ProductsImage")) ? null : (byte[])record["ProductsImage"],
            Category = new Category
            {
                CategoryID = record.GetInt32(record.GetOrdinal("CategoryID")),
                CategoryName = record.IsDBNull(record.GetOrdinal("CategoryName")) ? null : record.GetString(record.GetOrdinal("CategoryName")),
                CategoryDescription = record.IsDBNull(record.GetOrdinal("CategoryDescription")) ? null : record.GetString(record.GetOrdinal("CategoryDescription"))
            }
        };
    }
    public static Products ToDisplayProductsID(this IDataReader record)
    {
        int index = record.GetOrdinal("ProductsID");
        int pid = record.GetInt32(index);

        return new Products()
        {
            ProductsID = pid,
        };
    }

    public static Products ToProductsAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("ProductsID");
        int pid = record.GetInt32(index);

        index = record.GetOrdinal("ProductName");
        string? productname = record.GetString(index);

        index = record.GetOrdinal("ProductsPrice");
        int productsprice = record.GetInt32(index);

        index = record.GetOrdinal("ProductDescription");
        string? productdescription = record.GetString(index);

        index = record.GetOrdinal("ProductsStock");
        int productstock = record.GetInt32(index);

        index = record.GetOrdinal("ProductImage");
        byte[] productimage = null;
        if (!record.IsDBNull(index)) productimage = (byte[])record[index];


        return new Products()
        {
            ProductsID = pid,

            ProductName = productname,

            ProductsPrice = productsprice,

            ProductDescription = productdescription,

            ProductsStock = productstock,

            ProductImage = productimage

        };
    }


    #endregion


    #region Get User INFO. To Display On ListBox and Display User on TextBox When Click on ListBox
    public static User ToDisplayUser(this IDataReader record)
    {
        int index = record.GetOrdinal("UserID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Username");
        string? username = record.GetString(index);
        return new User()
        {
            UserID = id,
            Username = username,
        };
    }
    public static User ToUserAllData(this IDataReader record)
    {
        Staff staff = new Staff();

        int index = record.GetOrdinal("UserID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Username");
        string? username = record.GetString(index);

        index = record.GetOrdinal("Password");
        string? password = record.GetString(index);

        index = record.GetOrdinal("StaffID");
        staff.StaffID = record.GetInt32(index);

        index = record.GetOrdinal("StaffName");
        staff.StaffName = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        staff.StaffPosition = record.GetString(index);

        return new User()
        {
            UserID = id,
            Username = username,
            Password = password,
            Staff = staff
        };
    }
    #endregion

}

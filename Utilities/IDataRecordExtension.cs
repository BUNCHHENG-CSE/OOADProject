using OOADPRO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

}

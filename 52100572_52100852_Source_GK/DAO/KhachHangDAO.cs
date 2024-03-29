﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }

        public List<KhachHangDTO> GetKhachHangList()
        {
            string query = "SELECT * FROM KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<KhachHangDTO> khachHangList = new List<KhachHangDTO>();
            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    KhachHangID = row["KhachHangID"].ToString(),
                    Ten = row["Ten"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    Email = row["Email"].ToString()
                };
                khachHangList.Add(khachHang);
            }
            return khachHangList;
        }

        public KhachHangDTO GetKhachHangByID(string khachHangID)
        {
            string query = "SELECT * FROM KhachHang WHERE KhachHangID = @KhachHangID";
            object[] parameters = { khachHangID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if(data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    KhachHangID = row["KhachHangID"].ToString(),
                    Ten = row["Ten"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    Email = row["Email"].ToString()
                };
                return khachHang;
            }
            else
            {
                return null;
            }
        }

        public KhachHangDTO GetKhachHangByPhone(string phone)
        {
            string query = "SELECT * FROM KhachHang WHERE SoDienThoai = @SoDienThoai ";
            object[] parameters = { phone };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    KhachHangID = row["KhachHangID"].ToString(),
                    Ten = row["Ten"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    Email = row["Email"].ToString()
                };
                return khachHang;
            }
            else
            {
                return null;
            }
        }        
        public KhachHangDTO GetKhachHangByEmail(string email)
        {
            string query = "SELECT * FROM KhachHang WHERE Email = @Email ";
            object[] parameters = { email };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    KhachHangID = row["KhachHangID"].ToString(),
                    Ten = row["Ten"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    Email = row["Email"].ToString()
                };
                return khachHang;
            }
            else
            {
                return null;
            }
        }

        public bool AddKhachHang(KhachHangDTO khachHang)
        {
            string query = "INSERT INTO KhachHang (Ten, SoDienThoai, DiaChi, Email) " +
                           " VALUES ( @Ten , @SoDienThoai , @DiaChi , @Email ) ";
            object[] parameters = { khachHang.Ten, khachHang.SoDienThoai, khachHang.DiaChi, khachHang.Email };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateKhachHang(KhachHangDTO khachHang)
        {
            string query = "UPDATE KhachHang " +
                           "SET Ten = @Ten , SoDienThoai = @SoDienThoai , DiaChi = @DiaChi , Email = @Email " +
                           "WHERE KhachHangID = @KhachHangID";
            object[] parameters = { khachHang.Ten, khachHang.SoDienThoai, khachHang.DiaChi, khachHang.Email, khachHang.KhachHangID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteKhachHang(string khachHangID)
        {
            string query = "DELETE FROM KhachHang WHERE KhachHangID = @KhachHangID";
            object[] parameters = { khachHangID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<KhachHangDTO> SearchKhachHangByNameAndPhone(string keyword)
        {
            string query = "SELECT * FROM KhachHang WHERE Ten LIKE @TenKhachHang or SoDienThoai LIKE @SoDienThoai";
            object[] parameters = { "%" + keyword + "%", "%" + keyword + "%" };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<KhachHangDTO> result = new List<KhachHangDTO>();
            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    KhachHangID = row["KhachHangID"].ToString(),
                    Ten = row["Ten"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    Email = row["Email"].ToString(),
                    DiaChi = row["DiaChi"].ToString()
                };
                result.Add(khachHang);
            }
            return result;
        }
    }

}

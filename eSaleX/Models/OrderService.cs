﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSaleX.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void Insertorder()
        {

        }
        /// <summary>
        /// 刪除訂單by id
        /// </summary>
        public void DeleteorderById()
        {

        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void Updateorder()
        {

        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetorderById(string id)
        {
            Models.Order result = new Order();
            result.CustID = "GSS";
            result.CustName = "瑞陽資訊";
            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
            List<Models.Order> result = new List<Order>();
            result.Add(new Order() { CustID = "GSS", CustName = "瑞陽資訊", OrderID = 1, OrderDate = DateTime.Parse("2017/04/07")});
            result.Add(new Order() { CustID = "NPOIS", CustName = "往阮資訊", OrderID = 2, OrderDate = DateTime.Parse("2017/04/08") });
            return result;
        }

        internal void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
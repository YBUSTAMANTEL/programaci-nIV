﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEL;
using BLL;

namespace Principal.wfrmOrders
{
    public partial class wfrmOrderDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarOrder();
            }
        }

        private void CargarOrder()
        {
            int orderID = Convert.ToInt32(Session["orderID"].ToString());
            Order order = OrderBL.GetOrderById(orderID);

            OrderIDLabel.Text = order.OrderID.ToString();
            CustomerIDLabel.Text = order.CustomerID.ToString();
            EmployeeIDLabel.Text = order.EmployeeID.ToString();
            OrderDateLabel.Text = order.OrderDate.ToString();
            RequiredDateLabel.Text = order.RequiredDate.ToString();
            ShippedDateLabel.Text = order.ShippedDate.ToString();
            ShipViaLabel.Text = order.ShipVia.ToString();
            FreightLabel.Text = order.Freight.ToString();
            ShipNameLabel.Text = order.ShipName;
            IdStateLabel.Text = order.IdState.ToString();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object 
        AnStock = (clsStock)Session["AnStock"];
        //display stock for this entry
        Response.Write(AnStock.StockID);
        Response.Write(AnStock.StockPrice);
        Response.Write(AnStock.StockName);
        Response.Write(AnStock.StockLastAdded);
        Response.Write(AnStock.StockDescription);
        Response.Write(AnStock.StockAvailability);

    }
}
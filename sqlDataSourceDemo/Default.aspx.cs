using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sqlDataSourceDemo
{
    public partial class Default : System.Web.UI.Page
    {
 
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void restaurantButton_Click(object sender, EventArgs e)
        {
            RestaurantGrid.Visible = true;
            RestaurantDetailView.Visible = true;
        }

        protected void customerButton_Click(object sender, EventArgs e)
        {
            customerGrid.Visible = true;
            customerDetailsView.Visible = true;
        }

          protected void tableButton_Click(object sender, EventArgs e)
        {
            tableGrid.Visible = true;
            tableDetailsView.Visible = true;
        }

          protected void reservationButton_Click(object sender, EventArgs e)
        {
            reservationGrid.Visible = true;
            ReservationDetailView.Visible = true;
        }

         protected void DishButton_Click(object sender, EventArgs e)
        {
            DishGrid.Visible = true;
            DishDetailsView.Visible = true;
        }
        
        
    }
}
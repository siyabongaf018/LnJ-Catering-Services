using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LnJ_Catering_Services.Models
{
    public class Food
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LnJ;Integrated Security=True");
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string FirstLetter { get; set; }
        public string LastLetter { get; set; }

        /* Dish getters and setters */
        public int DishID { get; set; }
        public string DishImagePath  { get; set; }
        public string DishName { get; set; }
        public string DishRating { get; set; }
        public double DishPrice { get; set; }

        /* Menu getters and setters */
        public int MenuID { get; set; }
        public string MenuImagePath { get; set; }
        public string MenuName { get; set; }
        public string MenuRating { get; set; }
        public string MenuDescription { get; set; }
        public double MenuPrice { get; set; }

        /* Reviews getters and setters */
        public int RevID { get; set; }
        public string RevName { get; set; }
        public string RevSurname { get; set; }
        public string Review { get; set; }
        public string RevRating { get; set; }

        /* Reviews getters and setters */
        public string Address { get; set; }
        public int OrderId { get; set; }


        public Food()
        {
            this.UserID = 0;
            this.Name = "No name";
            this.Surname = "No surname";
        }
        public bool add_user_review(string name, string surname, string review, string rating)
        {
            bool valid;
            int rowcount = 0;
            string sql = $"INSERT INTO  tblReview (Name, Surname,Review,Rating) VALUES ('{name}','{surname}','{review}','{rating}')";
            con.Open();
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.CommandType = CommandType.Text;

            rowcount = cmdSelect.ExecuteNonQuery();
            DataTable dt = new DataTable();

            con.Close();

            if (rowcount > 0)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            con.Close();
            return valid;
        }
    }

    public class CartData
    {
        public string Image { get; set; }
        public string DishesName { get; set; }
        public string DishesDescription { get; set; }
        public double Price { get; set; }
        public int DishID { get; set; }

    }
}

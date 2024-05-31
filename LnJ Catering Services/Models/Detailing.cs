using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.IO;

namespace LnJ_Catering_Services.Models
{
    public class Detailing
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LnJ;Integrated Security=True");
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Detailing()
        {
            this.UserID = "";
            this.Name = "No name";
            this.Surname = "No surname";
        }
        public Detailing(string UserID, string name, string surname)
        {
            UserID = UserID;
            Name = name;
            Surname = surname;
        }



        public List<Detailing> getStudents()
        {
            List<Detailing> ls = new List<Detailing>();
            SqlDataAdapter cmdSelect = new SqlDataAdapter($"select * from tblUsers", con);
            DataTable dt = new DataTable();
            DataRow dr;

            con.Open();
            cmdSelect.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    ls.Add(new Detailing((string)dr[0], (string)dr[1], (string)dr[2]));
                }
            }

            con.Close();

            return ls;

        }
        public List<Customers> getCustomers()
        {
            List<Customers> ls;
            try
            {
                string sql = $"select * from tblUsers where UserType = 'User'";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();


                con.Open();
                cmdSelect.Fill(ds);
                ls = new List<Customers>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ls.Add(new Customers
                    {
                        Name = dr["Name"].ToString(),
                        Surname = dr["Surname"].ToString(),
                        Email = dr["Email"].ToString(),
                    });
                }

                con.Close();

            }
            catch (System.Exception)
            {

                throw;
            }

            return ls;


        }
        public bool isSuccessLogin(string username, string Pass)
        {
            bool valid;
            SqlDataAdapter cmdSelect = new SqlDataAdapter($"SELECT * FROM tblUsers WHERE Email = '{username}' AND Password = '{Pass}'", con);
            DataTable dt = new DataTable();

            con.Open();
            cmdSelect.Fill(dt);

            if (dt.Rows.Count > 0)
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
        public bool isAdmin(string username)
        {
            bool valid;
            SqlDataAdapter cmdSelect = new SqlDataAdapter($"SELECT * FROM tblUsers WHERE Email = '{username}' AND UserType = 'Admin'", con);
            DataTable dt = new DataTable();

            con.Open();
            cmdSelect.Fill(dt);

            if (dt.Rows.Count > 0)
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
        public bool register_User(string name, string surname, string username, string pass, string type)
        {
            bool valid;
            int rowcount = 0;
            string sql = $"INSERT INTO  tblUsers (Name, Surname,Email,Password,UserType) VALUES ('{name}','{surname}','{username}','{pass}','{type}')";
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
        public List<Food> GetMenuDetail()
        {
            List<Food> ls;
            try
            {
                string sql = $"select * from tblMenu where Category ='Menu'";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();


                con.Open();
                cmdSelect.Fill(ds);
                ls = new List<Food>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ls.Add(new Food
                    {

                        MenuID = int.Parse(dr["MenuID"].ToString()),
                        MenuImagePath = dr["MenuImagePath"].ToString(),
                        MenuName = dr["MenuName"].ToString(),
                        MenuRating = dr["MenuRating"].ToString(),
                        MenuDescription = dr["MenuDescription"].ToString(),
                        MenuPrice = double.Parse(dr["MenuPrice"].ToString())
                    });
                }

                con.Close();

            }
            catch (System.Exception)
            {

                throw;
            }

            return ls;

        }


        /// <summary>
        /// Get search results for the search function 
        /// </summary>
        /// <param name="search"></param>
        /// <returns>List<Food></returns>
        public List<Food> GetSearchResultMenuDetail(string search)
        {
            List<Food> ls;
            try
            {
                string sql = $"select * from tblMenu where MenuName like '%{search}%' OR MenuDescription like '%{search}%'";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();


                con.Open();
                cmdSelect.Fill(ds);
                ls = new List<Food>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ls.Add(new Food
                    {

                        MenuID = int.Parse(dr["MenuID"].ToString()),
                        MenuImagePath = dr["MenuImagePath"].ToString(),
                        MenuName = dr["MenuName"].ToString(),
                        MenuRating = dr["MenuRating"].ToString(),
                        MenuDescription = dr["MenuDescription"].ToString(),
                        MenuPrice = double.Parse(dr["MenuPrice"].ToString())
                    });
                }

                con.Close();

            }
            catch (System.Exception)
            {

                throw;
            }

            return ls;

        }


        public List<Food> GetReviewsDetail()
        {
            List<Food> ls2;
            /* reviews */
            try
            {
                string sql2 = $"select * from tblReview";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql2, con);
                DataSet ds2 = new DataSet();


                con.Open();
                cmdSelect.Fill(ds2);
                ls2 = new List<Food>();
                foreach (DataRow dr in ds2.Tables[0].Rows)
                {
                    ls2.Add(new Food
                    {
                        RevID = int.Parse(dr["ReviewId"].ToString()),
                        RevName = dr["Name"].ToString(),
                        RevSurname = dr["Surname"].ToString(),
                        Review = dr["Review"].ToString(),
                        RevRating = dr["Rating"].ToString(),
                    });
                }

                con.Close();

            }
            catch (System.Exception)
            {

                throw;
            }
            return ls2;

        }
        public List<Food> GetDishDetail()
        {
            List<Food> ls2;
            /* reviews */
            try
            {
                string sql2 = $"select * from tblMenu where Category ='Dish'";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql2, con);
                DataSet ds2 = new DataSet();


                con.Open();
                cmdSelect.Fill(ds2);
                ls2 = new List<Food>();
                foreach (DataRow dr in ds2.Tables[0].Rows)
                {
                    ls2.Add(new Food
                    {

                        DishID = int.Parse(dr["MenuID"].ToString()),
                        DishImagePath = dr["MenuImagePath"].ToString(),
                        DishName = dr["MenuName"].ToString(),
                        DishRating = dr["MenuRating"].ToString(),
                        DishPrice = double.Parse(dr["MenuPrice"].ToString()),
                    });
                }

                con.Close();

            }
            catch (System.Exception)
            {

                throw;
            }
            return ls2;

        }


        public List<Food> GetOrders()
        {
            List<Food> ls2;
            /* reviews */
            try
            {
                string sql2 = $"select * from tblOrder";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql2, con);
                DataSet ds2 = new DataSet();


                con.Open();
                cmdSelect.Fill(ds2);
                ls2 = new List<Food>();
                foreach (DataRow dr in ds2.Tables[0].Rows)
                {
                    ls2.Add(new Food
                    {

                        DishID = int.Parse(dr["MenuID"].ToString()),
                        UserID = int.Parse(dr["UsersId"].ToString()),
                        Address = dr["UserAddress"].ToString(),
                        OrderId = int.Parse(dr["OrderId"].ToString())
                    });
                }

                con.Close();

            }
            catch (System.Exception)
            {

                throw;
            }
            return ls2;

        }

        //DELETE FROM [Cart] WHERE [UsersId] = 100 AND [MenuID] = 1
        //cart  functionality
        public bool AddToCart(string userID, int DishID)
        {
            bool valid;
            int rowcount = 0;
            string sql = $"INSERT INTO  Cart  VALUES ({DishID},{userID})";
            con.Open();
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.CommandType = CommandType.Text;

            rowcount = cmdSelect.ExecuteNonQuery();


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

        /// <summary>
        /// Remove a specific item in the cart for a specific user. it returns true if item is removed romeved and false if not removed
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="DishID"></param>
        /// <returns>bool  </returns>
        public bool RemoveItemFromCart(string userID, int DishID)
        {
            bool valid;
            int rowcount = 0;
            string sql = $"DELETE FROM [Cart] WHERE [UsersId] = {userID} AND [MenuID] = {DishID} ";
            con.Open();
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.CommandType = CommandType.Text;

            rowcount = cmdSelect.ExecuteNonQuery();


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

        /// <summary>
        /// Removes all the item in the cart for a specific user.it returns true if all item are removed romeved and false if not removed
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>boolean</returns>
        public bool CheckOutRemoveAllItemFromCart(string userID)
        {
            bool valid;
            int rowcount = 0;
            string sql = $"DELETE FROM [Cart] WHERE [UsersId] = {userID} ";
            con.Open();
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.CommandType = CommandType.Text;

            rowcount = cmdSelect.ExecuteNonQuery();


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

        public bool AddToOrder(string userID, int DishID, string Address)
        {
            bool valid;
            int rowcount = 0;
            string sql = $"INSERT INTO  [tblOrder]  VALUES ({DishID},{userID},'{Address}')";
            con.Open();
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.CommandType = CommandType.Text;

            rowcount = cmdSelect.ExecuteNonQuery();


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

        public int GetUserID(string username, string Pass)
        {
            int userID = 0;
            SqlDataAdapter cmdSelect = new SqlDataAdapter($"SELECT * FROM tblUsers WHERE Email = '{username}' AND Password = '{Pass}'", con);
            DataTable dt = new DataTable();

            con.Open();
            cmdSelect.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                userID = int.Parse(dt.Rows[0][0].ToString());
            }
            else
            {
                return userID;
            }

            con.Close();
            return userID;
        }

        //for reviews 
        public string[] GetUserNameAndSurname(string uid)
        {
            string[] NameAndSurname = new string[2];
            SqlDataAdapter cmdSelect = new SqlDataAdapter($"SELECT * FROM tblUsers WHERE UsersId = {uid}", con);
            DataTable dt = new DataTable();

            con.Open();
            cmdSelect.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                NameAndSurname[0] = dt.Rows[0][1].ToString();
                NameAndSurname[1] = dt.Rows[0][2].ToString();
            }
            else
            {
                return NameAndSurname;
            }

            con.Close();
            return NameAndSurname;
        }
        public List<Food> CartDataDisplay(string uid)
        {
            List<Food> displays;
            string sql = "";

            try
            {
                sql = $"select * from tblMenu m inner join [Cart] c on m.MenuID = c.MenuID " +
                    $"where c.[UsersId] = {uid}; ";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();


                con.Open();
                cmdSelect.Fill(ds);
                displays = new List<Food>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    displays.Add(new Food
                    {
                        MenuID = int.Parse(dr["MenuID"].ToString()),
                        MenuImagePath = dr["MenuImagePath"].ToString(),
                        MenuName = dr["MenuName"].ToString(),
                        MenuRating = dr["MenuRating"].ToString(),
                        MenuDescription = dr["MenuDescription"].ToString(),
                        MenuPrice = double.Parse(dr["MenuPrice"].ToString())
                    });
                }

                con.Close();


            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {

            }
            return displays;

        }


        //Admin edit menu item
        /// <summary>
        /// gets the selected menu details
        /// </summary>
        /// <param name="MenuID"></param>
        /// <returns></returns>
        public List<Food> GetEditMenuResultMenuDetail(int MenuID)
        {
            List<Food> ls;
            try
            {
                string sql = $"select * from tblMenu where [MenuID] = {MenuID} ";
                SqlDataAdapter cmdSelect = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();


                con.Open();
                cmdSelect.Fill(ds);
                ls = new List<Food>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ls.Add(new Food
                    {

                        MenuID = int.Parse(dr["MenuID"].ToString()),
                        MenuImagePath = dr["MenuImagePath"].ToString(),
                        MenuName = dr["MenuName"].ToString(),
                        MenuRating = dr["MenuRating"].ToString(),
                        MenuDescription = dr["MenuDescription"].ToString(),
                        MenuPrice = double.Parse(dr["MenuPrice"].ToString())
                    });
                }

                con.Close();

            }
            catch (System.Exception)
            {

                throw;
            }

            return ls;

        }

        /// <summary>
        /// updates the details for a specific menu 
        /// </summary>
        /// <param name="DishID"></param>
        /// <param name="MenuName"></param>
        /// <param name="MenuRating"></param>
        /// <param name="MenuDescription"></param>
        /// <param name="MenuPrice"></param>
        /// <returns>bool </returns>
        public bool UpdateMenuDetails(int DishID, string MenuName, int MenuRating, string MenuDescription, double MenuPrice)
        {
            bool valid;
            int rowcount = 0;
            string MenuPrice2 = MenuPrice.ToString().Replace(",", ".");
            string sql = $"UPDATE tblMenu SET [MenuName] = '{MenuName}', [MenuRating] = '{MenuRating}', [MenuDescription] = '{MenuDescription}', [MenuPrice] = {MenuPrice} WHERE [MenuID] = {DishID} ";
            con.Open();
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.CommandType = CommandType.Text;

            rowcount = cmdSelect.ExecuteNonQuery();


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
}



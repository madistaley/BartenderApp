using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Bartender_cs.Models
{
    public class Drink
    {
        SqlConnection connection = new SqlConnection();
        List<Drink> ListOfDrinks = new List<Drink>();

        public String DrinkName { get; set; }
        public String DrinkName { get; set; }
        public String DrinkName { get; set; }

        Drink drink = null;

        public List<Drink> GetDrink()
        {
            connection.ConnectionString = "";
            conection.Open();
            using (connection)
            {
                SqlCommand command = new SqlCommand("Select * from Drinks", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    drink = new Drink();
                    drink.DrinkName = "Cosmo";
                    drink.DrinkIngredients = "Vodka, Cranberry juice";
                    drink.DrinkPrice = 7.00;


                    ListOfDrinks.Add(drink);
                }

                return ListOfDrinks;
            }
        }
    }

}












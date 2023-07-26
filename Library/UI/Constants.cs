using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.UI
{
    public class Constants
    {
        public class LoginPageConstants
        {
            public string UserName = "//*[@id='user-name']";
            public string Password = "//*[@id='password']";
            public string LoginButton = "//*[@id='login-button']";
        }

        public class Products
        {
            public string ListofProducts = "//*[@class='inventory_list']/div";
            public string AddProductButton = "//button[contains(@id,'add-to-cart')]";
            public string RemoveProductButton = "//button[contains(@id,'remove')]";
            public string CartValue = "//*[@id='shopping_cart_container']/a/span";
            public string Filter = "//*[@class='product_sort_container']";
            public string FilterOptions = "//*[@class='product_sort_container']/option";
        }

        public class Cart
        {
            public string CartValue = "//*[@id='shopping_cart_container']/a/span";
            public string YourCartLabel = "//*[@id='header_container']/div[2]/span";
            public string CartItem = "//*[@class='cart_item']";
            public string CheckoutButton = "//button[@id='checkout']";
            public string CheckoutPageLabel = "//button[@id='checkout']";
        }
    }
}

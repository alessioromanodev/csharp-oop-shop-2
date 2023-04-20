﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product;

namespace shop
{
    public class Shop
    {
        //ATTRIBUTI
        private string name;
        private readonly string city;
        private readonly string address;
        private readonly int houseNumber;
        List<Product> productList;

        //COSTRUTTORE
        public Shop(string name = "", string city = "", string address = "", int houseNumber = 0)
        {
            this.name = name;
            this.city = city;
            this.address = address;
            this.houseNumber = houseNumber;
            this.productList = new List<Product>();
        }

        //PROPRIETÀ
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string City
        {
            get
            {
                return this.City;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
        }

        public int HouseNumber
        {
            get
            {
                return this.houseNumber;
            }
        }

        //METODI
        public void AddProductToList(Product productToAdd)
        {
            this.productList.Add(productToAdd);
        }

        public void AddListToProductList(List<Product> listToAdd)
        {
            foreach (Product productToAdd in listToAdd)
            {
                this.productList.Add(productToAdd);
            }
        }

        public string ShopRappresentationString()
        {
            string listRappresentation =
            "=========================== PRODOTTI ===========================\n";
            foreach (Product product in this.productList)
            {
                listRappresentation += product.ProductRappresentationString() + "\n";
            }

            string shopRappresentation =
            $"================================================================\n" +
            $"Name: {this.name}\n" +
            $"City: {this.city}\n" +
            $"Adress: {this.address}\n" +
            $"House number: {this.houseNumber}\n" +
            $"================================================================\n \n" +
            listRappresentation;
            ;

            return shopRappresentation;
        }
    }
}
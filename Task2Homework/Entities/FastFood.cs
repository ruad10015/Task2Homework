﻿using Task2Homework.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Task2Homework.Entities
{
    public class FastFood : IProduct
    {
        // public properties : 
        public int Id { get; set; }

        [DisplayName("Product Name : ")]
        [Required(ErrorMessage ="Product Name is required ! ")]
        [MinLength(4,ErrorMessage ="Product Name Length must be at minimum 4 !")]
        public string Name { get; set; }

        [DisplayName("Prodcut Description  :")]
        [Required(ErrorMessage ="Product Description Required !")]
        [MinLength(7,ErrorMessage ="Description length must be at minimum 7 !")]
        public string Description { get; set; }

        [DisplayName("Product Original Price (Without Discount) : ")]
        [Required(ErrorMessage ="Price required !")]
        [Range(1,50,ErrorMessage ="Product Price must be around 1 and 50 !")]
        public int Price { get; set; }

        [DisplayName("Product Discount : ")]
        [Required(ErrorMessage ="Product Discount Required !")]
        [Range(1,100,ErrorMessage ="Product Discount must be around 1 and 100 !")]
        public int Discount { get; set; }

        // parametric constructor :
        public FastFood(int id,string name, string description, int price, int discount)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Discount = discount;
        }

        // default constructor : 
        public FastFood() {}

        // to string override : 
        public override string ToString()
        {
            return $@"
ID : {Id}
Name : {Name}
Description : {Description}
Original Price : ${Price}
Discount Percentage : {Discount}%
";
        }

        // other methods : 
    }
}

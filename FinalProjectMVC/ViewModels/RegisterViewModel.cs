﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectMVC.ViewModels
{
    //Create RegisterViewModel to be able to validate user input in the register form
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(7)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Verify Password")]
        public string Verify { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Price")]
        public string UsersPrice { get; set; }

        [Required]
        [Display(Name = "Area")]
        public string UsersArea { get; set; }

        [Required]
        [Display(Name = "Care Level")]
        public string UsersCareLevel { get; set; }

        //Create RegisterViewModel constructor to take in arguments
        /**public RegisterViewModel(string username, string password, string verify, string email)
        {
            Username = username;
            Password = password;
            Verify = verify;
            Email = email;
        }**/

        public List<SelectListItem> Prices { get; set; }
        public List<SelectListItem> Areas { get; set; }
        public List<SelectListItem> CareLevels { get; set; }

        public RegisterViewModel()
        {
            Prices = new List<SelectListItem>();

            Prices.Add(new SelectListItem
            {
                Value = "Low",
                Text = "Low Price Range"
            });

            Prices.Add(new SelectListItem
            {
                Value = "Medium",
                Text = "Medium Price Range"
            });

            Prices.Add(new SelectListItem
            {
                Value = "High",
                Text = "High Price Range"
            });

            Areas = new List<SelectListItem>();

            Areas.Add(new SelectListItem
            {
                Value = "South",
                Text = "South Kansas City"
            });

            Areas.Add(new SelectListItem
            {
                Value = "Central",
                Text = "Central Kansas City"
            });

            Areas.Add(new SelectListItem
            {
                Value = "North",
                Text = "North Kansas City"
            });

            CareLevels = new List<SelectListItem>();

            CareLevels.Add(new SelectListItem
            {
                Value = "High",
                Text = "High Level of Care"
            });

            CareLevels.Add(new SelectListItem
            {
                Value = "Medium",
                Text = "Medium Level of Care"
            });

            CareLevels.Add(new SelectListItem
            {
                Value = "Low",
                Text = "Low Level of Care"
            });
        }
    }
}

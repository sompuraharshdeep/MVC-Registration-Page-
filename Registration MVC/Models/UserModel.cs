using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration_MVC.Models
{
    public class UserModel
    {
        public UserModel()
        {

        }
        public UserModel(int id,string name,string emailid,string pass,string mobile,string url,string gender,int sid)
        {
            this.UserId = id;
            this.UserName = name;
            this.EmailId = emailid;
            this.Password = pass;
            this.MobileNumber = mobile;
            this.UserImageUrl = url;
            this.Gender = gender;
            this.StateId = new StateModel() { StateId = sid };
        }
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Enter User Name!")]
        [Display(Name ="User Name *")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter User Email Id!")]
        [Display(Name = "User Email Id*")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Enter User Password!")]
        [Display(Name = "User Password *")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password!")]
        [Display(Name = "Confirm Password *")]
        [Compare("Password",ErrorMessage ="Confirm password not Match!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Enter User Mobile Number!")]
        [Display(Name = "User Mobile Number*")]
        public string MobileNumber { get; set; }

        public string UserImageUrl { get; set; }
        public string Gender { get; set; }
        [Required]
        public StateModel StateId { get; set; }

        public List<StateModel>GetStates
        {
            get
            {
                return new List<StateModel>()
                {
                    new StateModel()
                    {
                        StateId = 1,
                        StateName = "GJ"
                    },
                     new StateModel()
                    {
                        StateId = 2,
                        StateName = "NYC"
                    }
                };
            }
        }
    }
}
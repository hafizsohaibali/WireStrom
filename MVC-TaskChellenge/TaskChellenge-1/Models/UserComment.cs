using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskChellenge_1.Models
{
    public class UserComment
    {
        [Required]
        public string Comment { get; set; }

        [Required]
        public string UserName { get; set; }

        public UserComment() { 
        }

        public UserComment(string Comment, string UserName)
        {
            this.Comment = Comment;
            this.UserName = UserName;
        }
    }
}
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    public class Contribution
    {
        [Key]
        public string ContributionID { get; set; }
        [ForeignKey("Student")]
        public string StudentID { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public List<Comment> Comments { get; set; }
        public string Image {  get; set; }
        public DateTime Published { get; set; }
        public bool AgreeOnTerm { get; set; }
        public string Expired { get; set; }
    
    }
}

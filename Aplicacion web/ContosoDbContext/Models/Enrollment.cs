using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoDbContext.Models
{
    public class Enrollment
    {
        ///<summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("Course")]
        [Required(ErrorMessage = "CourseId is required ")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("Student")]
        [Required(ErrorMessage = "StudentId is required ")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "the length is of 50")]
        [Required(ErrorMessage = "Grade is required ")]
        public string Grade { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoDbContext.Models
{
    public class Student
    {
        ///<summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "the length is of 50")]
        [Required(ErrorMessage = "LastName is required ")]
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "the length is of 50")]
        [Required(ErrorMessage = "FirstName is required ")]
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "EnrollomentDate is required ")]
        public DateTime EnrollomentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
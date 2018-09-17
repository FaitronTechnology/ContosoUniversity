using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoDbContext.Models
{
    public class Course
    {
        ///<summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// ///<summary>
        /// 
        /// </summary>
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "the length is of 50")]
        [Required(ErrorMessage = "Title is required ")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Credits is required ")]
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
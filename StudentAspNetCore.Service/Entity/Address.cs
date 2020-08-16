using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public class Address
    {
        //add address with complex Type
        //If change customized table follow below:
        //
        //[Column("Stress")]
        //[MaxLength(40)]
        //[Required]
        //if change with fluent api let's config in StudentContext: at modelBuilder.
        // 
        public int Id { get; set; }
        public int StudentId { get; set; }
       
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Student Student { get; set; }
       
    }
}

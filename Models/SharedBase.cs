using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Models
{
    public class SharedBase
    {
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; set; }
    }
}

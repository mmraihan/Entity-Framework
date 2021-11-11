using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models.FluentApiRelationship
{
    public class Fluent_Publisher
    {
        public int Publisher_Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}

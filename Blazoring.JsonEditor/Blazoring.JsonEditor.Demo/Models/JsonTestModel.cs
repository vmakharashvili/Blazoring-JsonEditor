using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazoring.JsonEditor.Demo.Models
{
    public class JsonTestModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string JsonValue { get; set; }
    }
}

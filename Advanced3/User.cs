using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Advanced3
{
    public class User
    {
        public Guid Id { get; set; }
        //[JsonPropertyName("Hello")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            //return JsonSerializer.Serialize(this);
            return $"{Id} {FirstName} {LastName} {Age}";
        }
    }
}

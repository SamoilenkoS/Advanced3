using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Advanced3
{
    class Program
    {
        static void SerializeAndWrite()
        {
            User[] users = new User[5];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = $"Vasya{i}",
                    LastName = $"Pupkin{i}",
                    Age = 30 + i
                };
            }

            using (var streamWriter = new StreamWriter("data.txt"))
            {
                streamWriter.Write(JsonSerializer.Serialize(users));
            }
        }

        static void ReadAndDeserialize()
        {
            string input;
            using (var streamReader = new StreamReader("data.txt"))
            {
                input = streamReader.ReadLine();
            }

            var users = JsonSerializer.Deserialize<IEnumerable<User>>(input);

            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }

        static void Main(string[] args)
        {
            SerializeAndWrite();
            ReadAndDeserialize();
        }
    }
}

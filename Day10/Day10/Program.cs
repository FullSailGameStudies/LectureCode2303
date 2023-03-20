using Newtonsoft.Json;

namespace Day10
{

    public enum Superpower
    {
        Money, Flight, Strength, Speed, Swimming
    }

    class Superhero
    {
        public string Name { get; set; }
        public string Secret { get; set; }
        public Superpower Power { get; set;}
    }

    /*
        ╔══════════╗ 
        ║ File I/O ║
        ╚══════════╝ 

        3 things are required for File I/O:
        1) Open the file
        2) read/write to the file
        3) close the file


        TIPS:
            use File.ReadAllText to open,read,close the file in 1 statement
            the using() statement can ensure that the file is closed

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ╔══════════╗ 
                ║ File I/O ║
                ╚══════════╝ 

                [  Open the file  ]
                [  Write to the file  ]
                [  Close the file  ]
             
                you need the path to the file
                    use full path ( drive + directories + filename )
                    or use relative path ( directories + filename )
                    or current directory ( filename )


                
                using (StreamWriter sw = new StreamWriter(filePath)) // this line opens the file to write to it
                {                
                    //these lines write to the file
                    sw.Write("Batman");
                    sw.Write(54);
                    sw.Write(13.7);
                    sw.Write(true);

                }//this closes the file

            */

            string directories = @"C:\temp\2303"; //use @ in front of the string to ignore escape sequences inside the string
            string fileName = "tempFile.txt";
            string fullPath = Path.Combine(directories, fileName); //use Path.Combine to get the proper directory separators

            char delimiter = '$';
            if (File.Exists(fullPath))
            {
                //#1: open the file
                using (StreamWriter sw = new StreamWriter(fullPath))//open/create the file
                {
                    //#2: write to the file
                    sw.Write("Batman > Aquaman. MOST TRUE!");
                    sw.Write(delimiter);
                    sw.Write(5);
                    sw.Write(delimiter);
                    sw.Write(420);
                    sw.Write(delimiter);
                    sw.Write(13.7);
                    sw.Write(delimiter);
                    sw.Write(true);
                }//#3: CLOSE THE FILE!
            }
            else
                Console.WriteLine($"{fullPath} does not exist STEEV!");




            /*
                ╔═══════════════════╗ 
                ║ Splitting Strings ║
                ╚═══════════════════╝ 

                taking 1 string a separating it into multiple pieces of data

                use the string's Split method

            */
            string csvString = "Batman;Bruce Wayne;Bats;The Dark Knight*Joker*The Riddler*Bane*Poison Ivy*Calendar Man";
            string[] data = csvString.Split(new char[] { ';' , '*' });

            /*
                CHALLENGE 1:

                    read the data in from the file above and split the line to get the data
             
            */

            //#1: open the file
            using (StreamReader sr = new StreamReader(fullPath))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                string[] data1 = line.Split(delimiter);
                foreach (string data2 in data1) 
                { 
                    Console.WriteLine(data2); 
                }
            }//#3 close the file




            /*
                ╔═════════════╗ 
                ║ Serializing ║
                ╚═════════════╝ 

                Saving the state (data) of objects

            */
            List<Superhero> JLA = new List<Superhero>();
            JLA.Add(new Superhero() { Name = "Batman", Secret = "Bruce Wayne", Power = Superpower.Money });
            JLA.Add(new Superhero() { Name = "Superman", Secret = "Clark Kent", Power = Superpower.Flight });
            JLA.Add(new Superhero() { Name = "Wonder Woman", Secret = "Diana Prince", Power = Superpower.Strength });
            JLA.Add(new Superhero() { Name = "Flash", Secret = "Barry Allen", Power = Superpower.Speed });
            JLA.Add(new Superhero() { Name = "Aquaman", Secret = "Arthur Curry", Power = Superpower.Swimming });

            fullPath = "JLA.json";
            //WriteAllText: does all 3 - open, writes, closes the file
            File.WriteAllText(fullPath, JsonConvert.SerializeObject(JLA, Formatting.Indented));

            //using (StreamWriter sw = new StreamWriter(fullPath))
            //{
            //    using (JsonTextWriter jtw = new JsonTextWriter(sw))
            //    {
            //        JsonSerializer jtwSerializer = new JsonSerializer();
            //        jtw.Formatting = Formatting.Indented;
            //        jtwSerializer.Serialize(jtw, JLA);
            //    }
            //}





            /*
                ╔═══════════════╗ 
                ║ Deserializing ║
                ╚═══════════════╝ 

                Recreating the objects from the saved state (data) of objects

            */

            //ReadAllText: does all 3 - open, reads, closes the file
            if (File.Exists(fullPath))
            {
                string jlaText = File.ReadAllText(fullPath);

                try
                {
                    List<Superhero> otherJLA = JsonConvert.DeserializeObject<List<Superhero>>(jlaText);
                    foreach (var hero in otherJLA)
                    {
                        Console.WriteLine($"Hello citizen! I am {hero.Name} (aka {hero.Secret}). My superpower is {hero.Power}.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR! ERROR! file format error!");
                }
            }

        }
    }
}
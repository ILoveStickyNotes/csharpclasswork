using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Lists
    {
        public void Lists1()
        {
            var names = new List<string>();
            var exist = false;

            while (true)
            {
                Console.WriteLine("Enter a name");
                var name = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(name))
                {
                    foreach (var item in names)
                    {
                        if (item == name.ToLower())
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        names.Add(name.ToLower());
                    }
                }
                else
                {
                    break;
                }
            }
            if (names.Count() > 2)
            {
                Console.Write(names[0] + ", " + names[1] + ", and " + (names.Count() - 2) + " other people liked your post.\n" );
            }
            else if (names.Count() == 2)
            {
                Console.Write(names[0] + " and " + names[1] + "likes your post.\n");
            }
            else if (names.Count() == 1)
            {
                Console.WriteLine(names[0] + " likes your post.");
            }

        }

        public void Lists2()
        {
            Console.WriteLine("Enter your name so it can be reversed.");
            var name = Console.ReadLine();
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
                Console.WriteLine(name[i - 1]);
            }

            var reversed = new string(array);
            Console.WriteLine("Reversed: " + reversed);

        }
    }
}

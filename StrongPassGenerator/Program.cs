using System;

namespace StrongPassGenerator {
    internal class Program {
        static void Main(string[] args) {
           
            List<string> alfa = new List<string> {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };
            List<string> numbers = new List<string> {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
            };
            List<string> specials = new List<string> {
            "!", "@", "#", "$", "%", "&", "*"
            };

            Random random = new Random();
            
            string password = "";
            
            Console.WriteLine("-=--=--=--=--=--=--=--=--=-");
            Console.WriteLine("STRONG PASSWORD GENERATOR");
            Console.WriteLine("-=--=--=--=--=--=--=--=--=-");
            Console.Write("Enter the length of the password: ");   
            int leng = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= leng; i++) {
                int num = random.Next(1, 4);
                if (num == 1) {
                    int num2 = random.Next(0, 2);
                    if (num2 == 0) {
                        password += alfa[random.Next(0, alfa.Count)].ToUpper();
                    }
                    else {
                        password += alfa[random.Next(0, alfa.Count)];
                    }
                }
                else if (num == 2) {
                    password += numbers[random.Next(0, numbers.Count)];
                }
                else if (num == 3) {
                    password += specials[random.Next(0, specials.Count)];
                }
            }
            Console.WriteLine("Your password is: " + password);
        }
    }
}
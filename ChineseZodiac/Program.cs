using System;
using System.Text.RegularExpressions;

namespace ChineseZodiac
{
    public class Zodiac
    {
        static void Main(string[] args)
        {
            String Nickname = "", Birthmonth = ""; int Birthyear = 0, Birthdate = 0;

            bool Valid_Letter = true;

            while (Valid_Letter)
            {
                Regex regex_LetterOnly= new Regex ("^[a-zA-Z]+$");

                Console.Write("Enter your nickname: ");
                Nickname = Console.ReadLine();

                if (regex_LetterOnly.IsMatch(Nickname))
                {
                    Valid_Letter = false;
                }else
                {
                    Console.WriteLine("Error: Invalid Input... Letters Only");
                }
            }

            Regex regex_year = new Regex ("^\\d{4}$");
            Regex regex_days = new Regex("^(0?[1-9]|[1-2][0-9]|3[0-1])$");
            Regex regex_Month = new Regex("^(?i)(?:January|Jan|February|Feb|March|Mar|April|Apr|May|June|Jun|July|Jul|August|Aug|September|Sep|October|Oct|November|Nov|December|Dec|[1-9]|1[0-2])$");
            
            while (true)
            {
                Console.Write("Enter your birthmonth: ");
                Birthmonth = Console.ReadLine().ToLower();

                if (regex_Month.IsMatch(Birthmonth))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Invalid month format. Please enter a valid month in one of the following formats:");
                    Console.WriteLine("- Full month name (e.g., January, February)");
                    Console.WriteLine("- Abbreviated month name (e.g., Jan, Feb)");
                    Console.WriteLine("- Two-digit month number (1-12)");
                }

            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your birthdate: ");
                    Birthdate = Convert.ToInt32(Console.ReadLine());

                    if (regex_days.IsMatch(Birthdate.ToString()))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid number for the birthdate.");
                    }

                }
                catch (Exception e) 
                {
                    Console.WriteLine("Error: Invalid Input. Please enter a valid integer number.");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your birthyear: ");
                    Birthyear = Convert.ToInt32(Console.ReadLine());


                    if (regex_year.IsMatch(Birthyear.ToString()))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid number for the birthyear.");
                    }
                } 
                catch (Exception e)
                {
                    Console.WriteLine("Error: Invalid Input. Please enter a valid integer number.");
                }

            }

            Console.WriteLine();
             
            if (Birthmonth == "january" || Birthmonth == "jan" || Birthmonth == "1")
            {
                
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 19)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on January " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Capricornus.");
                    Console.WriteLine("Set ambitious goals and pursue them with determination. Your hard work will pay off in the long run.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 20 && Birthdate <= 31)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on January " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Aquarius.");
                    Console.WriteLine("Embrace your individuality and think outside the box. Your innovative ideas will inspire others.");
                    Console.WriteLine("========================================================");
                } 
                else if (Birthdate > 31)
                {
                    Console.WriteLine("Error: Invalid Birthdate... January only has 31 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate... ");
                }
            }
            else if (Birthmonth == "february" || Birthmonth == "feb" || Birthmonth == "2")
            {

                if (Birthyear % 4 == 0)
                {
                    if (Birthdate >= 1 && Birthdate <= 18)
                    {
                        Console.WriteLine("Congratulations! You were born in a leap year!");
                        Console.WriteLine("========================================================");
                        Console.WriteLine("You were born on February " + Birthdate + ", " + Birthyear);
                        Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Aquarius.");
                        Console.WriteLine("Embrace your individuality and think outside the box. Your innovative ideas will inspire others.");
                        Console.WriteLine("========================================================");
                    }
                    else if (Birthdate >= 19 && Birthdate <= 29)
                    {
                        Console.WriteLine("Congratulations! You were born in a leap year!");
                        Console.WriteLine("========================================================");

                        if(Birthdate == 29)
                        {
                            Console.WriteLine("OMG! You were a Leap year baby!");
                        }

                        Console.WriteLine("You were born on February " + Birthdate + ", " + Birthyear);
                        Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Pisces.");
                        Console.WriteLine("Trust your intuition and follow your dreams. Your imagination holds the key to boundless possibilities.");
                        Console.WriteLine("========================================================");
                    }
                    else if (Birthdate > 29)
                    {
                        Console.WriteLine("Error: Invalid Birthdate... February only has 29 days in a leap year");
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid Birthdate...");
                    }
                }
                else
                {
                    if (Birthdate >= 1 && Birthdate <= 18)
                    {
                        Console.WriteLine("========================================================");
                        Console.WriteLine("You were born on February " + Birthdate + ", " + Birthyear);
                        Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Aquarius.");
                        Console.WriteLine("Embrace your individuality and think outside the box. Your innovative ideas will inspire others.");
                        Console.WriteLine("========================================================");
                    }
                    else if (Birthdate >= 19 && Birthdate <= 28)
                    {
                        Console.WriteLine("========================================================");
                        Console.WriteLine("You were born on February " + Birthdate + ", " + Birthyear);
                        Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Pisces.");
                        Console.WriteLine("Trust your intuition and follow your dreams. Your imagination holds the key to boundless possibilities.");
                        Console.WriteLine("========================================================");
                    }
                    else if (Birthdate > 28)
                    {
                        Console.WriteLine("Error: Invalid Birthdate... February only has 28 days in a non-leap year");
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid Birthdate...");
                    }
                }
            }
            else if (Birthmonth == "march" || Birthmonth == "Mar" || Birthmonth == "3")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 20)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on March " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Pisces.");
                    Console.WriteLine("Trust your intuition and follow your dreams. Your imagination holds the key to boundless possibilities.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 21 && Birthdate <= 31)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on March " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Aries.");
                    Console.WriteLine("Get ready for an adventure! Your energetic nature will lead you to exciting new opportunities.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate > 31)
                {
                    Console.WriteLine("Error: Invalid Birthdate... March only has 31 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "april" || Birthmonth == "apr" || Birthmonth == "4")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 19)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on April " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Aries.");
                    Console.WriteLine("Get ready for an adventure! Your energetic nature will lead you to exciting new opportunities.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthyear >= 20 && Birthdate <= 30)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on April " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Taurus.");
                    Console.WriteLine("Slow down and enjoy the simple pleasures today. Take some time to appreciate the beauty around you.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate > 30)
                {
                    Console.WriteLine("Error: Invalid Birthdate... April only has 30 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "may" || Birthmonth == "5")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 20)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on May " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Taurus.");
                    Console.WriteLine("Slow down and enjoy the simple pleasures today. Take some time to appreciate the beauty around you.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 21 && Birthdate <= 31)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on May " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Gimini.");
                    Console.WriteLine("Your curiosity is at its peak. Embrace new ideas and experiences—they will lead to valuable insights.");
                    Console.WriteLine("========================================================");
                } 
                else if ( Birthdate > 31)
                {
                    Console.WriteLine("Error: Invalid Birthdate... May only has 31 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "june" || Birthmonth == "jun" || Birthmonth == "6")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 20)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on June " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Gemini.");
                    Console.WriteLine("Your curiosity is at its peak. Embrace new ideas and experiences—they will lead to valuable insights.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 21 && Birthdate <= 30)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on June " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Cancer.");
                    Console.WriteLine("Connect with your emotions today. Pay attention to your intuition—it will guide you in the right direction.");
                    Console.WriteLine("========================================================");
                } 
                else if (Birthdate > 30)
                {
                    Console.WriteLine("Error: Invalid Birthdate... June only has 30 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "july" || Birthmonth == "jul" || Birthmonth == "7")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 22)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on July " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Cancer.");
                    Console.WriteLine("Connect with your emotions today. Pay attention to your intuition—it will guide you in the right direction.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 23 && Birthdate <= 31)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on July " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Leo.");
                    Console.WriteLine("It's your time to shine! Let your creativity and passion drive you towards success.");
                    Console.WriteLine("========================================================");
                }
                else if(Birthdate > 31)
                {
                    Console.WriteLine("Error: Invalid Birthdate... July only has 31 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "august" || Birthmonth == "aug" || Birthmonth == "8")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 22)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on August " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Leo.");
                    Console.WriteLine("It's your time to shine! Let your creativity and passion drive you towards success.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 23 && Birthdate <= 31)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on August " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Virgo.");
                    Console.WriteLine("Focus on organization and productivity today. Tackling tasks with precision will bring great satisfaction.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate > 31)
                {
                    Console.WriteLine("Error: Invalid Birthdate... August only has 31 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "september" || Birthmonth == "sept" || Birthmonth == "9")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 22)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on September " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Virgo.");
                    Console.WriteLine("Focus on organization and productivity today. Tackling tasks with precision will bring great satisfaction.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 23 && Birthdate <= 30)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on September " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Libra.");
                    Console.WriteLine("Seek harmony in all aspects of your life. Balance is key to achieving peace and fulfillment.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 30)
                {
                    Console.WriteLine("Error: Invalid Birthdate... September only has 30 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "october" || Birthmonth == "oct" || Birthmonth == "10")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 22)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on October " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Libra.");
                    Console.WriteLine("Seek harmony in all aspects of your life. Balance is key to achieving peace and fulfillment.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 23 && Birthdate <= 31)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on October " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Scorpio.");
                    Console.WriteLine("Dive deep into your passions and desires. Transformation awaits those who embrace their true selves.");
                    Console.WriteLine("========================================================");
                } 
                else if (Birthdate > 31)
                {
                    Console.WriteLine("Error: Invalid Birthdate... October only has 31 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "november" || Birthmonth == "nov" || Birthmonth == "11")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 21)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on November " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Scorpio.");
                    Console.WriteLine("Dive deep into your passions and desires. Transformation awaits those who embrace their true selves.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 22 && Birthdate <= 30)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on November " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Sagittarius.");
                    Console.WriteLine("Embrace spontaneity and adventure today. Your optimistic outlook will lead to exciting discoveries.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate > 30)
                {
                    Console.WriteLine("Error: Invalid Birthdate... November only has 30 days");
                }
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else if (Birthmonth == "december" || Birthmonth == "dec" || Birthmonth == "12")
            {
                if (Birthyear % 4 == 0)
                {
                    Console.WriteLine("Congratulations! You were born in a leap year!");
                }

                if (Birthdate >= 1 && Birthdate <= 21)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on December " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Sagittarius.");
                    Console.WriteLine("Embrace spontaneity and adventure today. Your optimistic outlook will lead to exciting discoveries.");
                    Console.WriteLine("========================================================");
                }
                else if (Birthdate >= 22 && Birthdate <= 31)
                {
                    Console.WriteLine("========================================================");
                    Console.WriteLine("You were born on December " + Birthdate + ", " + Birthyear);
                    Console.WriteLine("Hello " + Nickname + ", your Zodiac Sign is Capricornus.");
                    Console.WriteLine("Set ambitious goals and pursue them with determination. Your hard work will pay off in the long run.");
                    Console.WriteLine("========================================================");
                } else if (Birthdate > 31)
                {
                    Console.WriteLine("Error: Invalid Birthdate... November only has 31 days");
                } 
                else
                {
                    Console.WriteLine("Error: Invalid Birthdate...");
                }
            }
            else 
            {
                Console.WriteLine("Error: Invalid Input...");
            }
        }
    }
}
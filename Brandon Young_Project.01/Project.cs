using System;


namespace Brandon_Young_Project._01

    {
    class Project { 

        static void Main()
        {
    

                string parOne;
                double varOne;

                string parTwo;
                double varTwo;

                bool parThree = false;
                double varThree = 1;

                while (true)
                {
                    //The user decides the shape
                    Console.Write("Enter \"triangle\", \"rectangle\", \"square\" or \"circle\", or type \"quit\" to leave: ");

                    var entry = Console.ReadLine();
                    if (entry.ToLower() == "triangle")
                    {
                        parOne = "base";
                        parTwo = "height";
                        parThree = true;
                    }
                    else if (entry.ToLower() == "rectangle")
                    {
                        parOne = "base";
                        parTwo = "height";
                    }
                    else if (entry.ToLower() == "square")
                    {
                        parOne = "side";
                        parTwo = "side again";
                    }
                    else if (entry.ToLower() == "circle")
                    {
                        parOne = "radius";
                        parTwo = "diameter";
                    }
                    else if (entry.ToLower() == "quit")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("This shape is not in the record.\n");
                        continue;
                    }

                    //The user enters the first variable
                    while (true)
                    {
                        Console.Write("Enter the " + parOne + ": ");

                        entry = Console.ReadLine();
                        try
                        {
                            varOne = double.Parse(entry);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.Write("Please enter a number!\n");
                            continue;
                        }
                    }

                    //The user enters the second variable
                    while (true)
                    {
                        Console.Write("Enter the " + parTwo + ": ");

                        entry = Console.ReadLine();
                        try
                        {
                            varTwo = double.Parse(entry);

                            //If the diamater isn't the double of the radius, there's a problem :P
                            if (parOne == "radius" && varTwo != (varOne * 2))
                            {
                                Console.Write("The diameter is twice the radius.\n");
                                continue;
                            }

                            break;

                        }
                        catch (FormatException)
                        {
                            Console.Write("Please enter a number!\n");
                            continue;
                        }
                    }

                    //If the user selected a triangle, we need the third side
                    if (parThree == true)
                    {
                        while (true)
                        {
                            Console.Write("Enter the third side: ");

                            entry = Console.ReadLine();
                            try
                            {
                                varThree = double.Parse(entry);
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.Write("Please enter a number!\n");
                                continue;
                            }
                        }

                    }

                    //The user selects what operation to perform
                    while (true)
                    {
                        Console.Write("Enter \"perimeter\" or \"area\": ");
                        entry = Console.ReadLine();

                        if (entry.ToLower() == "perimeter")
                        {
                            if (parThree == true)
                            {
                                Console.Write(Perimeter.Triangle(varOne, varTwo, varThree));
                            }
                            else if (parOne == "base")
                            {
                                Console.Write(Perimeter.Rectangle(varOne, varTwo));
                            }
                            else if (parOne == "side")
                            {
                                Console.Write(Perimeter.Square(varOne));
                            }
                            else
                            {
                                Console.Write(Perimeter.Circle(varOne));
                            }
                            Console.Write("\n");
                            break;
                        }
                        else if (entry.ToLower() == "area")
                        {
                            if (parThree == true)
                            {
                                Console.Write(Area.Triangle(varOne, varTwo));
                            }
                            else if (parOne == "base")
                            {
                                Console.Write(Area.Rectangle(varOne, varTwo));
                            }
                            else if (parOne == "side")
                            {
                                Console.Write(Area.Square(varOne));
                            }
                            else
                            {
                                Console.Write(Area.Circle(varOne));
                            }
                            Console.Write("\n");
                            break;
                        }
                        else
                        {
                            Console.Write("Please choose either area or perimeter.\n");
                            continue;
                        }
                    }
                }
            }
        }
    }


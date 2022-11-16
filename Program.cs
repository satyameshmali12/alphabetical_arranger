#region Description
// This class will help to arrange A string's list in the Alphabetical Order
// You may feel what's this and why, instead we can use the Sort function of the ArrayList or the List
// but wait just try to make it and see you much time you take to make it without using the Sort function of the array 
// do let me know how you made it
#endregion

using System.Collections;


namespace Alphabetical_Arranger
{

    public class Array_Formatter
    {

        public ArrayList alphabets = new ArrayList() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


        // to know which is the prior one or which one will come first
        public bool is_it_greator(string first_value, string second_value)
        {
            // in this function the first_value is compared to he second_value
            // if the first_value and the second_value is same then false is writtened
            // if the the second_value lenght exceed's the first value count then the value if returned without any further confuguration
            bool is_greator = false;

            for (var i = 0; i < first_value.Length; i++)
            {

                if (second_value.Length > i)
                {
                    var first_value_priority = alphabets.IndexOf(first_value[i].ToString());

                    var second_value_priority = alphabets.IndexOf(second_value[i].ToString());

                    if (first_value_priority < second_value_priority)
                    {
                        return true;
                    }

                    else if (first_value_priority != second_value_priority)
                    {
                        return is_greator;
                    }

                }
                else
                {
                    return is_greator;
                }

            }
            return is_greator;


        }


        // to arrange the string arr in the alphabetical order
        public ArrayList get_in_alphabetical_order(ArrayList string_list)
        {


            // Arranger string_list = _string_list;
            Array_Formatter func = new Array_Formatter();

            ArrayList edited_ray = new ArrayList();

            foreach (string item in string_list)
            {
                var index = string_list.IndexOf(item);

                var insertion_index = edited_ray.Count;
                var Length = insertion_index;

                if (edited_ray.Count != 0)
                {
                    for (int i = Length - 1; i >= 0; i--)
                    {
                        var is_it_greator = func.is_it_greator(item, edited_ray[i].ToString());
                        if (is_it_greator)
                        {
                            insertion_index--;
                        }
                        else if (!is_it_greator || i == 0)
                        {
                            break;
                        }


                    }
                    edited_ray.Insert(insertion_index, item);
                    insertion_index = 0;

                }
                else
                {
                    edited_ray.Add(item);
                }
            }

            return edited_ray;

        }



        // using the function
        public static void Main(string[] args)
        {

            // testing the class
            Array_Formatter func = new Array_Formatter();


            var arr = func.get_in_alphabetical_order(new ArrayList(){"hello","go","home","hey","arrow"});

            foreach (string item in arr)
            {
                System.Console.WriteLine(item);
            }

            // the out of the following will be this

            // arrow
            // go
            // hello
            // hey
            // home
            
            // thus the alphabetical order achieved
        }

    }
}







// Copyright© by the AJTA's
// for any info contack us on satyameshmalimern123@gmail.com
// hope you enjoyed






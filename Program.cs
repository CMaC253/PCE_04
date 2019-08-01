using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic_Parameters bp = new Basic_Parameters();
            //bp.RunExercise();

            //Number_Printing_With_Parameters pnwp = new Number_Printing_With_Parameters();
            //pnwp.RunExercise();

            //Return_Values rv = new Return_Values();
            //rv.RunExercise();

            //Testing_Randomness tr = new Testing_Randomness();
            //tr.RunExercise();

            //Square_Of_Numbers son = new Square_Of_Numbers();
            //son.RunExercise();

            Square_Of_Numbers_Parameters_Return sonpr = new Square_Of_Numbers_Parameters_Return();
            sonpr.RunExercise();

            //Detecting_Prime_Numbers dpn = new Detecting_Prime_Numbers();
            //dpn.RunExercise();

            //Array_Basics ab = new Array_Basics();
            //ab.RunExercise();

            //Array_Usage au = new Array_Usage();
            //au.RunExercise();

            //Using_Part_Of_An_Array upoaa = new Using_Part_Of_An_Array();
            //upoaa.RunExercise();

            //Array_Parameter ap = new Array_Parameter();
            //ap.RunExercise();

            //Returning_An_Array raa = new Returning_An_Array();
            //raa.RunExercise();

            //Fibonnaci_With_Array fwa = new Fibonnaci_With_Array();
            //fwa.RunExercise();

            ///////////////////////////////////////////////////////////////////

            // The following were used to demonstrate topics
            // on the various videos, but aren't used in the actual
            // exercises that you have to hand in:

            //MethodDemo md = new MethodDemo();
            //md.PrintSomethingElse();
            //Console.WriteLine("==========");
            //md.PrintSomething();
            //Console.WriteLine("==========");

            //Return_Ref_Out_Demo rrod = new Return_Ref_Out_Demo();
            //rrod.RunExercise();
        }
    }

    class Basic_Parameters
    {
        public void displayMax(int x, int y)
        {
            if (x > y)
                Console.WriteLine("The larger number is: {0}", x);
            if (y > x)
                Console.WriteLine("The larger number is: {0}", y);
        }
        public void RunExercise()
        {
            int x, y;
            Int32.TryParse(Console.ReadLine(), out x);
            Int32.TryParse(Console.ReadLine(), out y);
            displayMax(x, y);
        }
    }

    class Number_Printing_With_Parameters
    {

        public void RunExercise()
        {
            NumberPrinter np = new NumberPrinter();
            np.PrintNumbers(-5, 2); // this will print the numbers -3 -2 -1 0 1 2
        }
    }

    class NumberPrinter
    {
        public void PrintNumbers(int x, int y)
        {
            for (; x <= y; x++)
                Console.WriteLine(x);
        }
    }

    class Return_Values
    {
        public void RunExercise()
        {
            Console.WriteLine("First value?");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Second value?");
            int secondNumber = Int32.Parse(Console.ReadLine());


            Max m = new Max();
            int theMax  =  m.returnMax(firstNumber, secondNumber);   
            Console.WriteLine("The max of {0} and {1} is {2} ", firstNumber, secondNumber,theMax);

        }
    }

    class Max
    {
       public int returnMax(int firstNumber, int secondNumber)
        {       
            if (firstNumber > secondNumber)
            {
                int theMax = firstNumber;
                return theMax;
            }
            if (secondNumber > firstNumber)
            {
               int theMax = secondNumber;
                return theMax;
            }
                return -1;
        }      
	}

	class Params
	{
		public void RunExercise()
		{
		}



	}

    class Testing_Randomness
    {
        public void RunExercise()
        {
            HelperClass help = new HelperClass();

            double a1_6 = help.getAverage(1, 6);
            double a1_10 = help.getAverage(1, 10);
            double a1_20 = help.getAverage(1, 20);

            help.checkAverage(1, 6, a1_6);
            help.checkAverage(1, 10, a1_10);
            help.checkAverage(1, 20, a1_20);
        }
    }
    class HelperClass
    {
        public double getAverage(double x, double y)
        {
            Console.WriteLine((x + y) / 2);
            return (x + y / 2);
        }
        public void checkAverage(int x, int y, double getAverage)
        {
            Random rng = new Random(x);
            Random rnd = new Random(y);

            double sum = 0, z = 1;
            //x = rng.Next(x,y);
            //y = rng.Next(x,y);
            for (int i = 0; i < 1000; i++)
            {
                //x = rng.Next(x, y);
                //y = rng.Next(x, y);

                for (x = 0; x < y; ++x)
                {
                    z = z + x;
                    sum = z + x;

                }

            }
                getAverage = sum / y;
                Console.WriteLine(getAverage);
                //Console.WriteLine(sum);
            }
        
    }   

	class Square_Of_Numbers
	{
		public void RunExercise()
		{
         
            int userInput;
            Int32.TryParse(Console.ReadLine(), out userInput);

            for (int y = 0; y < userInput; y++)
            {
                for (int x = 1; x <= userInput; x++)
                {
                    Console.Write("{0}\t",x);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
		
	}

	class Square_Of_Numbers_Parameters_Return
	{
		public void RunExercise()
		{
            {
                int x, y;
                int counter = 0;
                Console.WriteLine("Welcome to RectanglePrinter!");
                Console.WriteLine("How many columns wide should the rectangle be?");
                Int32.TryParse(Console.ReadLine(), out x);
                Console.WriteLine("How many rows tall should the rectangle be?");
                Int32.TryParse(Console.ReadLine(), out y);
                Console.WriteLine("Here you go:\n");
                for (int iRow = 1; iRow <= x; iRow++)
                {

                    if (iRow == 1 || iRow == x)
                    {
                        for (int iCol = 1; iCol <= y; iCol++)
                        {
                            Console.Write("*");
                            counter++;
                        }
                        Console.WriteLine();
                    }
                    else if (iRow < x && iRow < x )
                    {
                        Console.Write("*");
                        counter++;
                        for (int i = 0; i < y - 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        counter++;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Total number of stars counted is: {0} ", counter);
            }
        }
	}

	class SquarePrinter
	{
	}


	class Detecting_Prime_Numbers
	{
		public void RunExercise()
		{
		}
	}

	class PrimalityDetector
	{
		// // Add your isPrime method here:
		// public ______  isPrime( _______ )
		// {
		//
		//
		// }
	}

	class Array_Basics
	{
		public void RunExercise()
		{
            int[] nums = new int[10];
            for (int x = 0; x < nums.Length; x++)
                nums[x] = Int32.Parse(Console.ReadLine());
            for(int i=0; i<nums.Length;i++)
                Console.WriteLine(nums[i]);

            int[] y = { 1, 10, 100, 1000, 10000 };
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
              
            }
        }
	}

	class Array_Usage
	{
		public void RunExercise()
		{
            int[] fun = { 1, 10, 100, 1000, 10000 };
            int sum = 0;
            for (int index = 0; index < fun.Length; index++)
                sum += fun[index];
            int avg = sum / fun.Length;
            Console.WriteLine("Total is: {0}", sum);
            Console.WriteLine("Average is: {0}",avg);
        }
	}

	class Using_Part_Of_An_Array
	{
		public void RunExercise()
		{
            double[] nums = new double[10];
            double sum = 0.0, a;
            int numNumbersEntered = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine("Type (1) to quit and calculate sum and average, type (2) to enter numbers");
                Double.TryParse(Console.ReadLine(), out a);
                if (a == 1)
                {
                    for (int i = 0; i < nums.Length; i++)
                    sum += nums[i];
                    double avg = sum / nums.Length;
                    Console.WriteLine("The sum of your array is: {0}", sum);
                    Console.WriteLine("The avgerage of your array is: {0}", avg);
                    break;
                }
                else if (a == 2)
                {
                    Console.WriteLine("Enter a number: ");
                    nums[x] = Double.Parse(Console.ReadLine());
                    numNumbersEntered++;
                   // continue;
                }
                if (numNumbersEntered == 10)
                {

                    for (int i = 0; i < nums.Length; i++)
                        sum += nums[i];
                    double avg = sum / nums.Length;
                    Console.WriteLine("The sum of your array is: {0}", sum);
                    Console.WriteLine("The avgerage of your array is: {0}", avg);
                    break;
                }                
            }
        }
        
    }
 

	// These have been commented out so that the other exercises will compile.
	// When you get to this exercise, uncomment it, do the work, and leave this code uncommented
	//      (so your instructor can quickly and easily compile your final, 'fixed' version).
	class Array_Parameter
	{
		public void RunExercise()
		{
            ArrayHelper a = new ArrayHelper();
			int[] dataValues = new int[5];
            int howMany = a.GetUserData(dataValues);
            Console.WriteLine("\nStored {0} values into the array\n", howMany);

             int sum =  a.CalculateSum( dataValues ); 
             Console.WriteLine("\nThe total is: {0}\n",sum);
          
            //        // Do everything a second time, just to make sure it works with a different array
            //        int[] nums2 = new int[10];
            //        howMany = GetUserData(nums2);
            //        Console.WriteLine("\nStored {0} values into the array\n", howMany);
            //        Console.WriteLine("\nThe total is: {0}\n", CalculateSum(/* how many to sum up? */, nums2));

        }
	}

	class ArrayHelper
	{
        
        public int GetUserData(int[] datavalues)
        {
            int howMany=0;
            for (int x=0; x<datavalues.Length; x++)
            {
                Console.WriteLine("Please type in a number. Type a negative number to exit!");
                datavalues[x] = Int32.Parse(Console.ReadLine());
                if (datavalues[x] < 0)
                    break;
                else if (datavalues[x]>0)
                    howMany++;
                }
            return howMany;
             
            
        }
              public int CalculateSum(int[]datavalues)
        {
            int sum = 0;
            for (int x = 0; x < datavalues.Length; x++)
            {
                if (datavalues[x] < 0)
                    break;
                    sum += datavalues[x];
            }
            return sum;
        }

    }  

	class Returning_An_Array
	{
		public void RunExercise()
		{
           ArrayReturnMethods x = new ArrayReturnMethods();
	       int[] nums1;
	       nums1 = x.CreateRandomlyFilledArray(10);
            x.PrintArray(nums1);

                
	  
		}
	}

	class ArrayReturnMethods
	{
        Random r = new Random();
     public int[] CreateRandomlyFilledArray(int size )
	    {
            
            int[] randoms = new int[size];
            for (int x= 0; x<randoms.Length;x++)
            {
                randoms[x] = r.Next(0, 101);
            }
            return randoms;
        }

	    public void PrintArray(int[] nums )
	    {
	        for(int i=0;i<nums.Length;i++)
                Console.WriteLine(nums[i]);
	    }
	}

	class Fibonnaci_With_Array
	{
		public void RunExercise()
		{
            int[] array = new int[20];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <array.Length; i++)
                array[i] = array[i - 1] + array[i - 2];
            for(int i=0; i<array.Length; i++)
                Console.WriteLine("Sequence: {0}\t:{1}", i, array[i] );
        }
	}

	///////////////////////////////////////////////////////////////////

	// The following were used to demonstrate topics
	// on the various videos, but aren't used in the actual
	// exercises that you have to hand in:   

	class MethodDemo
	{
		public void PrintSomethingElse()
		{
			Console.WriteLine("Something else");
		}

		public void PrintSomething()
		{
			Console.WriteLine("Hello!");
			this.PrintSomethingElse(); // valid, 115-like
			PrintSomethingElse(); // also valid

			Basic_Parameters_Demo bpd = new Basic_Parameters_Demo();
			bpd.RunExercise();
		}
	}

	class Basic_Parameters_Demo
	{
		public void RunExercise()
		{

			// // This was used in a video. Feel free to uncomment & play with it
			Demo d = new Demo();
			int theNum = 3;
			d.ParameterDemo(theNum, 3.2); // an argument
			Console.WriteLine(theNum);

			Console.WriteLine("First value?");
			int firstNumber = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Second value?");
			int secondNumber = Int32.Parse(Console.ReadLine());

			// MaxPrinter mp = new MaxPrinter();
			// call displayMax here, with firstNumber and secondNumber
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	public class Demo
	{

		public void ParameterDemo(int theNum, double n2) // parameter, aka 'formal argument'
		{
			theNum = 10;
			Console.WriteLine("value passed in is: {0} {1}", theNum, n2);

			return;
		}


	}


	class Return_Values_Demo
	{
		public void RunExercise()
		{
			// This was used in a video. Feel free to uncomment & play with it
			ReturnValueHelper rvd = new ReturnValueHelper();
			int importantValue = 99;

			importantValue = rvd.ProduceReturnValue();

			Console.WriteLine(importantValue);
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	class ReturnValueHelper
	{
		public int ProduceReturnValue()
		{
			int number = 10;

			if (number < 5)
				return number;

			Console.WriteLine("Hello!");
			return 10;
		}
	}

	class Return_Ref_Out_Demo
	{
		public void RunExercise()
		{
			// This was used in a video. Feel free to uncomment & play with it
			Return_Ref_Out_Examples rvd = new Return_Ref_Out_Examples();

			int importantValue = 99;
			importantValue = rvd.ProduceReturnValue();
			Console.WriteLine(importantValue);

			int otherValue; // NOTICE: NOT initialized!
			rvd.InitializeVariables(out importantValue, out otherValue);
			Console.WriteLine("ImportantValue: {0} otherValue: {1}", importantValue, otherValue);

			otherValue = 10;
			rvd.PrintOrMakePositive(ref otherValue);
			Console.WriteLine("otherValue: {0}", otherValue);

			otherValue = -10;
			rvd.PrintOrMakePositive(ref otherValue);
			Console.WriteLine("otherValue: {0}", otherValue);
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	class Return_Ref_Out_Examples
	{
		public int ProduceReturnValue()
		{
			int number = 10;

			return number;
		}

		public void InitializeVariables(out int num1, out int num2)
		{
//            Console.WriteLine(num1); // note the compiler error!
			num1 = 0;
			num2 = 0;
			Console.WriteLine("num1 is now: {0}", num1);
		}

		public void PrintOrMakePositive(ref int num1)
		{
			if (num1 > 0)
				Console.WriteLine("num1 is: {0}", num1);
			else
				num1 = 1; // 1 is positive :)
		}
	}

	class ArrayExamples
	{
		public void RunExercise()
		{
			int[] nums = new int[5];
			// put vlaues into nums
			int x = 3;

			ArrayDemo ad = new ArrayDemo();
			ad.PrintArray(x, nums);

			int num = ad.ReturnNumber();

			int[] moreNums; // NOTE: NO new int[] - we'll do that below
			moreNums = ad.ReturnArray();

			ad.PrintArray(-10, moreNums);
		}
	}

	class ArrayDemo
	{
		public void PrintArray(int oneNum, int[] numsToPrint)
		{
			Console.WriteLine(oneNum);

			for (int i = 0; i < numsToPrint.Length; i++)
				Console.WriteLine(numsToPrint[i]);
		}

		public int ReturnNumber()
		{
			int x = 0;
			// x is given a value, somehow
			//      we'll leave that out since this 
			//      example focuses on returning the value
			return x+1;
		}

		public int[] ReturnArray()
		{
			int[] nums = { 1, 2 + 1, this.ReturnNumber() };
				// turns out, you can put code into the initializer
				// that will be executed at run-time

			// normally you'd do more with the array
			return nums;
		}
	}
}

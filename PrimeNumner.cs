using System;

public class PrimeNumber
{
	public PrimeNumber()
	{
		public static void Main(string[] agrs)
        {
			int n, i, m = 0, flag = 0;
			Console.Write("Enter the number to check prime: ");
			n = int.Parse(Console.ReadLine());
			m = n / 2;
			for(i=0; i<=m; i++)
            {
                if (n % 2 == 0)
                {
					Console.Write("Number is not prime.");
					flag = 1;
					break;
                }
            }
			if (flag == 0)
				Console.Write("Number is prime.");
        }
	}
}

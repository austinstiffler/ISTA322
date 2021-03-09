using System.Linq;
using System;


namespace ProgEx07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Exercise 7: Roulette");
            int[] firstCol = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] secCol = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] thirdCol = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] greens = new int[] { 0, 00 };
            int[] blacks = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] reds = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            Random num = new Random();
            int newNum = num.Next(00, 36);

            Console.WriteLine($"The ball fell on {newNum}!");
            Console.WriteLine("Here are the winning bets..");

            Console.WriteLine($"Numbers: {newNum}");
            if (newNum % 2 == 0 && newNum != 0 && newNum != 00)
                Console.WriteLine("Evens/Odds: Evens");
            else if (newNum % 2 == 1)
                Console.WriteLine("Evens/Odds: Odds");

            if (reds.Contains(newNum))
                Console.WriteLine("Reds/Blacks: Reds");
            else if (blacks.Contains(newNum))
                Console.WriteLine("Reds/Blacks: Blacks");

            if (newNum > 0 && newNum <= 18)
                Console.WriteLine("Lows/Highs: Lows");
            else if (newNum >= 19 && newNum <= 36)
                Console.WriteLine("Lows/Highs: Highs");

            if (0 < newNum && newNum <= 12)
                Console.WriteLine("Dozens: Low Dozen (1-12)");
            else if (newNum >= 13 && newNum <= 24)
                Console.WriteLine("Dozens: Middle Dozen (13-24)");
            else if (newNum >= 25 && newNum <= 36)
                Console.WriteLine("Dozens: High Dozen (25-36)");

            if (firstCol.Contains(newNum))
            {
                Console.WriteLine("Columns: First Column");
                Console.WriteLine($"Street: {newNum}, {newNum + 1}, {newNum + 2}");
                if (newNum == 1)
                    Console.WriteLine("Split: 1, 2 or 1, 4");
                else if (newNum == 34)
                    Console.WriteLine("Split: 34, 35 or 34, 31");
                else
                    Console.WriteLine($"Split: {newNum}, {newNum - 3} or {newNum}, {newNum + 1} or {newNum}, {newNum + 3}");

            }
            else if (secCol.Contains(newNum))
            {
                Console.WriteLine("Columns: Second Column");
                Console.WriteLine($"Street: {newNum - 1}, {newNum}, {newNum + 1}");
                if (newNum == 2)
                    Console.WriteLine("Split: 1, 2 or 2, 3 or 2, 5");
                else if (newNum == 35)
                    Console.WriteLine("Split: 34, 35 or 35, 36 or 35, 32");
                else
                    Console.WriteLine($"Split: {newNum}, {newNum - 1} or {newNum}, {newNum + 1} or {newNum}, {newNum + 3} or {newNum}, {newNum - 3}");
            }
            else if (thirdCol.Contains(newNum))
            {
                Console.WriteLine("Columns: Third Column");
                Console.WriteLine($"Street: {newNum - 2}, {newNum - 1}, {newNum}");
                if (newNum == 3)
                    Console.WriteLine("Split: 2, 3 or 3, 6");
                else if (newNum == 36)
                    Console.WriteLine("Split: 35, 36 or 33, 36");
                else
                    Console.WriteLine($"Split: {newNum}, {newNum - 3} or {newNum}, {newNum - 1} or {newNum}, {newNum + 3}");
            }

            if (firstCol.Contains(newNum) && newNum == 1)
                Console.WriteLine("Corners: 1, 2, 5, 4");
            else if (firstCol.Contains(newNum) && newNum == 34)
                Console.WriteLine("Corners: 34, 31, 32, 35");
            else if (firstCol.Contains(newNum) && newNum != 1 && newNum != 34)
                Console.WriteLine($"Corners: {newNum}, {newNum - 3}, {newNum - 2}, {newNum + 1} or {newNum}, {newNum + 1}, {newNum + 4}, {newNum + 3}");

            if (secCol.Contains(newNum) && newNum == 2)
            {
                Console.WriteLine("Corners: 1, 2, 4, 5 or 2, 3, 5, 6");
            }
            else if (secCol.Contains(newNum) && newNum == 35)
            {
                Console.WriteLine("Corners: 31, 32, 34, 35 or 32, 33, 35, 36");
            }
            else if (secCol.Contains(newNum) && newNum != 2 && newNum != 35)
            {
                Console.WriteLine($"Corners: {newNum - 4}, {newNum - 3}, {newNum}, {newNum - 1} or {newNum - 3}, {newNum - 2}, {newNum}, {newNum + 1} or {newNum + 1}, {newNum + 4}, {newNum}, {newNum + 3} or {newNum - 1}, {newNum}, {newNum + 3}, {newNum + 2}");
            }

            if (thirdCol.Contains(newNum) && newNum == 3)
                Console.WriteLine("Corners: 2, 3, 5, 6");
            else if (thirdCol.Contains(newNum) && newNum == 36)
                Console.WriteLine("Corners: 32, 33, 35, 36");
            else if (thirdCol.Contains(newNum) && newNum != 3 && newNum != 36)
                Console.WriteLine($"Corners: {newNum - 4}, {newNum - 3}, {newNum - 1}, {newNum} or {newNum - 1}, {newNum}, {newNum + 2}, {newNum + 3}");

            if (firstCol.Contains(newNum) && newNum == 1)
                Console.WriteLine("6 Numbers: 1, 2, 3, 4, 5, 6");
            else if (firstCol.Contains(newNum) && newNum == 34)
                Console.WriteLine("6 Numbers: 31, 32, 33, 34, 35, 36");
            else if (firstCol.Contains(newNum) && newNum != 1 && newNum != 34)
                Console.WriteLine($"6 Numbers: {newNum - 3}, {newNum - 2}, {newNum - 1}, {newNum}, {newNum + 1}, {newNum + 2} or { newNum}, { newNum + 1}, { newNum + 2}, { newNum + 3}, { newNum + 4}, { newNum + 5}");

            if (secCol.Contains(newNum) && newNum == 2)
                Console.WriteLine("6 Numbers: 1, 2, 3, 4, 5, 6");
            else if (secCol.Contains(newNum) && newNum == 35)
                Console.WriteLine("6 Numbers: 31, 32, 33, 34, 35, 36");
            else if (secCol.Contains(newNum) && newNum != 2 && newNum != 35)
                Console.WriteLine($"6 Numbers: {newNum - 4}, {newNum - 3}, {newNum - 2}, {newNum - 1}, {newNum}, {newNum + 1} or {newNum - 1}, {newNum}, {newNum + 1}, {newNum + 2}, {newNum + 3}, {newNum + 4}");

            if (thirdCol.Contains(newNum) && newNum == 3)
                Console.WriteLine("6 Numbers: 1, 2, 3, 4, 5, 6");
            else if (thirdCol.Contains(newNum) && newNum == 36)
                Console.WriteLine("6 Numbers: 31, 32, 33, 34, 35, 36");
            else if (thirdCol.Contains(newNum) && newNum != 3 && newNum != 36)
                Console.WriteLine($"6 Numbers: {newNum - 5}, {newNum - 4}, {newNum - 3}, {newNum - 2}, {newNum - 1}, {newNum} or {newNum - 2}, {newNum - 1}, {newNum}, {newNum + 1}, {newNum + 2}, {newNum + 3}");

        }
    }
}
/* 
* MoveEstimator.cs 
* Date: 04/09/2019 
* Author: Cody Bromwich 
* Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile.  Write, compile, and test a console application named MoveEstimator that prompts a user for and accepts estimates for the number of hours for a job and the number of miles involved in the move and displays the total moving fee. 
*/

using static System.Console;
using System;

class MoveEstimator {
    static void Main() {
        int FLAT_RATE = 200;
        int HOUR_RATE = 150;
        int MILE_RATE = 2;

        Write("Enter the number of hours for the job: ");
        int hours = Convert.ToInt32(ReadLine());
        Write("Enter number of miles for the job: ");
        int miles = Convert.ToInt32(ReadLine());
        int estimate = (hours * HOUR_RATE) + (miles * MILE_RATE) + FLAT_RATE;

        WriteLine("Job estimate: $" + Convert.ToString(estimate));
    }
}
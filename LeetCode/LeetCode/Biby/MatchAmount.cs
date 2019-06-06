using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Biby
{
    /// <summary>
    /// All Matched Items Which Sum Value Equal To The list1 items
    /// </summary>
    public class AmountMatchedList
    {
        public AmountMatchedList()
        {
   
            MatchedList = new List<int>();
        }

        public int Amount { get; set; } // list1 items Amount
        public List<int> MatchedList { get; set; } //The sum value of this list equals to Amount 
    }
    /// <summary>
    /// Result
    /// </summary>
    public class Result
    {
        public Result()
        {
            LeftList = new List<AmountMatchedList>(); // All the amount in list1 and all the sum value item to each Amount
      
        }

        public List<AmountMatchedList> LeftList { get; set; }

   
    }
    public class GetMatchAmountList
    {
        public Result Solution(List<int> list1, List<int> list2)
        {
            Result result = new Result();
            for (int i = 0; i < list1.Count; i++)
            {
                int totalAmount = list1[i];                     //This is each Amount in list1
              
                for (int j = 0; j < list2.Count-1; j++)         //1ST list2 traversal
                {
                    
                    AmountMatchedList resultItem = new AmountMatchedList(); 
                    resultItem.MatchedList.Add(list2[j]);       // Add every head in list2 to MatchedList as the first element of match list item
                    resultItem.Amount = totalAmount;            // Add Amount to result item. Each Amount mapping to MatchedList
                    int leftAmount = totalAmount - list2[j];    // Amount munus the first element of matchlist 
                    if(leftAmount==0)
                    {
                        result.LeftList.Add(resultItem);
                        continue;
                    }
                    /*
                     * Inisital the final resultAmount, 
                     * if the first step for the 2nd list2 traversal is smaller than 0,
                     * set this as -1 to distinguish minus element in list2 at 2nd list2 traversal
                     */
                    int resultAmount = -1;                        
                    for (int k = j+1; k < list2.Count; k++)     //2nd list2 traversal
                    {
                        if (leftAmount > 0)                     //The sum value does not equal to Amount
                        {
                            /*
                             * //Continue minus element in list2 and Add to result item. 
                             * The result item may not add to result. 
                             * It depends on if the sum value equals to Amount
                             */
                            resultAmount = leftAmount - list2[k];
                            leftAmount = resultAmount;
                            resultItem.MatchedList.Add(list2[k]);
                        }
                        if (resultAmount <= 0)                   //The sum value does may equal to Amount
                        {

                            /*
                             * The sum value equal to Amount
                             * add this result Item to result
                             */
                            if (resultAmount==0)                 
                            {
                                result.LeftList.Add(resultItem);
                              
                            }
                            /*
                             * The sum value is less than Amount, 
                             * need to re-inital leftAmount as begin,
                             * and clear/inital resul tItem as begin for next traversal
                             */
                            leftAmount = totalAmount - list2[j];
                            resultItem = new AmountMatchedList();
                            resultItem.Amount = totalAmount;
                            resultItem.MatchedList = new List<int>();
                            resultItem.MatchedList.Add(list2[j]);
                            

                        }
                       
                    }
                }

            }

            return result;
        }
    }


}

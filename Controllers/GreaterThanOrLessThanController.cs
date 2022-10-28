//N. Harrison Wilkins
//10-26-2022
//GREATER THAN OR LESS THAN - ENDPOINTS
//THIS PROGRAM WILL ALLOW THE USER TO INPUT TWO NUMBRES THROUGH THE URL AND WILL BE EVALUATED AND RETURNED AS WHETHER THEY ARE EQUAL TO EACH OTHER, OR IF THE FIRST NUMBER IS GREATER THAN OR LESS THAN

//Reviewed by Isaiah Ferguson - Code Runs great i liked the use of data validation. everything looks formate! Excellent job. - with love Isaiah Keith Ferguson III

using Microsoft.AspNetCore.Mvc;

namespace WilkinsHGreaterOrLessThan_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : ControllerBase
{
    [HttpGet]
    [Route ("evaluate/{userNumberOne}/{userNumberTwo}")]
    public string GreaterOrLessThan(string userNumberOne, string userNumberTwo, bool isNumberOne = false, bool isNumberTwo = false, int validNumberOne = 0, int validNumberTwo = 0)
    {
        isNumberOne = Int32.TryParse(userNumberOne, out validNumberOne);
        isNumberTwo = Int32.TryParse(userNumberTwo, out validNumberTwo);
        if(isNumberOne == true && isNumberTwo == true)
        {
            if(validNumberOne > validNumberTwo)
            {
                return $"{userNumberOne} is GREATER than {userNumberTwo}!";
            }
            if(validNumberOne < validNumberTwo)
            {
                return $"{userNumberOne} is LESS than {userNumberTwo}!";
            }
           else if(validNumberOne == validNumberTwo)
            {
                return $"{userNumberOne} is EQUAL to {userNumberTwo}!";
            }
        }
            return "ONE OR MORE ENTRY WAS NOT A NUMBER!";
    }
}

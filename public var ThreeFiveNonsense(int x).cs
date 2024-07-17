static public string ThreeFiveNonsense(int number)

{
    var answer = "";

    if (number % 3 == 0 && number % 5 > 0)
    {
        answer = "fizz";
    }

    else if (number % 5 == 0 && number % 3 > 0)
    {
        answer = "buzz";
    }

    else if (number % 5 == 0 && number % 3 == 0)
    {
        answer = "fizzbuzz";
    }

    else
    {
        answer = "Not fizzable or buzzable!";
    }

    Console.WriteLine(answer);
    return answer;
}    

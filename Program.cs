﻿
string[] masterArray = new string[5] {"Angola", "31 ", "1992", " Russia", "Germany"}; 
string[] theRuler_array = new string[masterArray.Length];

void theCheker(string[] masterArray, string[] theRuler_array)
{ 
    int count = 0;
    
    for (int i = 0; i < masterArray.Length; i++)
    {
    if(masterArray[i].Length <= 3)
        {
        theRuler_array[count] = masterArray[i];
        count++;
        }
    }
}
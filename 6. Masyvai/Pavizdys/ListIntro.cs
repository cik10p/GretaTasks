var cityNameList = new List<string>();

// pridedam i masyva
cityNameList.Add("Kaunas");
cityNameList.Add("Vilnius");
cityNameList.Add("Vievis");
cityNameList.Add("Palanga");

// pasalinam is masyvo
cityNameList.Remove("Kaunas");

// patikrina ar miestas yra sarase?
if (cityNameList.Contains("Palanga"))
{
    Console.WriteLine("Miestas yra");
}
else 
{
    Console.WriteLine("Miesto nera");
}

Console.WriteLine("Programos pabaiga");
Console.ReadLine();
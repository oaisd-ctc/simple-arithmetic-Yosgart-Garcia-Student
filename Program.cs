using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(":) Let's do a lil' bit of adding. Type in any number, go ahead.");
        float addX = float.Parse(Console.ReadLine());

        Console.WriteLine(":D " + addX + ", what a fine number... now, for another number to add onto it:");
        float addY = float.Parse(Console.ReadLine());

        float addition = addX + addY;
        Console.WriteLine(">:D" + addition + "! " + addX + " + " + addY + " is " + addition + "! How easy, you should've given me some harder numbers...");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine(":P Now, provide a completely different number to use in the subtraction process.");
        float subX = float.Parse(Console.ReadLine());

        Console.WriteLine(">:O" + subX + "??? Really!? I expected more from the person who gave me " + addX + "... Moving on, what's the next number?");
        float subY = float.Parse(Console.ReadLine());

        float subtraction = subX - subY;
        Console.WriteLine(":S" + subtraction + "! End result is rather exquisite, despite your previous responses...");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine(":| Enter a number for multiplication, if you please.");
        float mulX = float.Parse(Console.ReadLine());

        Console.WriteLine(":) Oh that's a good number. Perhaps I judged you too harshly... but that depends on your following entry.");
        float mulY = float.Parse(Console.ReadLine());

        float multiplication = mulX * mulY;
        Console.WriteLine(":D" + multiplication + ". I must say, that's quite the redemption.");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine(">:D Brace yourself for integer division! (By typing a preferrably large integer below)");
        int divX = int.Parse(Console.ReadLine());

        Console.WriteLine("S:) Now enter an integer that doesn't go into " + divX + " very nicely.");
        int divY = int.Parse(Console.ReadLine());

        int intDivision = divX / divY;
        Console.WriteLine(intDivision + ". That's right, I just dropped the decimal. Call me lazy, but that's what it is.");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine("Maybe you'll be more impressed with this decimal division!");
        float decimalDivX = float.Parse(Console.ReadLine());

        Console.WriteLine("Next.");
        float decimalDivY = float.Parse(Console.ReadLine());

        float decimalDivision = decimalDivX / decimalDivY;
        Console.WriteLine(decimalDivX + " divided by " + decimalDivY + " is " + decimalDivision + "! Impressed? You surely will be with this next one...");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine("I present to you: modulus. Enter your least favorite number.");
        float modX = float.Parse(Console.ReadLine());

        Console.WriteLine("But I love " + modX + "... Well, enter your second least favorite number.");
        float modY = float.Parse(Console.ReadLine());

        float modulus = modX % modY;
        Console.WriteLine(modX + " modulus-ed by " + modY + " is " + modulus + "! *Yawn* all this easy math is making me sleepy... That's enough for today");
        Console.WriteLine("Go away now.");
    } 
}

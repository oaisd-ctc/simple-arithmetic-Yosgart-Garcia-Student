using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(":) | Let's do a some adding. Type in any number, go ahead.");
        float addX = float.Parse(Console.ReadLine());

        Console.WriteLine(":D | " + addX + ", what a fine number... now, for another number to add onto it:");
        float addY = float.Parse(Console.ReadLine());

        float addition = addX + addY;
        Console.WriteLine(">:D | " + addition + "! " + addX + " + " + addY + " is " + addition + "! How easy, you should've given me some harder numbers...");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine("S:) | Now, provide a completely different number to use in the subtraction process.");
        float subX = float.Parse(Console.ReadLine());

        Console.WriteLine(">:O | " + subX + ", really??? That number sucks... Moving on, what's the next number?");
        float subY = float.Parse(Console.ReadLine());

        float subtraction = subX - subY;
        Console.WriteLine(":S | The result is " + subtraction + "...");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine(":| | Enter a number for multiplication, if you please.");
        float mulX = float.Parse(Console.ReadLine());

        Console.WriteLine(":) | Oh that's a good number.");
        float mulY = float.Parse(Console.ReadLine());

        float multiplication = mulX * mulY;
        Console.WriteLine(":D | " + multiplication + ". Oh that number is quite pretty, I'll forgive you for typing in " + subX + "!");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine(">:D | Prepare thyself for integer division. (By preferrably typing a large integer below)");
        int divX = int.Parse(Console.ReadLine());

        Console.WriteLine(":O | Wow that is a big number... Now enter an integer that doesn't go into " + divX + " very nicely.");
        int divY = int.Parse(Console.ReadLine());

        int intDivision = divX / divY;
        Console.WriteLine(":| | " + intDivision + ". That's right, I just dropped the decimal.");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine("S:^ | Maybe you'll be more impressed with this decimal division!");
        float decimalDivX = float.Parse(Console.ReadLine());

        Console.WriteLine(":L | Next.");
        float decimalDivY = float.Parse(Console.ReadLine());

        float decimalDivision = decimalDivX / decimalDivY;
        Console.WriteLine(":)" + decimalDivX + " divided by " + decimalDivY + " is " + decimalDivision + "! Impressed? You surely will be with this next one...");

        //----------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine(":} | I present to you: modulus. Enter your least favorite number.");
        float modX = float.Parse(Console.ReadLine());

        Console.WriteLine(":C | But I love " + modX + "... Well, enter your second least favorite number.");
        float modY = float.Parse(Console.ReadLine());

        float modulus = modX % modY;
        Console.WriteLine(":> | " + modX + " modulus-ed by " + modY + " is " + modulus + "!");
        Console.WriteLine("u~u | *Yawn* all this easy math is making me sleepy... That's enough for today. Go away now.");
    } 
}

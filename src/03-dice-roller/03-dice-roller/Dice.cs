using System;

public class Dice
{
	public int Roll(int sides)
	{
        return new Random().Next(1, sides + 1);
       
	}
}

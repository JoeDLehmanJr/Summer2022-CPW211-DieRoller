﻿
using DieRoller;

Die myDie = new();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);

myDie.IsHeld = true;
Console.WriteLine("Holding the die*****");
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);

Console.ReadKey();
using Task2;

Vector v1 = new Vector { X = 2, Y = 3, Z = 4 };
Vector v2 = new Vector { X = 1, Y = -2, Z = 3  };

Vector sum = v1 + v2;

Vector Subtract = v1 - v2;

Vector Multiply = v1*v2;

Vector Divide = v1 / 2.5;

Console.WriteLine($"Vector Sum : " + sum);
Console.WriteLine($"Vector Subtract : " + Subtract);
Console.WriteLine($"Vector Multiplication : " + Multiply);
Console.WriteLine($"Vector Divide : " + Divide);

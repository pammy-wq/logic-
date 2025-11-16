//Operadores Lógicos
bool x = true;
bool y = false;

bool and = x  && y; // e logico
bool or = x || y; // Ou logico
bool not = !x; // não logico

// Exibindo resultados dos operadores logicos
Console.WriteLine("\nOperadores Lógicos:");
Console.WriteLine($"x $$ y: {and}"); // é logico
Console.WriteLine($"x || y: {or}"); // ou logico
Console.WriteLine($"!x: {not}");  // não logico

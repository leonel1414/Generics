//Generics
Generic<string> str = new Generic<string>();
str.Dato = "Dato";
Console.WriteLine($"Generics Dato: {str.Dato}");
Console.WriteLine($"Tipo de Generic Dato: {str.Dato.GetType().FullName}");

public class Generic<T> { 
    public T Dato { get; set; }
}


/*
 //Generics
Generic<string> str = new Generic<string>();
str.Dato = "Dato";
Console.WriteLine($"Generics Dato: {str.Dato}");
Console.WriteLine($"Tipo de Generic Dato: {str.Dato.GetType().FullName}");

public class Generic<T> { 
    public T Dato { get; set; }
}

*/

/*
 * HERENCIA - POLIMORFISMO
 */
Vehiculo vehiculo = new Vehiculo();
vehiculo.Arrancar();


Coche coche = new Coche();
coche.Arrancar();
coche.Arrancar("lEO");
coche.DetenerCoche();



class Vehiculo { 
public float combustible { get; set; }
 public int aforo { get; set; }


    public void Arrancar() {
        Console.WriteLine("Este vehiculo ha arrancado");
    }
}


class Coche : Vehiculo { 
    public int ruedas { get; set; }

    public void DetenerCoche() { 
        Console.WriteLine("Se ha detenido el vehiculo");
    }

    public void Arrancar() { 
    Console.WriteLine("Esté coche ha arrancado con éxito!!");
    }

    public void Arrancar(string str) {
        Console.WriteLine($"{str} ha arrancado a las {DateTime.Now}.");
    }
}

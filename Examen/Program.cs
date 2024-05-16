using Examen;

try
{
    Asignatura asignatura = new Asignatura();

    Console.WriteLine("Ingrese el nombre del alumno:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el número de cuenta:");
    string numCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese correo electrónico:");
    string correo = Console.ReadLine();
    Console.WriteLine("Ingrese nombre de la clase:");
    string nomClase = Console.ReadLine();
    Console.WriteLine("Ingrese el horario de la clase:");
    string horario = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre del docente:");
    string docente = Console.ReadLine();

    Console.WriteLine("Ingrese nota del primer parcial:");
    string n1 = Console.ReadLine();

    Console.WriteLine("Ingrese nota del segundo parcial:");
    string n2 = Console.ReadLine();

    Console.WriteLine("Ingrese nota del tercer parcial:");
    string n3 =  Console.ReadLine();

    asignatura.NombreAsignatura = nomClase;
    asignatura.NumeroCuenta = numCuenta;
    asignatura.Email = correo;
    asignatura.NombreAlumno = nombre;
    asignatura.Horario = horario;
    asignatura.NombreDocente = docente;

    asignatura.N1 = convertirAEntero(n1);
    asignatura.N2 = convertirAEntero(n2);
    asignatura.N3 = convertirAEntero(n3);

    validarNota(30, asignatura.N1,"primer");
    validarNota(30, asignatura.N2, "segundo");
    validarNota(40, asignatura.N3, "tercer");

    asignatura.Imprimir();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

int convertirAEntero(string inputNota)
{
    int nota;
    if (!int.TryParse(inputNota, out nota))
        throw new Exception("Una de las notas ingresadas no tiene el formato válido");
    return nota;
}

void validarNota(int notaMax,int nota,string parcial)
{
    if (nota > notaMax) throw new Exception($"La nota del {parcial} parcial sobrepasa del {notaMax}%");
    if (nota < 0) throw new Exception($"La nota del {parcial} parcial debe ser mayor o igual a 0%");
}
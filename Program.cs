using EspacioEmpleados;

Empleado[] empleado = new Empleado[3];

double totalSalario=0;
DateTime fechaActual = DateTime.Today;

for(int i = 0; i < 3; i++){

    empleado[i] = new Empleado();

    Console.Write($"\n\nIngrese los datos del empleado N° {i+1}: ");

    Console.Write($"\n\nNombre: ");

    while(string.IsNullOrEmpty(empleado[i].Nombre = Console.ReadLine())){
        Console.Write("\nDebe ingresas un nombre: ");
    }
    Console.Write($"\nApellido: ");

    while(string.IsNullOrEmpty(empleado[i].Apellido = Console.ReadLine())){
        Console.Write("\nDebe ingresas un apellido: ");
    }

    Console.Write($"\nFecha de nacimiento: ");

    empleado[i].Fnacimiento = Fechas(fechaActual);

    Console.Write("\nIngrese el genero del empleado\n[F] Femenino\n[M] Masculino\n>> ");
    empleado[i].Genero = Console.ReadKey().KeyChar; //Console.ReadKey() espera a que el usuario presione una tecla. keyChar devuelve el caracter ingresado

    Console.ReadKey();
    
    while(empleado[i].Genero != 'f' && empleado[i].Genero != 'm'){
        Console.Write("\nDebe ingresar un opción valida\n>> ");
        empleado[i].Genero = Console.ReadKey().KeyChar; 
        Console.ReadKey();
    }

    Console.Write("\n\nFecha de ingreso ");
    empleado[i].Fingreso = Fechas(fechaActual);

    Console.Write("\nSueldo: ");
    double suel;
    while(!double.TryParse(Console.ReadLine(), out suel)){
        
        Console.Write("\nDebe ingresar un monto valido");

    }

    empleado[i].Sueldo = suel;

    Console.Write("\nCargo:\n0-Auxiliar\n1-Administrativo\n2-Ingeniero\n3-Especialista\n4-Investigador\n>> ");
    int car;
    while(!int.TryParse(Console.ReadLine(), out car)){
        Console.Write("\nDebe ingresar una opción valida");
    }
    switch(car){
        case 0:empleado[i].Cargo = cargos.Auxiliar;
        break;
        case 1:empleado[i].Cargo = cargos.Administrativo;
        break;
        case 2:empleado[i].Cargo = cargos.Ingeniero;
        break;
        case 3:empleado[i].Cargo= cargos.Especialista;
        break;
        case 4:empleado[i].Cargo= cargos.Investigador;
        break;
    }

    int edad = empleado[i].edad(empleado[i].Fnacimiento.Year, fechaActual.Year);

    empleado[i].Anti = empleado[i].antigüedad(empleado[i].Fingreso.Year, fechaActual.Year);

    empleado[i].SalariO = empleado[i].salario(empleado[i].Anti, car, empleado[i].Estadocivil, empleado[i].Sueldo);

    empleado[i].Jub = empleado[i].jubilación(edad, empleado[i].Genero);
     
    totalSalario +=empleado[i].SalariO;
}

Console.Write($"\n\nEl monto total de lo que se paga en concepto de salarios es: {totalSalario}");

int aux=0;
for(int i = 0; i<3; i++){
    for (int j=0; j<3;j++){
        if(empleado[i].Jub < empleado[j].Jub){
            aux = i;
        }
    }
}

Console.Write($"\n\nEl empleado que esta mas proximo a jubilarse es: {empleado[aux].Apellido} {empleado[aux].Nombre}\nAntigüedad: {empleado[aux].Anti} años\nSalario: ${empleado[aux].SalariO}\nLe faltan {empleado[aux].Jub} años para jubilarse");

DateTime Fechas(DateTime fechaActual){

    int dia, mes, año;
    Console.Write("\n\tDía: ");
    string? D = Console.ReadLine();
    Console.Write("\n\tMes: ");
    string? M = Console.ReadLine();
    Console.Write("\n\tAño: ");
    string? A = Console.ReadLine(); 

    while(!int.TryParse(D, out dia) || !int.TryParse(M, out mes) || !int.TryParse(A, out año) || dia < 1 || dia > 31 || mes < 1 || mes > 12 || año < 1900 || año > fechaActual.Year){

        Console.Write("\n\n\tDebe ingresar valores validos");
        Console.Write("\n\tDía: ");
        D = Console.ReadLine();
        Console.Write("\n\tMes: ");
        M = Console.ReadLine();
        Console.Write("\n\tAño: ");
        A = Console.ReadLine(); 

    }

    DateTime aux = new DateTime(año,mes,dia);

    return aux;
}

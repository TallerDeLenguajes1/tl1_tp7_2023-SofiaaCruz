using EspacioCalculadora;

Calculadora calculadora = new Calculadora();

int op;
double num;



Console.Write("\n\nIngrese un número: ");
            
while(!double.TryParse(Console.ReadLine(), out num)){
    Console.Write("\n\nDebe ingresar número\n>> ");
}

do{
    Console.Write("\n\nElija unaoperación:\n1-SUMAR\n2-RESTAR\n3-MULTIPLICAR\n4-DIVIDIR\n0-NADA\n>> ");
    while(!int.TryParse(Console.ReadLine(), out op) ||op<0 || op > 4){
        Console.Write("\n\nDebe ingresar una opcionvalida\n>> ");
    }
    
    if(op!=0){
        switch(op){
            case 1: calculadora.Sumar(num);
                Console.Write($"\n\nEl resultadoes: {calculadora.resultado}");
            break;
            case 2: calculadora.Restar(num);
                Console.Write($"\n\nEl resultado es:{calculadora.resultado}");
            break;
            case 3:calculadora.Multiplicar(num);
                Console.Write($"\n\nEl resultado es:{calculadora.resultado}");
            break;
            case 4:calculadora.Dividir(num);
                Console.Write($"\n\nEl resultado es:{calculadora.resultado}");
            break;
        }
    }
    else{
        calculadora.Limpiar();
    }
}while(op!=0);

namespace EspacioEmpleados;

   public enum cargos {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }

public class Empleado{

    private string? nombre;
    private string? apellido;
    private DateTime fnacimiento;
    private char estadocivil;
    private char genero;
    private DateTime fingreso;
    private double sueldo;
    cargos cargo;
    private  int jub;
    private int anti;
    private double salariO;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime Fnacimiento { get => fnacimiento; set => fnacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime Fingreso { get => fingreso; set => fingreso = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public cargos Cargo { get => cargo; set => cargo = value; }
    public int Jub { get => jub; set => jub = value; }
    public int Anti { get => anti; set => anti = value; }
    public double SalariO { get => salariO; set => salariO = value; }

    public int antigüedad(int A_Ingreso, int A_Actual){
        
        return (A_Actual - A_Ingreso);
    }

    public int edad(int A_Nacimiento, int A_Actual){

        return(A_Actual-A_Nacimiento);
    
    }

    public int jubilación(int edad, char genero){

        if(genero == 'm' || genero == 'M'){
            return (65-edad);
        }
        else{
            return (60-edad);
        }
    }

    public double salario(int ant, int cargo, char estadoCivil, double suelBasico){

        double adicional=suelBasico;

        if(ant <= 20){
            adicional += (suelBasico * (ant/100));
        }
        else{
            adicional +=(suelBasico * 0.25);
        }

        if(cargo == 2 || cargo == 3){
            adicional *= 1.50;
        }

        if(estadoCivil == 'c'){
            adicional += 15000;
        }

        double total = suelBasico + adicional;

        return total;
    }
    
}
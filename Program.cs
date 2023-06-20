internal class Program
{
    private static void Main(string[] args)
    {
        // [Modificador de Acceso] tipo Identificador;
        int edad;
        string ? nombre;
        string apellido = string.Empty;
        string direccion = "";
        // const double iva = 19.00;
        // bool estado = false;

        try{
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine() ?? String.Empty;
            Console.Beep();
            Console.WriteLine("{0} ingrese su apellido", nombre.ToUpper());
            apellido = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("{0} {1} Ingrese su edad: ", nombre, apellido);
            edad = Convert.ToInt16(Console.ReadLine());
            if(edad >= 1 && edad <=11){
                Console.WriteLine("{0} {1} Es un niño", nombre, apellido);
            }else if(edad > 11 && edad <=17){
                Console.WriteLine("{0} {1} Es un adolescente", nombre, apellido);
            }else if(edad > 17 && edad <=59){
                Console.WriteLine("{0} {1} Es mayor de edad", nombre, apellido);
            }else{
                Console.WriteLine("{0} {1} Es un adulto mayor", nombre, apellido);
            }
            Console.WriteLine("{0} {1} Ingrese su dirección: ", nombre, apellido);
            direccion = Console.ReadLine() ?? String.Empty;

        } catch (Exception ex){
            Console.WriteLine("Error al momento de ingresar el dato {0}", ex.Message);
            Console.ReadKey();
        }


    }
}
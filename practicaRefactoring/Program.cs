internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    // AC1 RENOMBRAR VARIABLES
    // public class Calculator
    // {
    //     public int x, y, z;

    //     public void calc()
    //     {
    //         x = 10;
    //         y = 20;
    //         z = x + y;
    //     }

    //     public void prnt()
    //     {
    //         Console.WriteLine(z);
    //     }
    // }
    // public class Calculator()
    // {

    //     public int Calculadora(int numero1, int numero2)
    //     {
    //         int total = numero1 + numero2;
    //         return total;
    //     }

    //     public void PrintarResultado(int total)
    //     {
    //         Console.WriteLine(total);
    //     }
    // }

    // Ejercicio 2: Identificar Code Smells
    // Identifica los code smells en el siguiente código y 
    // sugiere mejoras:

    // public class UserManager
    // {
    //     public void CreacionUsuario(string usarName, int age, string email)
    //     {
    //         if (age > 18)
    //         {
    //             if (usarName.Length > 0)
    //             {
    //                 if (email.Length > 0)
    //                 {
    //                     // Procesar usuario
    //                     Console.WriteLine("Usuario creado");
    //                 }
    //                 else
    //                 {
    //                     Console.WriteLine("Email vacío");
    //                 }
    //             }
    //             else
    //             {
    //                 Console.WriteLine("Nombre vacío");
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("Usuario menor de edad");
    //         }
    //     }
    // }

    // AC3

    // public void ProcessOrder(Order o) 
    // {
    //     // Validar
    //     if (o.Items.Count == 0) return;
    //     if (o.Customer == null) return;

    //     // Calcular
    //     decimal total = 0;
    //     foreach (var item in o.Items) {
    //         total += item.Price * item.Quantity;
    //     }

    //     // Aplicar descuento
    //     if (o.Customer.IsVIP) {
    //         total = total * 0.9m;
    //     }

    //     // Guardar
    //     database.SaveOrder(o);

    //     // Enviar email
    //     string msg = "Tu pedido es: " + total;
    //     emailService.Send(o.Customer.Email, msg);
    // }

    // public class Procesos
    // {
    //     public void ProcessValidar(Order validation)
    //     {
    //         if (validation.Items.Count == 0) return;
    //         if (validation.Customer == null) return;
    //     }

    //     public void ProcessCalcular(Order calculator)
    //     {
    //         decimal total = 0;
    //         foreach (var item in calculator.Items)
    //         {
    //             total += item.Price * item.Quantity;
    //         }
    //     }

    //     public void ProcessDescuento(Order order, decimal total)
    //     {
    //         if (order.Customer.IsVIP)
    //         {
    //             total = total * 0.9m;
    //         }
    //     }

    //     public void ProcessGuardar(Order saveData)
    //     {
    //         database.SaveOrder(saveData);
    //     }
    // }

    // public class emailService
    // {
    //     public void ProcessEnviarEmail(Order order, decimal total)
    //     {
    //         string message = "Tu pedido es: " + total;
    //         emailService.Send(order.Customer.Email, message);
    //     }
    //     public static void Send(string email, string content)
    //     {
    //         Console.WriteLine($"Enviando a {email}: {content}");
    //     }
    // }
    // EJERCICIO 4

    // public int Calcular(int numero1, int numero2)
    //     {

    //         int totalSuma = numero1 + numero2;


    //         int totalMultiplicacion = totalSuma * 2;


    //         int totalGeneral = totalMultiplicacion - 5;


    //         return totalGeneral;
    //     }


    // EJERCICIO 5  



    // public class User
    // {
    //     public int userId, age;
    //     public string name, email;

    //     public void Information(int id, int year, string userName, string userEmail)
    //     {
    //         userId = id; 
    //         age = year; 
    //         name = userName; 
    //         email = userEmail;
    //     }

    //     public void AgeApprovement()
    //     {
    //         // chequear edad
    //         if (age < 18)
    //         {
    //             Console.WriteLine("No");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Si");
    //         }
    //     }

    //     public void EmailSending()
    //     {
    //         // enviar datos
    //         if (email.Length > 0)
    //         {
    //             // email es valido
    //             Console.WriteLine("Email sent to: " + email);
    //         }
    //     }
    // }

    // EJERCICIO 6
    public class User
    {
        public void Information()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();
        }
        public void showData(string name, string address, int age, int phoneNumber)
        {
            Console.WriteLine($"Name: {name},Address: {address}, Age: {age}, Phone Number: {phoneNumber}");
        }
    }
    

    

}
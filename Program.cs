using Sobrecarga_y_encapsulamiento_3;
Console.WriteLine("Tipo de reserva:");
Console.WriteLine("1 - Solo Evento");
Console.WriteLine("2 - Con Catering");
Console.WriteLine("3 - Full");
int tipoReserva = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese nombre del cliente:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese cantidad de invitados:");
int invitados = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese cantidad de horas:");
int horas = int.Parse(Console.ReadLine());
Console.WriteLine("¿Incluye mozos? (S/N)");
bool mozos = Console.ReadLine().ToUpper() == "S";
Console.WriteLine("Ingrese día (V/S/D):");
char dia = char.Parse(Console.ReadLine().ToUpper());
char tipoMenu = ' ';
int animaciones = 0;
if (tipoReserva == 2 || tipoReserva == 3)
{
    Console.WriteLine("Tipo de menú (B/P/N):");
    tipoMenu = char.Parse(Console.ReadLine().ToUpper());
}
if (tipoReserva == 3)
{
    Console.WriteLine("Cantidad de animaciones:");
    animaciones = int.Parse(Console.ReadLine());
}

Reserva reserva1 = new Reserva(nombre, invitados, horas, mozos, dia, tipoReserva, tipoMenu, animaciones);

reserva1.CalcularValor();

Console.Clear();
Console.WriteLine(reserva1.ObtenerResumen());
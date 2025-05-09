// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using FirsCSharpNet6;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de aplicaciones web 2025-01";
int edad = 20;
double salario = 1200;
var alumno = "Alex Perales";
var peso = 75;

var persona1 = new Persona(){ dni = 12345678, nombreCompleto = "Juan Perez", telefono = "987654321",estado = true}
;
var persona2 = new Persona(){ dni = 12345678, nombreCompleto = "Maria Lopez",telefono = "987654321",estado = true};
var persona3 = new Persona(44009988, "Pedro Garcia", "987654321", true);

var personas = new List<Persona>();
personas.Add(persona1);
personas.Add(persona2);
personas.Add(persona3); 
foreach(var item in personas)
{
    Console.WriteLine(item.dni + " | " + item.nombreCompleto);
}
var busqueda = personas.Find(x => x.dni == 44009988);
if (busqueda != null)
{
    Console.WriteLine($"Dni encontrado:  { busqueda.nombreCompleto}");
}
else
{
    Console.WriteLine("El dni no existe en la lista");
}


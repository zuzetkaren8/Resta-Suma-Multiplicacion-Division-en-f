open System
// For more information see https://aka.ms/fsharp-console-apps

let opesuma a b = a + b
let operesta a b = a - b
let opemultiplicacion a b = a * b
let opedivision a b = a / b
[<EntryPoint>]
let main argv=
    Console.WriteLine("SIMULACION DE CALCULADORA")
    Console.WriteLine("Introduzca dos numeros")

    let numero1 = Console.ReadLine() //funcion suma
    let numero2 = Console.ReadLine() //funcion resta
    let valor1 = Convert.ToInt32(numero1) //funcion multiplicacion
    let valor2 = Convert.ToInt32(numero2) //funcion division

    let mutable resultado = 0

    resultado <- opesuma valor1 valor2
    Console.WriteLine("La suma de "+valor1.ToString()+" y "+valor2.ToString()+" es: "+resultado.ToString())

    resultado <- operesta valor1 valor2
    Console.WriteLine("La resta de "+valor1.ToString()+" y "+valor2.ToString()+" es: "+resultado.ToString())

    resultado <- opemultiplicacion valor1 valor2
    Console.WriteLine("La multiplicacion de "+valor1.ToString()+" y "+valor2.ToString()+" es: "+resultado.ToString())

    resultado <- opedivision valor1 valor2
    Console.WriteLine("La division de "+valor1.ToString()+" y "+valor2.ToString()+" es: "+resultado.ToString())

    0
   

// using System;
// class Programa
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Encadeando For");

//         //*
//         //**
//         //***
//         //****
//         //*****

//         //com break 
//         for (int contadorLinha = 0; contadorLinha <= 9; contadorLinha++)
//         {
//             for (int contadorColuna = 0; contadorColuna <= 9; contadorColuna++)
//             {
//                 Console.Write("*");
//                 if (contadorColuna >= contadorLinha)
//                     break;
//             }
//             Console.WriteLine();
//         }

//         //sem break 
//         for (int contadorLinha = 0; contadorLinha <= 9; contadorLinha++)
//         {
//             for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }

//         Console.WriteLine("Tecle enter para sair...");
//         Console.ReadLine();
//     }
// }
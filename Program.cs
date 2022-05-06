// See https://aka.ms/new-console-template for more information
using System;
using dotnet__AbstraindoumjogoRPGcomC.src.Entities;

namespace dotnet__AbstraindoumjogoRPGcomC
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
        }
    }
}
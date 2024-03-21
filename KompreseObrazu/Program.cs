﻿using System;
using System.Collections.Generic;

namespace Komprese
{
    public class KompreseObrazu
    {
        public static void Main(string[] args)
        {
            // Cesta k testovacímu souboru
        String testFilePath = @"C:\Users\VojtěchBláha\Documents\GitHub\cv-komprese-obrazu-v2-Vojd56\KompreseObrazu\CSV\obr1-10.csv";

            // Vytvoření instance třídy Obrazek
            Obrazek inputCSV = new Obrazek(testFilePath);

            // Vytvoření 2D pole obsahujícího hodnoty barev obrázku
            int[,] imageArray = inputCSV.GetImageArray();

            // Test metody, která spočítá počet řádků vstupního obrázku
            Console.WriteLine("Počet vertikálních řádků {0}", inputCSV.CountLines(testFilePath));

            // Test metody, která spočítá počet symbolů vstupního obrázku v prvním řádku
            Console.WriteLine("Počet horizontálních symbolů {0}\n\n-----------------------------------------------", inputCSV.CountSymbolInLine(testFilePath));

            // Výpis načteného obrázku
            inputCSV.vypisImg();

            // Seznam unikátních barev
            List<int> uniqueColors = inputCSV.PaletaBarevObrazku();

            // Vytvoření slovníku pro ukládání počtu výskytů jednotlivých barev v obrázku
            Dictionary<int, int> colorCounts = new Dictionary<int, int>();

            // Spočítat počty výskytů jednotlivých barev v obrázku
            foreach (int color in uniqueColors)
            {
                int count = inputCSV.CountColorOccurrences(color);
                colorCounts.Add(color, count);
            }

            // Výpis jednotlivých barev a jejich počtu výskytů
            Console.WriteLine("-----------------------------------------------\n\nBarev v obrázku:");
            foreach (var kvp in colorCounts)
            {
                Console.WriteLine($"Barvička: {kvp.Key}, Počet barviček: {kvp.Value}");
            }

            List<int> unikatniBarvy = inputCSV.PaletaBarevObrazku();
            Console.WriteLine("-----------------------------------------------\n\nUnikátní Barvy");
            foreach(int element in unikatniBarvy){
            Console.Write($"{element},");
            }   
    }
}
}

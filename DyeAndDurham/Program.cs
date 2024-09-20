// See https://aka.ms/new-console-template for more information
using DyeAndDurham.File_Readers;
using DyeAndDurham.File_Writers;
using DyeAndDurham.Logic;

Console.WriteLine("Hello, World!");

FileReader reader = new FileReader();
NameFinder finder = new NameFinder();
NameSorter sorter = new NameSorter();
FileWriter writer = new FileWriter();

writer.WriteNames(sorter.SortPeople(finder.GetNames(reader.ReadFile("C:\\Users\\Valkyrie\\source\\repos\\DyeAndDurham\\DyeAndDurham\\TestInput.txt"))));
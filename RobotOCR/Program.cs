// See https://aka.ms/new-console-template for more information
using EasyAutomationFramework;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

var path = "C:\\Users\\filipe.brito\\Documents\\Projects\\Estudo\\arquivos\\";
//OCR.GetText(path + "chaves.png");
//Console.WriteLine();

Process.Start("calc");
Thread.Sleep(1000);
OCR.Click(path + "7.png");
OCR.Click(path + "mais.png");
OCR.Click(path + "3.png");
OCR.Click(path + "igual.png");

﻿// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

Console.WriteLine("Quantos litros de Alcool foram vendidos? ");
float litrosAlcool = float.Parse(Console.ReadLine());

Console.WriteLine("Quantos litros de Gasolina foram vendidos? ");
float litrosGasolina = float.Parse(Console.ReadLine());

Console.WriteLine(CalcularValores(litrosAlcool, litrosGasolina));

static (float, float) CalcularValores(float a, float g)
{
    float precoGasolina = 5.30f;
    float precoAlcool = 4.90f;
    float totalGasolina;
    float totalAlcool;

    if (a <= 20)
    {
        precoAlcool -= precoAlcool * 0.03f;
        totalAlcool = Math.Round(precoAlcool * a,2);
    }
    else
    {
        precoAlcool -= precoAlcool * 0.05f;
        totalAlcool = Math.Round(precoAlcool * a,2);
    }


    if (g <= 20)
    {
        precoGasolina -= precoGasolina * 0.04f;
        totalGasolina = Math.Round(precoGasolina * g,2);
    }
    else
    {
        precoGasolina -= precoGasolina * 0.06f;
        totalGasolina = Math.Round(precoGasolina * g,2);
    }

    return (totalAlcool, totalGasolina);
}


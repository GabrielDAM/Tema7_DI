using System;

public class Triangulo	
{
	private string color;
	private float bAse;
	private float altura;
	private float area;

	public Triangulo(float bAse, float altura)
	{
		this.color = "Rojo";
		this.bAse = base;
		this.altura = altura;
		calcularArea();
	}

	public Triangulo()
	{
		this.color = "Rojo";
		this.bAse = 0;
		this.altura = 0;
		this.area = 0;
	}

	private void calcularArea() 
	{
		this.area = base * altura / 2;
	}

	public override string ToString()
	{
		return string.Format("Triangulo: {}\n" +
							"base: {}\n" +
							"altura: {}\n" +
							"area: {}\n");
	}
}

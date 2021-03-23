using System;

public class Rectangulo
{
	private string color;
	private float bAse;
	private float altura;
	private float area;

	public Rectangulo()
	{
		this.color = "";
		this.bAse = 0;
		this.altura = 0;
		this.area = 0;
	}

	public Rectangulo(float bAse, float altura)
	{
		this.color = "Azul";
		this.bAse = bAse;
		this.altura = altura;
		calcularArea();
	}

	private void calcularArea() 
	{
		area = base * altura;
	}

	public override string ToString()
    {
		return string.Format("Rectangulo: {}\n" +
							"base: {}\n" +
                            "altura: {}\n" +
                            "area: {}\n");
    }
}

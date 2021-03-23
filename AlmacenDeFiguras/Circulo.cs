using System;

public class Circulo
{
	private string color;
	private float radio;
	private float area;

	public Circulo(float radio, float area)
	{
		this.radio = radio;
		calcularArea();
	}

	public Circulo()
	{
		this.radio = 0;
		this.area = 0;
	}

	private void calcularArea()
	{
		this.area = Math.PI * radio * radio;
	}

	public override string ToString()
	{
		return string.Format("Circulo: {}\n" +
							"radio: {}\n" +
							"area: {}\n", color, radio, area);
	}
	
}

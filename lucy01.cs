/* Title: Luces en el firmamento.
 * Summary: Implementación del proceso identificador de cuerpos brillantes en el cielo.
 * Author: Luis Mateo
 * Since: 20211115
 * Version: 1.0
 * Remarks: Versión inicial, con if-else
 * 
 * How to Identify that Light in the Sky
 * http://www.leagueoflostcauses.com/
 */

// Idiomas ENG / ESP / VAL / FRA /ITA
// Respuesta corta Y/N, S/N, S/N, O/N
// Respuesta larga yes/no sí/no si/no oui/non si/no
// Preguntas
// Objetos

using System;

/// <Summary>Luces en el firmamento v1.0</Summary>
/// <Remarks>Proceso identificador de cuerpos brillantes en el cielo</Remarks>
/// <License>Creative Commons 4.0 by 2021 Luis Mateo</License>

public class Lucy
{   
	public static void Main(string[] args)     
	{
		string RespIdioma;
		
		Console.Write("¿En qué idioma? [ENG ESP VAL FRA ITA] ");
		RespIdioma = Console.ReadLine();
		RespIdioma = RespIdioma.ToUpper();
		Console.WriteLine(RespIdioma);
		switch (RespIdioma)
		{
			case "ENG": 
				{
					Console.WriteLine("Inglés");
					ENGprocedure();
				}
				break;
			case "ESP": Console.WriteLine("Español");
				break;
			case "VAL": Console.WriteLine("Valencià");
				break;
			case "FRA": Console.WriteLine("Français");
				break;
			case "ITA": Console.WriteLine("Italiano");
				break;
			default: Console.WriteLine("Ese idioma no lo conozco");
				break;
		} 
	} // Fin de Main

/// <Summary>Procedimiento en "english"</Summary>	
	static void ENGprocedure()
	{
		string respuesta;
		Console.Write("Is it really big? ");
		respuesta = Console.ReadLine();
		respuesta = respuesta.ToUpper();
		if (respuesta.Equals("Y")) 
		{
			Console.Write("Are your retinas burning? ");
			respuesta = Console.ReadLine();
			respuesta = respuesta.ToUpper();
			if (respuesta.Equals("Y")) 
				Console.WriteLine("SUN");
			else
				Console.WriteLine("MOON");
		}
		else // no es grande
		{
			Console.Write("Is it moving? ");
			respuesta = Console.ReadLine();
			respuesta = respuesta.ToUpper();
			if (respuesta.Equals("Y")) 
			{
				Console.Write("So quickly you almost missed it? ");
				respuesta = Console.ReadLine();
				respuesta =  respuesta.ToUpper();
				if (respuesta.Equals("Y")) 
				{
					Console.Write("Is it extra super bright? ");
					respuesta = Console.ReadLine();
					respuesta =  respuesta.ToUpper();
					if (respuesta.Equals("Y")) 
					{
						Console.Write("...ending with a dramatic explosion? ");
						respuesta = Console.ReadLine();
						respuesta =  respuesta.ToUpper();
						if (respuesta.Equals("Y")) 
							Console.WriteLine("BOLIDE");
						else 
							Console.WriteLine("FIREBALL");
					}
					else
						Console.WriteLine("METEOR");
				}
				else // No es rápido
				{
					Console.Write("Is anything blinking? ");
					respuesta = Console.ReadLine();
					respuesta =  respuesta.ToUpper();
					if (respuesta.Equals("Y")) 
						Console.WriteLine("AIRCARFT");
					else
					{
						Console.Write("Are any astronauts waving at you? ");
						respuesta = Console.ReadLine();
						respuesta =  respuesta.ToUpper();
						if (respuesta.Equals("Y")) 
								Console.WriteLine("ISS, International Space Station");
						else
							Console.WriteLine("Artificial satellite");
					}
				}
			}
			else // No se mueve
			{
				Console.Write("Any twinkling? ");
				respuesta = Console.ReadLine();
				respuesta =  respuesta.ToUpper();
				if (respuesta.Equals("Y")) 
					Console.WriteLine("STAR");
				else
				{
					Console.Write("Is it kinda fuzzy with a tail? ");
					respuesta = Console.ReadLine();
					respuesta =  respuesta.ToUpper();
					if (respuesta.Equals("Y")) 
						Console.WriteLine("COMET ");
					else
					{
						Console.Write("Is it attached to a boat? ");
						respuesta = Console.ReadLine();
						respuesta =  respuesta.ToUpper();
						if (respuesta.Equals("Y")) 
							Console.WriteLine("MATHEAD LIGHT");
						else
							Console.WriteLine("PLANET");
					}
				}
			}
		}
	} // Fin de ENGprocedure

/// <Summary>Procedimiento en "español"</Summary>	
	static void ESPprocedure()
	{
		Console.Write("ESTE CASO ESTÁ POR DESARROLLAR...");
	} // Fin de ENGprocedure

/// <Summary>Procedimiento en "valencià"</Summary>		
	static void VALprocedure()
	{
		Console.Write("ESTE CASO ESTÁ POR DESARROLLAR...");
	} // Fin de VALprocedure

/// <Summary>Procedimiento en "français"</Summary>	
	static void FRAprocedure()
	{
		Console.Write("ESTE CASO ESTÁ POR DESARROLLAR...");
	} // Fin de FRAprocedure

/// <Summary>Procedimiento en "italiano"</Summary>	
	static void ITAprocedure()
	{
		Console.Write("ESTE CASO ESTÁ POR DESARROLLAR...");
	} // Fin de ITAprocedure
		
} // Fin de Lucy

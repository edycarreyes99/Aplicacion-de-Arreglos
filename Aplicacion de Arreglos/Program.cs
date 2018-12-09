using System;
using System.Linq;

namespace Aplicacion_de_Arreglos
{

    class Program
    {


        static void Main( string [ ] args )
        {

            int tipoArreglo = 0;
            int opcionArreglonombres = 0;
            int opcionArregloNumeros = 0;
            int opcionArregloEncuestas = 0;
            int cantidadarreglodenombres = 0;
            int cantidadarreglodenumeros = 0;
            int cantidadarreglodeencuestas = 0;
            int contadorarreglodeencuestas = 1;
            string nombreabuscar;
            string [ ] sexo = new string [ 2 ] { "Masculino", "Femenino" };
            string [ ] estadoCivil = new string [ 2 ] { "Soltero/a", "Casado/a" };
            string [ ] arreglodenombres = new string [ 500 ];
            int [ ] arreglodenumeros = new int [ 500 ];
            Encuesta [ ] arreglodeencuestas = new Encuesta [ 500 ];
            do
            {
                Console.Clear ( );
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine ( "Ingrese una opción" );
                Console.WriteLine ( "1. Arreglo de Nombres" );
                Console.WriteLine ( "2. Arreglo de Numeros" );
                Console.WriteLine ( "3. Arreglo Combinado" );
                Console.WriteLine ( "4. Salir del Programa" );
                tipoArreglo = int.Parse ( Console.ReadLine ( ) );
                Console.Clear ( );
                switch ( tipoArreglo )
                {
                    case 1:
                        do
                        {
                            Console.Clear ( );
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine ( "Arreglo de Nombres:" );
                            Console.WriteLine ( "\t1. Ingresar Nombre" );
                            Console.WriteLine ( "\t2. Mostrar todos los nombres ingresados" );
                            Console.WriteLine ( "\t3. Buscar un nombre" );
                            Console.WriteLine ( "\t4. Regresar al menu principal" );
                            opcionArreglonombres = int.Parse ( Console.ReadLine ( ) );
                            Console.Clear ( );
                            switch ( opcionArreglonombres )
                            {
                                case 1:
                                    Console.WriteLine ( "Ingrese un Nombre y luego presione Enter" );
                                    arreglodenombres [ cantidadarreglodenombres ] = Console.ReadLine ( );
                                    Console.Clear ( );
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine ( "Nombre agregado Correctamente!" );
                                    Console.ReadKey ( );
                                    Console.Clear ( );
                                    cantidadarreglodenombres++;
                                    break;
                                case 2:
                                    if ( cantidadarreglodenombres == 0 )
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha ingresado ningun nombre, ingrese un nombre y vuelvalo a intentar" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine ( "Mostrando Todos los Nombres:" );
                                        for ( int i = 0 ; i < cantidadarreglodenombres ; i++ )
                                        {
                                            Console.WriteLine ( i + 1 + ". " + arreglodenombres [ i ] );
                                        }
                                        Console.ReadKey ( );
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine ( "Ingrese un nombre o una letra para buscar" );
                                    nombreabuscar = Console.ReadLine ( );
                                    Console.Clear ( );
                                    int aciertos = 1;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine ( "Nombres encontrados:" );
                                    for ( int i = 0 ; i < cantidadarreglodenombres ; i++ )
                                    {
                                        if ( arreglodenombres [ i ].Contains ( nombreabuscar ) )
                                        {
                                            Console.WriteLine ( "\t" + aciertos + ". " + arreglodenombres [ i ] );
                                            for ( int j = 0 ; j < 9 ; j++ )
                                            {
                                                Console.WriteLine ( "\t  " + arreglodenombres [ i ] );
                                            }
                                            aciertos++;
                                        }
                                        else if ( aciertos == 1 )
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine ( "No se ha encontrado ningun nombre con ese parametro" );
                                        }
                                    }
                                    Console.ReadKey ( );
                                    break;
                                default:
                                    break;
                            }
                        } while ( opcionArreglonombres != 4 );
                        break;
                    case 2:
                        do
                        {
                            Console.Clear ( );
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine ( "Arreglo de Numeros:" );
                            Console.WriteLine ( "\t1. Ingresar Numero" );
                            Console.WriteLine ( "\t2. Mostrar todos los numeros ingresados" );
                            Console.WriteLine ( "\t3. Mostrar la cantidad de numeros pares e impares" );
                            Console.WriteLine ( "\t4. Mostrar el numero con el mayor valor" );
                            Console.WriteLine ( "\t5. Regresar al Menu principal" );
                            opcionArregloNumeros = int.Parse ( Console.ReadLine ( ) );
                            Console.Clear ( );
                            switch ( opcionArregloNumeros )
                            {
                                case 1:
                                    Console.WriteLine ( "Ingrese un numero y luego precione Enter" );
                                    arreglodenumeros [ cantidadarreglodenumeros ] = int.Parse ( Console.ReadLine ( ) );
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Clear ( );
                                    Console.WriteLine ( "Numero agregado con éxito!" );
                                    Console.ReadKey ( );
                                    cantidadarreglodenumeros++;
                                    break;
                                case 2:
                                    if ( cantidadarreglodenumeros == 0 )
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha agregado ningun numero al arreglo, por favor ingrese uno e intente nuevamente" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        for ( int i = 0 ; i < cantidadarreglodenumeros ; i++ )
                                        {
                                            Console.Write ( arreglodenumeros [ i ] + "|" );
                                        }
                                        Console.ReadKey ( );
                                    }
                                    break;
                                case 3:
                                    if ( cantidadarreglodenumeros == 0 )
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha agregado ningun numero al arreglo, por favor ingrese uno e intente nuevamente" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        int pares = 0;
                                        int impares = 0;
                                        for ( int i = 0 ; i < cantidadarreglodenumeros ; i++ )
                                        {
                                            if ( arreglodenumeros [ i ] % 2 == 0 )
                                            {
                                                pares++;
                                            }
                                            else
                                            {
                                                impares++;
                                            }
                                        }
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine ( "Cantidad de numeros Pares: " + pares );
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "Cantidad de numeos Impares: " + impares );
                                        Console.ReadKey ( );
                                    }
                                    break;
                                case 4:
                                    if ( cantidadarreglodenumeros == 0 )
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha agregado ningun numero al arreglo, por favor ingrese uno e intente nuevamente" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine ( "El numero con mayor valor que se ha ingresado es: " + arreglodenumeros.Max ( ) );
                                        Console.ReadKey ( );
                                    }
                                    break;
                            }
                        } while ( opcionArregloNumeros != 5 );
                        break;
                    case 3:
                        do
                        {
                            Console.Clear ( );
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine ( "Arreglo de Encuestas:" );
                            Console.WriteLine ( "\t1. Ingresar Encuesta" );
                            Console.WriteLine ( "\t2. Mostrar todos las encuestas ingresadas" );
                            Console.WriteLine ( "\t3. Mostrar la cantidad de mujeres y varones encuestados" );
                            Console.WriteLine ( "\t4. Mostrar el porcentaje de hombres encuestados" );
                            Console.WriteLine ( "\t5. Mostrar la cantidad de mujeres encuestadas que son casadas" );
                            Console.WriteLine ( "\t6. Regresar al Menu principal" );
                            opcionArregloEncuestas = int.Parse ( Console.ReadLine ( ) );
                            Console.Clear ( );
                            switch ( opcionArregloEncuestas )
                            {
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine ( "\t\tEncuesta #" + contadorarreglodeencuestas );
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    arreglodeencuestas [ cantidadarreglodeencuestas ] = new Encuesta ( );
                                    Console.WriteLine ( "Ingrese el Nombre de la persona" );
                                    arreglodeencuestas [ cantidadarreglodeencuestas ].Nombre = Console.ReadLine ( );
                                    Console.WriteLine ( "Ingrese su Apellido" );
                                    arreglodeencuestas [ cantidadarreglodeencuestas ].Apellido = Console.ReadLine ( );
                                    Console.WriteLine ( "Ingrese su Edad" );
                                    arreglodeencuestas [ cantidadarreglodeencuestas ].Edad = int.Parse ( Console.ReadLine ( ) );
                                    Console.Clear ( );
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine ( "Seleccione el numero que corresponde a su sexo (solo el numero)" );
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    for ( int i = 0 ; i <= 1 ; i++ )
                                    {
                                        int numeroSexo = i + 1;
                                        Console.WriteLine ( "\t" + numeroSexo + ". " + sexo [ i ] );
                                    }
                                    int respuestaSexo;
                                    respuestaSexo = int.Parse ( Console.ReadLine ( ) );
                                    arreglodeencuestas [ cantidadarreglodeencuestas ].Sexo = sexo [ respuestaSexo - 1 ];
                                    Console.Clear ( );
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine ( "Seleccione el numero que corresponde a su estado civil (solo el numero)" );
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    for ( int i = 0 ; i <= 1 ; i++ )
                                    {
                                        int numeroEstadoCivil = i + 1;
                                        Console.WriteLine ( "\t" + numeroEstadoCivil + ". " + estadoCivil [ i ] );
                                    }
                                    int respuestaEstadoCivil;
                                    respuestaEstadoCivil = int.Parse ( Console.ReadLine ( ) );
                                    arreglodeencuestas [ cantidadarreglodeencuestas ].EstadoCivil = estadoCivil [ respuestaEstadoCivil - 1 ];
                                    Console.Clear ( );
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine ( "Se ha añadido la encuesta correctamente" );
                                    Console.ReadKey ( );
                                    Console.ForegroundColor = ConsoleColor.White;
                                    cantidadarreglodeencuestas++;
                                    contadorarreglodeencuestas++;
                                    break;
                                case 2:
                                    if ( cantidadarreglodeencuestas == 0 )
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha ingresado ninguna encuesta, por favor ingrese una encuesta e intente nuevamente" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        for ( int i = 0 ; i < cantidadarreglodeencuestas ; i++ )
                                        {
                                            Console.WriteLine ( i + 1 );
                                            Console.WriteLine ( "\tNombre: " + arreglodeencuestas [ i ].Nombre );
                                            Console.WriteLine ( "\tApellido: " + arreglodeencuestas [ i ].Apellido );
                                            Console.WriteLine ( "\tEdad: " + arreglodeencuestas [ i ].Edad );
                                            Console.WriteLine ( "\tSexo: " + arreglodeencuestas [ i ].Sexo );
                                            Console.WriteLine ( "\tEstado Civil: " + arreglodeencuestas [ i ].EstadoCivil );
                                            Console.WriteLine ( "-------------------------------------------------------------------------------------------" );
                                        }
                                        Console.ReadKey ( );

                                    }
                                    break;
                                case 3:
                                    if ( cantidadarreglodeencuestas == 0 )
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha ingresado ninguna encuesta, por favor ingrese una encuesta e intente nuevamente" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        int varones = 0;
                                        int mujeres = 0;
                                        for ( int i = 0 ; i < cantidadarreglodeencuestas ; i++ )
                                        {
                                            if ( arreglodeencuestas [ i ].Sexo == "Masculino" )
                                            {
                                                varones++;
                                            }
                                            else
                                            {
                                                mujeres++;
                                            }
                                        }
                                        Console.WriteLine ( "Cantidad de Varones Encuestados: " + varones );
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine ( "Cantidad de Mujeres Encuestadas: " + mujeres );

                                        Console.ReadKey ( );

                                    }
                                    break;
                                case 4:
                                    if ( cantidadarreglodeencuestas == 0 )
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha ingresado ninguna encuesta, por favor ingrese una encuesta e intente nuevamente" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        double varones = 0;
                                        for ( int i = 0 ; i < cantidadarreglodeencuestas ; i++ )
                                        {
                                            if ( arreglodeencuestas [ i ].Sexo == sexo [ 0 ] )
                                            {
                                                varones++;
                                            }
                                        }
                                        int cantidad = contadorarreglodeencuestas - 1;
                                        double porcentaje = ( varones / cantidad ) * 100;
                                        Console.Write ( "Porcentaje de Varones Encuestados: " + porcentaje + "%" );

                                        Console.ReadKey ( );

                                    }
                                    break;
                                case 5:
                                    if ( cantidadarreglodeencuestas == 0 )
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine ( "No se ha ingresado ninguna encuesta, por favor ingrese una encuesta e intente nuevamente" );
                                        Console.ReadKey ( );
                                    }
                                    else
                                    {
                                        Console.Clear ( );
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        int mujeres = 0;
                                        for ( int i = 0 ; i < cantidadarreglodeencuestas ; i++ )
                                        {
                                            if ( ( arreglodeencuestas [ i ].Sexo == "Femenino" ) && ( arreglodeencuestas [ i ].EstadoCivil == "Casado/a" ) )
                                            {
                                                mujeres++;
                                            }
                                        }
                                        Console.WriteLine ( "Porcentaje de mujeres casadas Encuestadas: " + mujeres );

                                        Console.ReadKey ( );

                                    }
                                    break;
                            }
                        } while ( opcionArregloEncuestas != 6 );
                        break;
                }
            } while ( tipoArreglo != 4 );
        }
    }
    class Encuesta
    {
        string sexo;
        string nombre;
        string apellido;
        int edad;
        string estadoCivil;


        public Encuesta() { }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
} 'p0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrucoNetBackend
{
    class MainBackend
    {
        static void Main(string[] args)
        {
            bienvenida();
            login();
            String comSel = "";
            String abmSel = "";

            do
            {
                menuPrincipal();
                prompt();
                comSel = leerSeleccion();
                //Valido comando de selección sobre el primer menu
                if (Validator.SelComando(comSel))
                {
                    if(!comSel.Equals("5")){
                        menuSecundario();
                        prompt();
                        abmSel = leerSeleccion();

                        //Valido comando de selección sobre el segundo menu
                        if (Validator.SelComando(abmSel))
                        {
                            if(!abmSel.Equals("5")){
                                String com = abmSel.Insert(0, comSel);
                                //Console.WriteLine(com);

                                //Identifico la funcionalidad según lo seleccionado
                                //por el usuario en los menus anteriores
                                switch (com)
                                {
                                    case "11":
                                        Console.WriteLine("Alta Usuario");
                                        altaUsuarioUI();
                                        break;
                                    case "12":
                                        Console.WriteLine("Baja Usuario");
                                        bajaUsuarioUI();
                                        break;
                                    case "13":
                                        Console.WriteLine("Editar Usuario");
                                        editarUsuarioUI();
                                        break;
                                    case "14":
                                        Console.WriteLine("Consulta Usuario");
                                        consultaUsuarioUI();
                                        break;
                                    case "21":
                                        Console.WriteLine("Alta Partido");
                                        altaPartidoUI("new");
                                        break;
                                    case "22":
                                        Console.WriteLine("Baja Partido");
                                        bajaPartidoUI();
                                        break;
                                    case "23":
                                        Console.WriteLine("Editar Partido");
                                        altaPartidoUI("edit");
                                        break;
                                    case "24":
                                        Console.WriteLine("Consulta Partido");
                                        consultaPartidoUI();
                                        break;
                                    case "31":
                                        Console.WriteLine("Alta Ranking");
                                        altaRankingUI("new");
                                        break;
                                    case "32":
                                        Console.WriteLine("Baja Ranking");
                                        bajaRankingUI();
                                        break;
                                    case "33":
                                        Console.WriteLine("Editar Ranking");
                                        altaRankingUI("edit");
                                        break;
                                    case "34":
                                        Console.WriteLine("Consulta Ranking");
                                        consultaRankingUI();
                                        break;
                                    case "41":
                                        Console.WriteLine("Alta Denuncia");
                                        altaDenunciaUI();
                                        break;
                                    case "42":
                                        Console.WriteLine("Baja Denuncia");
                                        bajaDenunciaUI();
                                        break;
                                    case "43":
                                        Console.WriteLine("Editar Denuncia");
                                        editarDenunciaUI();
                                        break;
                                    case "44":
                                        Console.WriteLine("Consulta Denuncia");
                                        consultaDenunciaUI();
                                        break;
                                    default:
                                        Console.WriteLine("Funcionalidad no definida");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            comandoInvalido();
                        }
                    }
                }
                else
                {
                    comandoInvalido();
                }
            } while (!(comSel.Equals("5") || abmSel.Equals("5")));
            despedida();




            Console.ReadLine();
        }

        static void bienvenida()
        {
            Console.WriteLine("Bienvenido TrucoNet Backend");
        }

        static void despedida()
        {
            Console.WriteLine("Adios, hasta la proxima.");
        }

        static void prompt()
        {
            Console.Write("> ");
        }

        static void comandoInvalido()
        {
            Console.WriteLine("Seleccion no válida.");
        }

        static String leerSeleccion()
        {
            return Console.ReadLine();
        }

        static void login()
        {
            Console.Write("login:");
            String login = Console.ReadLine();
            Console.Write("pwd:");
            String pwd = Console.ReadLine();

            // TODO Verificar si el usuario ingresado tiene rol admin
            
            //Console.WriteLine("login: " + login + " - pwd: " + pwd );
        }

        static void menuPrincipal()
        {
            Console.WriteLine("Menu de Opciones - Digite el número de su selección");
            Console.WriteLine("1- Adm.Usuarios");
            Console.WriteLine("2- Adm.Partidos");
            Console.WriteLine("3- Adm.Rankings");
            Console.WriteLine("4- Adm.Denuncias");
            Console.WriteLine("5- Salir");
            Console.WriteLine("");
        }

        static void menuSecundario()
        {
            Console.WriteLine("Seleccione 1- Alta, 2-Baja, 3-Editar, 4-Consultas");
        }


        //***** CONSOLAS UI *****

        //***** USUARIO *****

        static void altaUsuarioUI()
        {
            Console.Write("Ingrese el nombre: ");
            String nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            String apellido = Console.ReadLine();

            Console.Write("Ingrese el telefono: ");
            String tel = Console.ReadLine();

            Console.Write("Ingrese el e-mail: ");
            String mail = Console.ReadLine();

            Console.Write("Ingrese el login: ");
            String login = Console.ReadLine();

            Console.Write("Ingrese el password: ");
            String pwd = Console.ReadLine();

            Console.Write("Ingrese el nick: ");
            String nick = Console.ReadLine();

            String strAdm = "";
            do{
                Console.Write("Es administrador?(Si/No-S/N): ");
                strAdm = Console.ReadLine();
            }while(!Validator.ConsultaComando(strAdm));

            Boolean adm = false;

            if (strAdm.Equals("Si") || strAdm.Equals("S"))
            {
                adm = true;
            }

            if (ServiceBackend.altaUsuario(nombre, apellido, tel, mail, login, pwd, nick, adm))
            {
                Console.WriteLine("Usuario creado con exito");
            }
            else
            {
                Console.WriteLine("El Usuario no fue creado.");
            }
        }


        static void editarUsuarioUI(){

            Console.Write("Ingrese el nick del Usuario a editar: ");
            String nick = Console.ReadLine();

            Console.Write("Ingrese el nombre: ");
            String nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            String apellido = Console.ReadLine();

            Console.Write("Ingrese el telefono: ");
            String tel = Console.ReadLine();

            Console.Write("Ingrese el e-mail: ");
            String mail = Console.ReadLine();

            Console.Write("Ingrese el login: ");
            String login = Console.ReadLine();

            Console.Write("Ingrese el password: ");
            String pwd = Console.ReadLine();

            String strAdm = "";
            do
            {
                Console.Write("Es administrador?(Si/No-S/N): ");
                strAdm = Console.ReadLine();
            } while (!Validator.ConsultaComando(strAdm));

            Boolean adm = false;

            if (strAdm.Equals("Si") || strAdm.Equals("S"))
            {
                adm = true;
            }

            if (ServiceBackend.editarUsuario(nombre, apellido, tel, mail, login, pwd, nick, adm))
            {
                Console.WriteLine("Usuario editado con exito");
            }
            else
            {
                Console.WriteLine("El Usuario no fue editado.");
            }

        }


        static void bajaUsuarioUI()
        {
            Console.Write("Ingrese el nick del Usuario a eliminar: ");
            String nick = Console.ReadLine();

            if(ServiceBackend.bajaUsuario(nick)){
                Console.WriteLine("El Usuario fue eliminado con exito");
            }else{
                Console.WriteLine("El Usuario no fue eliminado");
            }
        }


        static void consultaUsuarioUI(){

            Console.WriteLine("Id |    Nombre/Apellido   |   EMAIL   |    Login    |    Nick   |     Adm   |");

            //List<Usuario> listaUsuarios = ServiceBackend.consultaUsuario();


            //TODO Recorrer lista de usuarios en consulta y mostrarlos
            /*for (int i = 0; i < listaUsuarios.Count; i++ )
            {
                

            }*/


        }


        //***** PARTIDO *****

        static void altaPartidoUI(String action){

            String strIdent = "";
            do{
                if (action.Equals("new"))
                {
                    Console.Write("Ingrese el identificador: ");
                }
                else
                {
                    Console.Write("Ingrese el identificador a editar: ");
                }
                
                strIdent = Console.ReadLine();
            }while(!Validator.NumComando(strIdent));

            int identificador = Convert.ToInt32(strIdent);

            String strNum = "";
            Boolean flag = false;
            int numParticipantes = 0;
            do
            {
                Console.Write("Ingrese el número de participantes: ");
                strNum = Console.ReadLine();
                if(Validator.NumComando(strNum)){
                    int numVal = Convert.ToInt32(strNum);
                    if (numVal != 2 && numVal != 4)
                    {
                        Console.WriteLine("El número de participantes debe ser 2 ó 4");     
                    }
                    else
                    {
                        numParticipantes = numVal;
                        flag = true;
                    }

                }
            } while (!flag);

            if (action.Equals("new"))
            {
                if (ServiceBackend.altaPartido(identificador, numParticipantes))
                {
                    Console.WriteLine("El Partido fue ingresado con exito.");
                }
                else
                {
                    Console.WriteLine("El Partido no fue ingresado.");
                }
            }
            else
            {
                if (ServiceBackend.editarPartido(identificador, numParticipantes))
                {
                    Console.WriteLine("El Partido fue editado con exito.");
                }
                else
                {
                    Console.WriteLine("El Partido no fue editado.");
                }
            }
            

        }


        static void bajaPartidoUI()
        {
            String strIdent = "";
            do
            {
                Console.Write("Ingrese el identificador eliminar: ");

                strIdent = Console.ReadLine();
            } while (!Validator.NumComando(strIdent));

            int identificador = Convert.ToInt32(strIdent);

            if(ServiceBackend.bajaPartido(identificador)){
                Console.WriteLine("El Partido fue eliminado con exito.");
            }else{
                Console.WriteLine("El Partido no fue eliminado.");
            }

        }


        static void consultaPartidoUI()
        {
            //TODO realizar consultaPartido
        }


        //***** RANKING *****


        static void altaRankingUI(String action)
        {

            if (action.Equals("new"))
            {
                Console.Write("Ingrese el nick del jugador: ");
            }
            else
            {
                Console.Write("Ingrese el nick del jugador a editar: ");
            }

            String nick = Console.ReadLine();
            String puntaje = "";

            do
            {
                Console.Write("Ingrese el puntaje: ");
                puntaje = Console.ReadLine();
                
            } while (!Validator.NumComando(puntaje));

            if (action.Equals("new"))
            {
                if (ServiceBackend.altaRanking(nick, puntaje))
                {
                    Console.WriteLine("El Ranking fue ingresado con exito.");
                }
                else
                {
                    Console.WriteLine("El Ranking no fue ingresado.");
                }
            }
            else
            {
                if (ServiceBackend.editarRanking(nick, puntaje))
                {
                    Console.WriteLine("El Ranking fue editado con exito.");
                }
                else
                {
                    Console.WriteLine("El Ranking no fue editado.");
                }
            }
        }

        static void bajaRankingUI(){
            Console.Write("Ingrese el nick del jugador: ");
            String nick = Console.ReadLine();

            if (ServiceBackend.bajaRanking(nick))
            {
                Console.WriteLine("El Ranking fue eliminado con exito.");
            }
            else
            {
                Console.WriteLine("El Ranking no fue eliminado.");
            }

        }

        static void consultaRankingUI()
        {
            Console.WriteLine("Pos |    Jugador   |   Puntaje   |");

            //List<Ranking> listaRankings = ServiceBackend.consultaRanking();


            //TODO Recorrer lista de RANKING en consulta y mostrarlos
            /*for (int i = 0; i < listaRankings.Count; i++ )
            {
                

            }*/

        }


        //***** DENUNCIA *****

        static void altaDenunciaUI()
        {
            Console.Write("Ingrese la descripción de la denuncia: ");
            String descripcion = Console.ReadLine();

            if(ServiceBackend.altaDenuncia(descripcion)){
                Console.WriteLine("La Denuncia fue ingresada con exito.");
            }else{
                Console.WriteLine("La Denuncia no fue ingresada.");
            }
        }

        static void editarDenunciaUI()
        {

            String strCod = "";
            do
            {
                Console.Write("Ingrese el codigo de denuncia a editar: ");

                strCod = Console.ReadLine();
            } while (!Validator.NumComando(strCod));

            int codDenuncia = Convert.ToInt32(strCod);

            Console.Write("Ingrese la descripción de la denuncia: ");
            String descripcion = Console.ReadLine();

            if(ServiceBackend.editarDenuncia(codDenuncia,descripcion)){
                Console.WriteLine("La Denuncia fue editada con exito.");
            }else{
                Console.WriteLine("La Denuncia no fue editada.");
            }

        }


        static void bajaDenunciaUI()
        {
            String strCod = "";
            do
            {
                Console.Write("Ingrese el codigo de denuncia a eliminar: ");

                strCod = Console.ReadLine();
            } while (!Validator.NumComando(strCod));

            int codDenuncia = Convert.ToInt32(strCod);

            if(ServiceBackend.bajaDenuncia(codDenuncia)){
                Console.WriteLine("La Denuncia fue eliminda con exito.");
            }else{
                Console.WriteLine("La Denuncia no fue eliminda.");
            }
        }

        static void consultaDenunciaUI()
        {

            Console.WriteLine("Cod |    Descripción   |");

            //List<Denuncia> listaDenuncias = ServiceBackend.consultaDenuncia();


            //TODO Recorrer lista de denuncias en consulta y mostrarlos
            /*for (int i = 0; i < listaDenuncias.Count; i++ )
            {
                

            }*/


        }

        
    }
}

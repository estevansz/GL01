﻿namespace GL01
{
    internal class Program
    {
        static ConnStr datacom;
        static void Main(string[] options)
        {
            if (options.Length == 0)
            {
                Console.WriteLine(Help());
                return;
            }
            Console.WriteLine(datacom);

            if (options.Length == 1 && (options[0].StartsWith("-h")))
                Console.WriteLine(Help());
            if (options.Length == 1 && (options[0].StartsWith("-c")))
            {
                Config();
                Console.WriteLine(datacom.ToString().Replace("(","").Replace(")","").Replace(", ",";"));
            }

        }
        static string Help()
        {
            string r = "Opções:\n";
            r += "[-h] \tAjuda\n";
            r += "[-c] \tGera ou sobrescreve a configuração.\n";
            r += "[-q] \tCaminho SQL.\n";
            r += "[-n] \tNome do arquivo de resultado. (uso somente como extrator)\n";
            r += "[-j] \tCaminho Job.\n";
            r += "[-p] \tParâmetros Job. (String)\n\n";
            r += "Uso como extrator de dados:\n";
            r += "[integrador.exe -q:arquivo.sql]\tGera um arquivo data.json na pasta {InstallDir}\\Result\n";
            r += "[integrador.exe -q:arquivo.sql -n:nome]\tGera um arquivo [nome].json na pasta {InstallDir}\\Result\n";

            return r;
        }

        static void Config()
        {
            
            //"Server=rds07.cloudupsoftware.com,1647;
            //Database=UpSCVA_01079012;
            //User Id=01079012N;
            //Password=*NWubaxplMRvALEq^bhZ;"
            
        step1:
            Console.WriteLine("Configurar acesso ao Banco de Dados (passo 1 de 5)\n\n");
            Console.Write("Servidor: ");
            string? server = Console.ReadLine();
            if (string.IsNullOrEmpty(server))
            {
                Console.WriteLine("O Servidor não pode estar embranco.");
                goto step1;
            }
            else
            {
                datacom.Server = server;
            }
            Console.Clear();
        step2:
            Console.WriteLine("Configurar acesso ao Banco de Dados (passo 2 de 5)\n\n");
            Console.Write("Porta: ");
            string? port = Console.ReadLine();
            if (string.IsNullOrEmpty(port))
            {
                Console.WriteLine("Utilizando a porta padrão (1433)");
                port = "1433";
            }
            else
            {
                datacom.Port = port;
            }
            Console.Clear();
        step3:
            Console.WriteLine("Configurar acesso ao Banco de Dados (passo 3 de 5)\n\n");
            Console.Write("Base de Dados: ");
            string? database = Console.ReadLine();
            if (string.IsNullOrEmpty(database))
            {
                Console.WriteLine("A Base de Dados não pode estar embranco.");
                goto step2;
            }
            else
            {
                datacom.DB = database;
            }
            Console.Clear();
        step4:
            Console.WriteLine("Configurar acesso ao Banco de Dados (passo 4 de 5)\n\n");
            Console.Write("Usuário: ");
            string? userid = Console.ReadLine();
            if (string.IsNullOrEmpty(userid))
            {
                Console.WriteLine("O Nome do usuário não pode estar embranco.");
                goto step3;
            }
            else
            {
                datacom.User = userid;
            }
            Console.Clear();
        step5:
            Console.WriteLine("Configurar acesso ao Banco de Dados (passo 5 de 5)\n\n");
            Console.Write("Senha: ");
            string? password = Console.ReadLine();
            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("A senha não pode estar embranco.");
                goto step4;
            }
            else
            {
                datacom.Password = password;
            }
            Console.Clear();
        }
        
    }
}
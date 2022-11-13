using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChatML
{
    class Usuario
    {
        private static BigInteger id;
        private string nomeUsuario { get; set; }
        private string senhaUsuario { get; set; }

        public Usuario(string nomeUsuario, string senhaUsuario)
        {
            id += 1;
            BigInteger idDesteUsuario = id;
            this.nomeUsuario = nomeUsuario;
            this.senhaUsuario = senhaUsuario;
            Usuarios(idDesteUsuario, nomeUsuario, senhaUsuario);

        }

        private static List<string> Usuarios(BigInteger idDesteUsuario, string nomeDoUsuario, string senhaDoUsuario)
        {
            List<string> usuarios= new List<string>();
            string usuarioNovo = idDesteUsuario.ToString() + "-" + nomeDoUsuario + "," + senhaDoUsuario + ";";
            usuarios.Add(nomeDoUsuario);

            return usuarios;
        }
    }
}

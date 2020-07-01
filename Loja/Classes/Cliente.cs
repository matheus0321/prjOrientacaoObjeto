using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Classes
{
    public partial class Cliente
    {
        private Boolean _isNew;

        public Boolean IsNew
        {
            get { return _isNew; }
        }

        private Boolean _isModified;

        public Boolean IsModified
        {
            get { return _isModified; }
        }

        private int _codigo;

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (value < 0)
                {
                    throw new Loja.Excecoes.ValidacaoException("O codigo do cliente não pode ser negativo ");
                }
                _codigo = value;
                this._isModified = true;

                // ta aqui o erro, vc esqueceu de por o set fora
            }
        }

        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length <= 3)
                {
                    throw new Loja.Excecoes.ValidacaoException("O nome do cliente precisa no minimo 4 caracteres !! ");
                }
                _nome = value;
                this._isModified = true;
            }
        }

        private int _tipo;

        public int Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
                this._isModified = true;
            }
        }

        private DateTime _dataCadastro;

        public DateTime DataCadastro
        {
            get
            {
                return _dataCadastro;
            }
            set
            {
                _dataCadastro = value;
                this._isModified = true;
            }
        }

        public List<Contato> Contatos { get; set; }
    }
}
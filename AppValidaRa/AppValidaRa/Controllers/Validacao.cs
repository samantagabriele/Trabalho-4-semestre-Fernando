using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppValidaRa.Models;

namespace AppValidaRa.Control
{
    internal class Validacao
    {
        public string ValidarDados(string textoDigitado)
        {
            var model = new AlunoModel
            {
                Texto = textoDigitado.ToUpper()
            };

            if (model.EhRaValido(model.Texto))
                return $"RA Válido: {model.Texto}";
            else
                return $"RA Inválido: {model.Texto}";
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CCP.EjemploSenial.IOConsola
{
    public class ValidadorNumero : ValidadorConsola
    {

        public override void ConfigurarMensajeError()
        {
            base._mensajesError.Add("Patron", "Se ha ingresado un dato con formato incorrecto. Solo se requieren numeros");
            base._mensajesError.Add("Largo", "Se ha ingresado un dato con un largo mayor al esperado. Debe ser como máximo 6 caracteres");
            base._mensajesError.Add("NULL", "No se ha ingresado ningun dato");
        }

        public override string Validar(string entrada)
        {
  

            string _criterio = "NULL";
            if (entrada != null)
            {
                _criterio = "Patron";
                if (Regex.IsMatch(entrada, base.Patron))
                {
                    _criterio = "Largo";

                    if (entrada.Length <= base.Largo)
                    {
                        return "OK";
                    }
                }
            }

            return base._mensajesError[_criterio];

        }
    }
}

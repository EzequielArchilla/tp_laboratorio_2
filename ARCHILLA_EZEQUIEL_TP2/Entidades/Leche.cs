﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, String codigo, ConsoleColor color): base(codigo, marca, color)
        {
            this.tipo = ETipo.Entera;
        }

        public Leche(EMarca marca, String codigo, ConsoleColor color, ETipo tipo) : this(marca, codigo, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias{get{return 20;}}

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.Append("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine(" TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.Append("---------------------");

            return sb.ToString();
        }

        public enum ETipo
        {
            Entera,
            Descremada
        }
    }
}
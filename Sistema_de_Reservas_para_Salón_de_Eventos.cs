using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga_y_encapsulamiento_3
{
    public class Reserva
    {
        private string _nombreCliente;
        private int _cantidadInvitados;
        private int _cantidadHoras;
        private bool _incluyeMozos;
        private char _dia;
        private int _tipoReserva;
        private char _tipoMenu;
        private int _cantidadAnimaciones;

        private const int alquilerPorHora = 6000;
        private const int costoPorMozo = 3000;
        private const int cateringBasico = 5000;
        private const int cateringPremium = 11000;
        private const int costoPorAnimacion = 18000;

        public Reserva(string nombreCliente, int cantidadInvitados, int cantidadHoras,
               bool incluyeMozos, char dia, int tipoReserva,
               char tipoMenu, int cantidadAnimaciones)
        {
            NombreCliente = nombreCliente;
            CantidadInvitados = cantidadInvitados;
            CantidadHoras = cantidadHoras;
            IncluyeMozos = incluyeMozos;
            Dia = dia;
            TipoReserva = tipoReserva;
            TipoMenu = tipoMenu;
            CantidadAnimaciones = cantidadAnimaciones;
        }

        public string NombreCliente
        {
            get { return _nombreCliente; }
            set
            { 
                if (value != null)
                {
                    _nombreCliente = value;
                }
            }
        }
        public int CantidadInvitados
        {
            get { return _cantidadInvitados; }
            set
            {
                if (value >= 1)
                {
                    _cantidadInvitados = value;
                }
            }
        }
        public int CantidadHoras
        {
            get { return _cantidadHoras; }
            set
            {
                if (value >= 1)
                {
                    _cantidadHoras = value;
                }
            }
        }
        public bool IncluyeMozos
        {
            get { return _incluyeMozos; }
            set { _incluyeMozos = value; }
        }
        public char Dia
        {
            get { return _dia; }
            set {
                if (value == 'V' || value == 'S' || value == 'D')
                {
                    _dia = value;
                }
            }
        }
        public int TipoReserva
        {
            get { return _tipoReserva; }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    _tipoReserva = value;
                }
            }
        }
        public char TipoMenu
        {
            get { return _tipoMenu; }
            set
            {
                if (value == 'B' || value == 'P' || value == 'N')
                {
                    _tipoMenu = value;
                }
            }
        }
        public int CantidadAnimaciones
        {
            get { return _cantidadAnimaciones; }
            set
            {
                if (value >= 0)
                {
                    _cantidadAnimaciones = value;
                }
            }
        }

        public int CalcularValor()
        {
            int total = 0;
            total += _cantidadHoras * alquilerPorHora;
            int cantidadMozos = _cantidadInvitados / 15;
            if (_cantidadInvitados % 15 != 0)
            {
                cantidadMozos++;
            }
            if (_incluyeMozos)
            {
                total += cantidadMozos * costoPorMozo;
            }
            if (_dia == 'S')
            {
                total += total * 80 / 100;
            }
            else if (_dia == 'D')
            {
                total += total * 50 / 100;
            }
            if (_tipoReserva == 2 || _tipoReserva == 3)
            {
                if (_tipoMenu == 'B')
                {
                    total += _cantidadInvitados * cateringBasico;
                } else if (_tipoMenu == 'P')
                    {
                        total += _cantidadInvitados * cateringPremium;
                    }
            }
            if (_tipoReserva == 3)
            {
                total += _cantidadAnimaciones * costoPorAnimacion;
            }
            return total;
        }
        public string ObtenerResumen()
        {
            string resumen = "";

            resumen += _nombreCliente;
            resumen += " - Inv: " + _cantidadInvitados;
            resumen += " - Horas: " + _cantidadHoras;
            resumen += " - PRECIO $ " + CalcularValor();

            return resumen;
        }
    }
}
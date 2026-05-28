using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervareHotel
{
    public class Rezervare
    {
        private readonly int idRezervare;
        private string numeClient;
        private char tipCamera;
        private int durataSejur;
        private double sumaPlata;
        private string dataCazare;

        public Rezervare(int idRezervare, string numeClient, char tipCamera, int durataSejur, double sumaPlata, string dataCazare)
        {
            this.idRezervare = idRezervare;
            this.numeClient = numeClient;
            this.tipCamera = tipCamera;
            this.durataSejur = durataSejur;
            this.sumaPlata = sumaPlata;
            this.dataCazare = dataCazare;
        }

        public int IdRezervare => idRezervare;
        public string NumeClient { get => numeClient; set => numeClient = value; }
        public char TipCamera { get => tipCamera; set => tipCamera = value; }
        public int DurataSejur { get => durataSejur; set => durataSejur = value; }
        public double SumaPlata { get => sumaPlata; set => sumaPlata = value; }
        public string DataCazare { get => dataCazare; set => dataCazare = value; }

        public override string ToString()
        {
            return $"{idRezervare}|{numeClient}|{tipCamera}|{durataSejur}|{sumaPlata}|{dataCazare}";
        }
    }
}

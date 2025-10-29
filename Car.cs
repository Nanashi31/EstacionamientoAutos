using System;

namespace EstacionamientoAutos
{
    public class Car
    {
        public string Plate { get; set; }
        public string Owner { get; set; }
        public DateTime EntryTime { get; set; }

        public Car(string plate, string owner)
        {
            Plate = plate;
            Owner = owner;
            EntryTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Placa: {Plate}, Propietario: {Owner}, Hora de Entrada: {EntryTime}";
        }
    }
}

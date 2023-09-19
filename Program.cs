using DentalCare.Models;
using DentalCare.Data;
using System.Linq;
using static System.Console;

namespace DentalCare
{
    public class Program
    {


        static void Main(string[] args)
        {
            using var context = new DentalCareContext();
            AddPatient(context);
            ListPatients(context);
        }


        public static void AddPatient(DentalCareContext context)
        {
            WriteLine("\n\n========Lägg till en ny patient=================== ");

            Write("\nPersonnumer: ");
            var personnummer = ReadLine();

            Write("\nFörnamn: ");
            var firstName = ReadLine();

            Write("\nEfternamn: ");
            var lastName = ReadLine();

            Write("\nTelefonnummer: ");
            var phoneNumber = ReadLine();

            Write("\nE-post");
            var email = ReadLine();

            var newPatient = new Patient
            {
                Personnummer = personnummer,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email
            };

            context.Patients.Add(newPatient);
            context.SaveChanges();

            Console.WriteLine("Patient tillagd!");
        }

        public static void ListPatients(DentalCareContext context)
        {
            WriteLine("\n\n========Lista över alla patienter===================");

            var patients = context.Patients.ToList();

            foreach (var patient in patients)
            {
                WriteLine($"ID: {patient.Id}");
                WriteLine($"Personnummer: {patient.Personnummer}");
                WriteLine($"Förnamn: {patient.FirstName}");
                WriteLine($"Efternamn: {patient.LastName}");
                WriteLine($"Telefonnummer {patient.PhoneNumber}");
                WriteLine($"E-post: {patient.Email}");
                WriteLine($"____________________________________________________________");

            }

        }

    }
}



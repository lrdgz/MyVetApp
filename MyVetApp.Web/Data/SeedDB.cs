using MyVetApp.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyVetApp.Web.Data{
    public class SeedDB{

        private readonly DataContext _context;

        public SeedDB(DataContext context){
            this._context = context;
        }

        public async Task SeedAsync() {
            await _context.Database.EnsureCreatedAsync();
            await CheckPetTypesAsync();
            await CheckServiceTypesAsync();
            await CheckOwnersAsync();
            await CheckPetsAsync();
            await CheckAgendasAsync();
        }

        public async Task CheckPetsAsync()
        {

            var owner = _context.Owners.FirstOrDefault();
            var petType = _context.PetTypes.FirstOrDefault();

            if (!_context.Pets.Any())
            {
                AddPet("Otto", owner, petType, "Shih tzu");
                AddPet("Killer", owner, petType, "Doberman");
                await _context.SaveChangesAsync();
            }
        }


        public async Task CheckOwnersAsync()
        {

            if (!_context.Owners.Any())
            {
                AddOwner("789456123", "Luis", "Rodriguez", "123 456", "310 12245 1444", "Calle Luna");
                AddOwner("123134555", "Jose", "Rodriguez", "123 456", "310 12245 1444", "Calle Luna");
                AddOwner("789456124", "Ramon", "Rodriguez", "123 456", "310 12245 1444", "Calle Luna");
                AddOwner("789456125", "Rafael", "Rodriguez", "123 456", "310 12245 1444", "Calle Luna");
                AddOwner("789456126", "Luffy", "Rodriguez", "123 456", "310 12245 1444", "Calle Luna");
                AddOwner("789456124", "Zorro", "Rodriguez", "123 456", "310 12245 1444", "Calle Luna");
                AddOwner("789456128", "Chopper", "Rodriguez", "123 456", "310 12245 1444", "Calle Luna");
                await _context.SaveChangesAsync();
            }
        }
        

        public async Task CheckPetTypesAsync(){
            if (!_context.PetTypes.Any()){
                _context.PetTypes.Add( new Entities.PetType { Name= "Dog" } );
                _context.PetTypes.Add( new Entities.PetType { Name= "Cat" } );
                _context.PetTypes.Add( new Entities.PetType { Name= "Turtle" } );
                await _context.SaveChangesAsync();
            }
        }

        public async Task CheckServiceTypesAsync(){
            if (!_context.ServiceTypes.Any()){
                _context.ServiceTypes.Add(new ServiceType { Name = "Consulta" });
                _context.ServiceTypes.Add(new ServiceType { Name = "Urgencia" });
                _context.ServiceTypes.Add(new ServiceType { Name = "Vacunación" });
                await _context.SaveChangesAsync();
            }
        }

        private void AddPet(string name, Owner owner, PetType petType, string race)
        {
            _context.Pets.Add(new Pet
            {
                Born = DateTime.Now.AddYears(-2),
                Name = name,
                Owner = owner,
                PetType = petType,
                Race = race
            });
        }

        private async Task CheckAgendasAsync()
        {
            if (!_context.Agendas.Any())
            {
                var initialDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
                var finalDate = initialDate.AddYears(1);
                while (initialDate < finalDate){
                    if (initialDate.DayOfWeek != DayOfWeek.Sunday) {
                        var finalDate2 = initialDate.AddHours(10);
                        while (initialDate < finalDate2){
                            _context.Agendas.Add(new Agenda
                            {
                                Date = initialDate.ToUniversalTime(),
                                IsAvailable = true
                            });

                            initialDate = initialDate.AddMinutes(30);
                        }

                        initialDate = initialDate.AddHours(14);
                    } else {
                        initialDate = initialDate.AddDays(1);
                    }
                }
            }

            await _context.SaveChangesAsync();
        }



        private void AddOwner(string document, string firstName, string lastName, string fixedPhone, string cellPhone, string address) {
            _context.Owners.Add(new Owner
            {
                Address = address,
                CellPhone = cellPhone,
                Document = document,
                FirstName = firstName,
                FixedPhone = fixedPhone,
                LastName = lastName
            });
        }

    }
}

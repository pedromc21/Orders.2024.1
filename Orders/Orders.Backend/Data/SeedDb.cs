using Orders.Shared.Entities;

namespace Orders.Backend.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCatregoriesAsync();
        }

        private async Task CheckCatregoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Apple" });
                _context.Categories.Add(new Category { Name = "Autos" });
                _context.Categories.Add(new Category { Name = "Belleza" });
                _context.Categories.Add(new Category { Name = "Calzado" });
                _context.Categories.Add(new Category { Name = "Comida" });
                _context.Categories.Add(new Category { Name = "Cosmeticos" });
                _context.Categories.Add(new Category { Name = "Deportes" });
                _context.Categories.Add(new Category { Name = "Erótica" });
                _context.Categories.Add(new Category { Name = "Ferreteria" });
                _context.Categories.Add(new Category { Name = "Gamer" });
                _context.Categories.Add(new Category { Name = "Hogar" });
                _context.Categories.Add(new Category { Name = "Jardín" });
                _context.Categories.Add(new Category { Name = "Jugetes" });
                _context.Categories.Add(new Category { Name = "Lenceria" });
                _context.Categories.Add(new Category { Name = "Mascotas" });
                _context.Categories.Add(new Category { Name = "Nutrición" });
                _context.Categories.Add(new Category { Name = "Ropa" });
                _context.Categories.Add(new Category { Name = "Tecnología" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _ = _context.Countries.Add(new Country
                {
                    Name = "Afganistán"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Albania"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Alemania"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Andorra"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Angola"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Antigua y Barbuda"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Arabia Saudita"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Argelia"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Argentina"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Armenia"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Australia"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Austria"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Azerbaiyán"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bahamas"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bangladés"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Barbados"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Baréin"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bélgica"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Belice"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Benín"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bielorrusia"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Birmania"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bolivia"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bosnia y Herzegovina"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Botsuana"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Brasil"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Brunéi"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bulgaria"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Burkina Faso"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Burundi"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Bután"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Cabo Verde"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Camboya"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Camerún"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Canadá"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Catar"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Chad"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Chile"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "China"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Chipre"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Ciudad del Vaticano"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    States =
                    [
                        new State()
                        {
                            Name = "Antioquia",
                            Cities = [
                                new() { Name = "Medellín" },
                                new() { Name = "Itagüí" },
                                new() { Name = "Envigado" },
                                new() { Name = "Bello" },
                                new() { Name = "Rionegro" },
                                new() { Name = "Marinilla" },
                            ]
                        },
                        new State()
                        {
                            Name = "Bogotá",
                            Cities = [
                                new() { Name = "Usaquen" },
                                new() { Name = "Champinero" },
                                new() { Name = "Santa fe" },
                                new() { Name = "Useme" },
                                new() { Name = "Bosa" },
                            ]
                        },
                    ]
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Comoras"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Corea del Norte"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Corea del Sur"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Costa de Marfil"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Costa Rica"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Croacia"
                });
                _ = _context.Countries.Add(new Country
                {
                    Name = "Cuba"
                });
                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States =
                    [
                        new State()
                        {
                            Name = "Florida",
                            Cities = [
                                new() { Name = "Orlando" },
                                new() { Name = "Miami" },
                                new() { Name = "Tampa" },
                                new() { Name = "Fort Lauderdale" },
                                new() { Name = "Key West" },
                            ]
                        },
                        new State()
                        {
                            Name = "Texas",
                            Cities = [
                                new() { Name = "Houston" },
                                new() { Name = "San Antonio" },
                                new() { Name = "Dallas" },
                                new() { Name = "Austin" },
                                new() { Name = "El Paso" },
                            ]
                        },
                    ]
                });
                _context.Countries.Add(new Country
                {
                    Name = "México",
                    States =
                    [
                        new State()
                        {
                            Name = "Aguascalientes",
                            Cities = [
                                new() { Name = "Aguascalientes" },
                                new() { Name = "Jesús María" },
                                new() { Name = "Pabellón de Arteaga" },
                                new() { Name = "Rincón de Romos" },
                                new() { Name = "Calvillo" },
                            ]
                        },
                        new State()
                        {
                            Name = "Baja California",
                            Cities = [
                                new() { Name = "Tijuana" },
                                new() { Name = "Mexicali" },
                                new() { Name = "Ensenada" },
                                new() { Name = "Playas de Rosarito" },
                                new() { Name = "Tecate" },
                            ]
                        },
                        new State()
                        {
                            Name = "Baja California Sur",
                            Cities = [
                                new() { Name = "La paz" },
                            ]
                        },

new State()
{
    Name = "Campeche",
                            Cities = [
                                new() { Name = "Campeche" },
                                    ]
},
new State()
{
    Name = "Chiapas",
                            Cities = [
                                new() { Name = "Chiapas" },
                                    ]
},
new State()
{
    Name = "Chihuahua",
                            Cities = [
                                new() { Name = "Chihuahua" },
                                    ]
},
new State()
{
    Name = "Ciudad de México",
                            Cities = [
                                new() { Name = "Ciudad de México" },
                                    ]
},
new State()
{
    Name = "Coahuila",
                            Cities = [
                                new() { Name = "Coahuila" },
                                    ]
},
new State()
{
    Name = "Colima",
                            Cities = [
                                new() { Name = "Colima" },
                                    ]
},
new State()
{
    Name = "Durango",
                            Cities = [
                                new() { Name = "Durango" },
                                    ]
},
new State()
{
    Name = "Estado de México",
                            Cities = [
                                new() { Name = "Estado de México" },
                                    ]
},
new State()
{
    Name = "Guanajuato",
                            Cities = [
                                new() { Name = "Guanajuato" },
                                    ]
},
new State()
{
    Name = "Guerrero",
                            Cities = [
                                new() { Name = "Guerrero" },
                                    ]
},
new State()
{
    Name = "Hidalgo",
                            Cities = [
                                new() { Name = "Hidalgo" },
                                    ]
},
new State()
{
    Name = "Jalisco",
                            Cities = [
                                new() { Name = "Jalisco" },
                                    ]
},
new State()
{
    Name = "Michoacán",
                            Cities = [
                                new() { Name = "Michoacán" },
                                    ]
},
new State()
{
    Name = "Morelos",
                            Cities = [
                                new() { Name = "Morelos" },
                                    ]
},
new State()
{
    Name = "Nayarit",
                            Cities = [
                                new() { Name = "Nayarit" },
                                    ]
},
new State()
{
    Name = "Nuevo León",
                            Cities = [
                                new() { Name = "Nuevo León" },
                                    ]
},
new State()
{
    Name = "Oaxaca",
                            Cities = [
                                new() { Name = "Oaxaca" },
                                    ]
},
new State()
{
    Name = "Puebla",
                            Cities = [
                                new() { Name = "Puebla" },
                                    ]
},
new State()
{
    Name = "Querétaro",
                            Cities = [
                                new() { Name = "Querétaro" },
                                    ]
},
new State()
{
    Name = "Quintana Roo",
                            Cities = [
                                new() { Name = "Quintana Roo" },
                                    ]
},
new State()
{
    Name = "San Luis Potosí",
                            Cities = [
                                new() { Name = "San Luis Potosí" },
                                    ]
},
new State()
{
    Name = "Sinaloa",
                            Cities = [
                                new() { Name = "Sinaloa" },
                                    ]
},
new State()
{
    Name = "Sonora",
                            Cities = [
                                new() { Name = "Sonora" },
                                    ]
},
new State()
{
    Name = "Tabasco",
                            Cities = [
                                new() { Name = "Tabasco" },
                                    ]
},
new State()
{
    Name = "Tamaulipas",
                            Cities = [
                                new() { Name = "Tamaulipas" },
                                    ]
},
new State()
{
    Name = "Tlaxcala",
                            Cities = [
                                new() { Name = "Tlaxcala" },
                                    ]
},
new State()
{
    Name = "Veracruz",
                            Cities = [
                                new() { Name = "Veracruz" },
                                    ]
},
new State()
{
    Name = "Yucatán",
                            Cities = [
                                new() { Name = "Yucatán" },
                                    ]
},
new State()
{
    Name = "Zacatecas",
                            Cities = [
                                new() { Name = "Zacatecas" },
                                    ]
},
                    ]
                });
            }
            await _context.SaveChangesAsync();
        }
    }
}
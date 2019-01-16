using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CharacterList
    {
        public CharacterList()
        {

        }

        public static List<Character> getCharacters()
        {
            return new List<Character>
            {
                new Character
                {
                    IdCharacter = 1,
                    Name = "Bart Cassidy",
                    MaxLife = 8,
                    Hability = "Puedes coger una flecha en lugar de perder puntos de vida(excepto en caso de indios o dinamita)."
                },
                new Character
                {
                    IdCharacter = 2,
                    Name = "Black Jack",
                    MaxLife = 8,
                    Hability = "Puedes volver a lanzar la dinamita (¡Pero no si sacas tres o más!)."
                },
                new Character
                {
                    IdCharacter = 3,
                    Name = "Calamity Janet",
                    MaxLife = 8,
                    Hability = "Puedes user [1] como [2] y viceversa."
                },
                new Character
                {
                    IdCharacter = 4,
                    Name = "El Gringo",
                    MaxLife = 7,
                    Hability = "Cuando un jugador te haga perder uno o más puntos de vida, debe coger una flecha."
                },
                new Character
                {
                    IdCharacter = 5,
                    Name = "Jesse Jones",
                    MaxLife = 9,
                    Hability = "Si tienes cuatro puntos de vida o menos, obtienes dos si usas [cerveza] contigo mismo."
                },
                new Character
                {
                    IdCharacter = 6,
                    Name = "Jourdonnais",
                    MaxLife = 7,
                    Hability = "Nunca pierdes más de un punto de vida por los indios."
                },
                new Character
                {
                    // Falta completar
                    IdCharacter = 7,
                    Name = "Kir Carlson",
                    MaxLife = 7,
                    Hability = "Puedes descargar una flecha de cualquier jugador por cada [ametralladora]."
                },
                new Character
                {
                    IdCharacter = 8,
                    Name = "Lucky Duke",
                    MaxLife = 8,
                    Hability = "Puede repetir la tirada una vez adicional. Puedes lanzar los dados un total de 4 veces en tu turno."
                },
                new Character
                {
                    IdCharacter = 9,
                    Name = "Paul Regret",
                    MaxLife = 9,
                    Hability = "Nunca pierdes puntos de vida por la ametralladora Gatling."
                },
                new Character
                {
                    IdCharacter = 10,
                    Name = "Pedro Ramírez",
                    MaxLife = 8,
                    Hability = "Cada vez que pierdes un punto de vida, puedes descargar una de tus flechas. Al usar esta capacidad, sigues perdiendo el punto de vida."
                },
                new Character
                {
                    IdCharacter = 11,
                    Name = "Rose Doolan",
                    MaxLife = 9,
                    Hability = "Puedes usar [1] o [2] con jugadores que esten un puesto más allá."
                },
                new Character
                {
                    IdCharacter = 12,
                    Name = "Sid Ketchum",
                    MaxLife = 8,
                    Hability = "Al comienzo de tu turno, cualquier jugador de tu elección obtiene un punto de vida. También puedes elegirte a tí mismo."
                },
                new Character
                {
                    IdCharacter = 13,
                    Name = "Slab 'El Asesino'",
                    MaxLife = 8,
                    Hability = "Una vez por turno, puedes usar una [cerveza] para doblar un [1] o un [2]."
                },
                new Character
                {
                    // Falta completar
                    IdCharacter = 14,
                    Name = "Suzy Lafayette",
                    MaxLife = 8,
                    Hability = "Si no sacaste ningún [1] o [2], obtienes dos puntos de vida."
                },
                new Character
                {
                    IdCharacter = 15,
                    // Falta completar
                    Name = "Buitre 'Sam'",
                    MaxLife = 9,
                    Hability = "Cada vez que otro jugador es eliiminado, obtienes dos puntos de vida."
                },
                new Character
                {
                    // Falta completar
                    IdCharacter = 16,
                    Name = "Willy 'el Niño'",
                    MaxLife = 8,
                    Hability = "Solo necesitas [ametralladora][ametralladora] para usar la ametralladora Gatling."
                }
            };
        }
    }
}

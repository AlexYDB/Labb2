using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class MovieList
    {



        public string FilmLista()
        {
            List<string> Movies;
            Movies = new List<string>();

            Movies.Add("1. Shawshank Redemption\nIMDB rating: 9.2");
            Movies.Add("2. The Godfather\nIMDB rating: 9.2");
            Movies.Add("3. The Godfather 2\nIMDB rating: 9.0");
            Movies.Add("4. The Dark Knight\nIMDB rating: 9.0");
            Movies.Add("5. 12 Angry Men\nIMDB rating: 8.9");
            Movies.Add("6. Schindler's List\nIMDB rating: 8.9");
            Movies.Add("7. Pulp Fiction\nIMDB rating: 8.9");
            Movies.Add("8. The Lord of the Rings: The Return of the King\nIMDB rating: 8.9");
            Movies.Add("9. The Good, the Bad and the Ugly\nIMDB rating: 8.8");
            Movies.Add("10. Fight Club\nIMDB rating: 8.8");
            Movies.Add("11. The Lord of the Rings: The Fellowship of the Ring\nIMDB rating: 8.8");
            Movies.Add("12. Forrest Gump\nIMDB rating 8.7");
            Movies.Add("13. Star Wars: Episode V - The Empire Strikes Back\nIMDB rating: 8.7");
            Movies.Add("14. Inception\nIMDB rating: 8.7");
            Movies.Add("15. The Lord of the Rings: The Two Towers\nIMDB rating: 8.7");
            Movies.Add("16. One Flew Over the Cuckoo's Nest\nIMDB rating: 8.7");
            Movies.Add("17. Goodfellas\nIMDB rating: 8.7");
            Movies.Add("18. The Matrix\nIMDB rating: 8.7");
            Movies.Add("19. Seven Samurai\nIMDB rating: 8.6");
            Movies.Add("20. Star Wars: Episode IV - A New Hope\nIMDB rating: 8.6");
            Movies.Add("21. City of God\nIMDB rating: 8.6");
            Movies.Add("22. Se7en\nIMDB rating: 8.6");
            Movies.Add("23. The Silence of the Lambs\nIMDB rating: 8.6");
            Movies.Add("24. It's a Wonderful Life\nIMDB rating: 8.6");
            Movies.Add("25. Life Is Beautiful\nIMDB rating: 8.6");
            Movies.Add("26. The Usual Suspects\nIMDB rating: 8.6");
            Movies.Add("27. Léon: The Professional\nIMDB rating: 8.5");
            Movies.Add("28. Saving Private Ryan\nIMDB rating: 8.5");
            Movies.Add("29. Spirited Away\nIMDB rating: 8.5");
            Movies.Add("30. American History X\nIMDB rating: 8.5");
            Movies.Add("31. Once Upon a Time in the West\nIMDB rating: 8.5");
            Movies.Add("32. Interstellar\nIMDB rating: 8.5");
            Movies.Add("33. Psycho\nIMDB rating: 8.5");
            Movies.Add("34. The Green Mile\nIMDB rating: 8.5");
            Movies.Add("35. City Lights\nIMDB rating: 8.5");
            Movies.Add("36. Casablanca\nIMDB rating: 8.5");
            Movies.Add("37. The Intouchables\nIMDB rating: 8.5");
            Movies.Add("38. Modern Times\nIMDB rating: 8.5");
            Movies.Add("39. Raiders of the Lost Ark\nIMDB rating: 8.5");
            Movies.Add("40. The Pianist\nIMDB rating: 8.5");
            Movies.Add("41. The Departed\nIMDB rating: 8.5");
            Movies.Add("42. Rear Window\nIMDB rating: 8.5");
            Movies.Add("43. Terminator 2: Judgment Day\nIMDB rating: 8.5");
            Movies.Add("44. Back to the Future\nIMDB rating: 8.5");
            Movies.Add("45. Whiplash\nIMDB rating: 8.5");
            Movies.Add("46. Gladiator\nIMDB rating: 8.5");
            Movies.Add("47. The Prestige\nIMDB rating: 8.5");
            Movies.Add("48. The Lion King\nIMDB rating: 8.5");
            Movies.Add("49. Memento\nIMDB rating: 8.5");
            Movies.Add("50. Apocalypse Now\nIMDB rating: 8.5");
            Movies.Add("51. Alien\nIMDB rating: 8.4");
            Movies.Add("52. The Great Dictator\nIMDB rating: 8.4");
            Movies.Add("53. Sunset Boulevard\nIMDB rating: 8.4");
            Movies.Add("54. Dr. Strangelove or: How I Learned To Stop Worrying and Love the Bomb\nIMDB rating: 8.4");
            Movies.Add("55. Cinema Paradiso\nIMDB rating: 8.4");
            Movies.Add("56. The Lives of Others\nIMDB rating: 8.4");
            Movies.Add("57. Grave of the Fireflies\nIMDB rating: 8.4");
            Movies.Add("58. Paths of Glory\nIMDB rating: 8.4");
            Movies.Add("59. Django Unchained\nIMDB rating: 8.4");
            Movies.Add("60. The Shining\nIMDB rating: 8.4");
            Movies.Add("61. WALL-E\nIMDB rating: 8.4");
            Movies.Add("62. American Beauty\nIMDB rating: 8.4");
            Movies.Add("63. The Dark Knight Rises\nIMDB rating: 8.4");
            Movies.Add("64. Princess Mononoke\nIMDB rating: 8.4");
            Movies.Add("65. Aliens\nIMDB rating: 8.4");
            Movies.Add("66. Oldeuboi\nIMDB rating: 8.4");
            Movies.Add("67. Witness for the Prosecution\nIMDB rating: 8.4");
            Movies.Add("68. Once Upon a Time in America\nIMDB rating: 8.4");
            Movies.Add("69. Das Boot\nIMDB rating: 8.3");
            Movies.Add("70. Citizen Kane\nIMDB rating: 8.3");
            Movies.Add("71. Dangal\nIMDB rating: 8.3");
            Movies.Add("72. Vertigo\nIMDB rating: 8.3");
            Movies.Add("73. North by Northwest\nIMDB rating: 8.3");
            Movies.Add("74. Star Wars: Episode VI - Return of the Jedi\nIMDB rating: 8.3");
            Movies.Add("75. Braveheart\nIMDB rating: 8.3");
            Movies.Add("76. Reservoir Dogs\nIMDB rating: 8.3");
            Movies.Add("77. M\nIMDB rating: 8.3");
            Movies.Add("78. Requiem for a Dream\nIMDB rating: 8.3");
            Movies.Add("79. Amélie\nIMDB rating: 8.3");
            Movies.Add("80. Like Stars on Earth\nIMDB rating: 8.3");
            Movies.Add("81. A Clockwork Orange\nIMDB rating: 8.3");
            Movies.Add("82. Dunkirk\nIMDB rating: 8.3");
            Movies.Add("83. Your Name\nIMDB rating: 8.3");
            Movies.Add("84. Lawrence of Arabia\nIMDB rating: 8.3");
            Movies.Add("85. Double Indemnity\nIMDB rating: 8.3");
            Movies.Add("86. Amadeus\nIMDB rating: 8.3");
            Movies.Add("87. Taxi Driver\nIMDB rating: 8.3");
            Movies.Add("88. Eternal Sunshine of the Spotless Mind\nIMDB rating: 8.3");
            Movies.Add("89. To Kill a Mockingbird\nIMDB rating: 8.3");
            Movies.Add("90. Full Metal Jacket\nIMDB rating: 8.3");
            Movies.Add("91. 2001: A Space Odyssey\nIMDB rating: 8.3");
            Movies.Add("92. Singin' in the Rain\nIMDB rating: 8.3");
            Movies.Add("93. Toy Story 3\nIMDB rating: 8.3");
            Movies.Add("94. Sthe Sting\nIMDB rating: 8.3");
            Movies.Add("95. Toy Story\nIMDB rating: 8.3");
            Movies.Add("96. 3 Idiots\nIMDB rating: 8.3");
            Movies.Add("97. Bicycle Thieves\nIMDB rating: 8.3");
            Movies.Add("98. Inglourious Basterds\nIMDB rating: 8.3");
            Movies.Add("99. The Kid\nIMDB rating: 8.3");
            Movies.Add("100. Snatch\nIMDB rating: 8.3");




            Random rnd = new Random();
            int rndd = rnd.Next(Movies.Count);

            string rnddd = Movies[rndd];

            return (rnddd);

        }
    }
}

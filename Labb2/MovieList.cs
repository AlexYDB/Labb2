using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class MovieList
    {
        List<Movie> movies;
       




        public MovieList()
        {
            movies = new List<Movie>();

            movies.Add(new Movie("1. Shawshank Redemption\nIMDB rating: ", 9.2));
            movies.Add(new Movie("2. The Godfather\nIMDB rating: ", 9.2));
            movies.Add(new Movie("3. The Godfather 2\nIMDB rating: ", 9.0));
            movies.Add(new Movie("4. The Dark Knight\nIMDB rating: ", 9.0));
            movies.Add(new Movie("5. 12 Angry Men\nIMDB rating: ", 8.9));
            movies.Add(new Movie("6. Schindler's List\nIMDB rating: ", 8.9));
            movies.Add(new Movie("7. Pulp Fiction\nIMDB rating: ", 8.9));
            movies.Add(new Movie("8. The Lord of the Rings: The Return of the King\nIMDB rating: ", 8.9));
            movies.Add(new Movie("9. The Good, the Bad and the Ugly\nIMDB rating: ", 8.8));
            movies.Add(new Movie("10. Fight Club\nIMDB rating: ", 8.8));
            movies.Add(new Movie("11. The Lord of the Rings: The Fellowship of the Ring\nIMDB rating: ", 8.8));
            movies.Add(new Movie("12. Forrest Gump\nIMDB rating: ", 8.7));
            movies.Add(new Movie("13. Star Wars: Episode V - The Empire Strikes Back\nIMDB rating: ", 8.7));
            movies.Add(new Movie("14. Inception\nIMDB rating: ", 8.7));
            movies.Add(new Movie("15. The Lord of the Rings: The Two Towers\nIMDB rating: ", 8.7));
            movies.Add(new Movie("16. One Flew Over the Cuckoo's Nest\nIMDB rating: ", 8.7));
            movies.Add(new Movie("17. Goodfellas\nIMDB rating: ", 8.7));
            movies.Add(new Movie("18. The Matrix\nIMDB rating: ", 8.7));
            movies.Add(new Movie("19. Seven Samurai\nIMDB rating: ", 8.6));
            movies.Add(new Movie("20. Star Wars: Episode IV - A New Hope\nIMDB rating: ", 8.6));
            movies.Add(new Movie("21. City of God\nIMDB rating: ", 8.6));
            movies.Add(new Movie("22. Se7en\nIMDB rating: ", 8.6));
            movies.Add(new Movie("23. The Silence of the Lambs\nIMDB rating: ", 8.6));
            movies.Add(new Movie("24. It's a Wonderful Life\nIMDB rating: ", 8.6));
            movies.Add(new Movie("25. Life Is Beautiful\nIMDB rating: ", 8.6));
            movies.Add(new Movie("26. The Usual Suspects\nIMDB rating: ", 8.6));
            movies.Add(new Movie("27. Léon: The Professional\nIMDB rating: ", 8.5));
            movies.Add(new Movie("28. Saving Private Ryan\nIMDB rating: ", 8.5));
            movies.Add(new Movie("29. Spirited Away\nIMDB rating: ", 8.5));
            movies.Add(new Movie("30. American History X\nIMDB rating: ", 8.5));
            movies.Add(new Movie("31. Once Upon a Time in the West\nIMDB rating: ", 8.5));
            movies.Add(new Movie("32. Interstellar\nIMDB rating: ", 8.5));
            movies.Add(new Movie("33. Psycho\nIMDB rating: ", 8.5));
            movies.Add(new Movie("34. The Green Mile\nIMDB rating: ", 8.5));
            movies.Add(new Movie("35. City Lights\nIMDB rating: ", 8.5));
            movies.Add(new Movie("36. Casablanca\nIMDB rating: ", 8.5));
            movies.Add(new Movie("37. The Intouchables\nIMDB rating: ", 8.5));
            movies.Add(new Movie("38. Modern Times\nIMDB rating: ", 8.5));
            movies.Add(new Movie("39. Raiders of the Lost Ark\nIMDB rating: ", 8.5));
            movies.Add(new Movie("40. The Pianist\nIMDB rating: ", 8.5));
            movies.Add(new Movie("41. The Departed\nIMDB rating: ", 8.5));
            movies.Add(new Movie("42. Rear Window\nIMDB rating: ", 8.5));
            movies.Add(new Movie("43. Terminator 2: Judgment Day\nIMDB rating: ", 8.5));
            movies.Add(new Movie("44. Back to the Future\nIMDB rating: ", 8.5));
            movies.Add(new Movie("45. Whiplash\nIMDB rating: ", 8.5));
            movies.Add(new Movie("46. Gladiator\nIMDB rating: ", 8.5));
            movies.Add(new Movie("47. The Prestige\nIMDB rating: ", 8.5));
            movies.Add(new Movie("48. The Lion King\nIMDB rating: ", 8.5));
            movies.Add(new Movie("49. Memento\nIMDB rating: ", 8.5));
            movies.Add(new Movie("50. Apocalypse Now\nIMDB rating: ", 8.5));
            movies.Add(new Movie("51. Alien\nIMDB rating: ", 8.4));
            movies.Add(new Movie("52. The Great Dictator\nIMDB rating: ", 8.4));
            movies.Add(new Movie("53. Sunset Boulevard\nIMDB rating: ", 8.4));
            movies.Add(new Movie("54. Dr. Strangelove or: How I Learned To Stop Worrying and Love the Bomb\nIMDB rating: ", 8.4));
            movies.Add(new Movie("55. Cinema Paradiso\nIMDB rating: ", 8.4));
            movies.Add(new Movie("56. The Lives of Others\nIMDB rating: ", 8.4));
            movies.Add(new Movie("57. Grave of the Fireflies\nIMDB rating: ", 8.4));
            movies.Add(new Movie("58. Paths of Glory\nIMDB rating: ", 8.4));
            movies.Add(new Movie("59. Django Unchained\nIMDB rating: ", 8.4));
            movies.Add(new Movie("60. The Shining\nIMDB rating: ", 8.4));
            movies.Add(new Movie("61. WALL-E\nIMDB rating: ", 8.4));
            movies.Add(new Movie("62. American Beauty\nIMDB rating: ", 8.4));
            movies.Add(new Movie("63. The Dark Knight Rises\nIMDB rating: ", 8.4));
            movies.Add(new Movie("64. Princess Mononoke\nIMDB rating: ", 8.4));
            movies.Add(new Movie("65. Aliens\nIMDB rating: ", 8.4));
            movies.Add(new Movie("66. Oldeuboi\nIMDB rating: ", 8.4));
            movies.Add(new Movie("67. Witness for the Prosecution\nIMDB rating: ", 8.4));
            movies.Add(new Movie("68. Once Upon a Time in America\nIMDB rating: ", 8.4));
            movies.Add(new Movie("69. Das Boot\nIMDB rating: ", 8.3));
            movies.Add(new Movie("70. Citizen Kane\nIMDB rating: ", 8.3));
            movies.Add(new Movie("71. Dangal\nIMDB rating: ", 8.3));
            movies.Add(new Movie("72. Vertigo\nIMDB rating: ", 8.3));
            movies.Add(new Movie("73. North by Northwest\nIMDB rating: ", 8.3));
            movies.Add(new Movie("74. Star Wars: Episode VI - Return of the Jedi\nIMDB rating: ", 8.3));
            movies.Add(new Movie("75. Braveheart\nIMDB rating: ", 8.3));
            movies.Add(new Movie("76. Reservoir Dogs\nIMDB rating: ", 8.3));
            movies.Add(new Movie("77. M\nIMDB rating: ", 8.3));
            movies.Add(new Movie("78. Requiem for a Dream\nIMDB rating: ", 8.3));
            movies.Add(new Movie("79. Amélie\nIMDB rating: ", 8.3));
            movies.Add(new Movie("80. Like Stars on Earth\nIMDB rating: ", 8.3));
            movies.Add(new Movie("81. A Clockwork Orange\nIMDB rating: ", 8.3));
            movies.Add(new Movie("82. Dunkirk\nIMDB rating: ", 8.3));
            movies.Add(new Movie("83. Your Name\nIMDB rating: ", 8.3));
            movies.Add(new Movie("84. Lawrence of Arabia\nIMDB rating: ", 8.3));
            movies.Add(new Movie("85. Double Indemnity\nIMDB rating: ", 8.3));
            movies.Add(new Movie("86. Amadeus\nIMDB rating: ", 8.3));
            movies.Add(new Movie("87. Taxi Driver\nIMDB rating: ", 8.3));
            movies.Add(new Movie("88. Eternal Sunshine of the Spotless Mind\nIMDB rating: ", 8.3));
            movies.Add(new Movie("89. To Kill a Mockingbird\nIMDB rating: ", 8.3));
            movies.Add(new Movie("90. Full Metal Jacket\nIMDB rating: ", 8.3));
            movies.Add(new Movie("91. 2001: A Space Odyssey\nIMDB rating: ", 8.3));
            movies.Add(new Movie("92. Singin' in the Rain\nIMDB rating: ", 8.3));
            movies.Add(new Movie("93. Toy Story 3\nIMDB rating: ", 8.3));
            movies.Add(new Movie("94. Sthe Sting\nIMDB rating: ", 8.3));
            movies.Add(new Movie("95. Toy Story\nIMDB rating: ", 8.3));
            movies.Add(new Movie("96. 3 Idiots\nIMDB rating: ", 8.3));
            movies.Add(new Movie("97. Bicycle Thieves\nIMDB rating: ", 8.3));
            movies.Add(new Movie("98. Inglourious Basterds\nIMDB rating: ", 8.3));
            movies.Add(new Movie("99. The Kid\nIMDB rating: ", 8.3));
            movies.Add(new Movie("100. Snatch\nIMDB rating: ", 8.3));
        }


        public Movie GetRandomMovie()
        {

            Random random = new Random();
            int randomPosition = random.Next(movies.Count);

            Movie randomMovie = new Movie("", 3);

            randomMovie = movies[randomPosition];


            return (randomMovie);


        }






        

    }
}

using Quiz_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game
{
    public class Configuration
    {
        public string Title { get; set; }
        public string ButtonPlay { get; set; }
        public string ButtonOptions { get; set; }
        public string ButtonExit { get; set; }
        public string ButtonSaveConfig { get; set; }
        public string LabelIdioma { get; set; }
        public string LabelDificultad { get; set; }
        public List<string> Difficulty { get; set; }
        public List<Preguntas> preguntas { get; set; }
        public Configuration(string translations)
        {

            if(translations == "spanish")
            {
                Title = "Quiz Game";
                ButtonPlay = "&Jugar";
                ButtonOptions = "&Opciones";
                ButtonExit = "&Salir";
                ButtonSaveConfig = "&Guardar Cambios";
                LabelIdioma = "&Idioma";
                LabelDificultad = "&Dificultad";

                Difficulty = new List<string>
                {
                    "Facil",
                    "Mediano",
                    "Dificil"
                };

                preguntas = new List<Preguntas>
                {
                    new Preguntas{Pregunta = "¿Cuales son las estructuras repetitivas mas comunes?", Opcion1 = "If, Switch,", Opcion2 = "Ninguna De Las Anteriores", Opcion3 = "While, For, Do", Respuesta = 3},
                    new Preguntas{Pregunta = "¿Cual es la importancia de definir el tipo de funcion main?", Opcion1 = "La función main sirve como punto de partida para la ejecución del programa", Opcion2 = "Es un modismo llamar la primera funcion como main", Opcion3 = "Si o si lo requiere el programa para inicializarlo", Respuesta = 1}
                };
            }
            else
            {
                Title = "Quiz Game";
                ButtonPlay = "&Play";
                ButtonOptions = "&Options";
                ButtonExit = "&Exit";
                ButtonSaveConfig = "&Save Changes";
                LabelIdioma = "&Idiom";
                LabelDificultad = "&Difficulty";

                Difficulty = new List<string>
                {
                    "Easy",
                    "Medium",
                    "Hard"
                };
            }
            

        }

    }
}

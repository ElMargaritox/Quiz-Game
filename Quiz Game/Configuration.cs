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
            }
            

        }

    }
}

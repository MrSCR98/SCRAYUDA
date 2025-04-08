using System;

namespace Oxide.Plugins
{
	[Info("SCRAYUDA", "SCR98", 0.1)]
	[Description("TEXTO DE AYUDA DE COMANDOS")]
	public class SCRAYUDA : RustPlugin
	{
		private const string NewLine = "\n";
		
		[ChatCommand("ayuda")]
		void Mensaje(BasePlayer scr) 
		{
			SendMessage(scr, string.Join(NewLine, new[]
			{
				"- Bienvenidos al servidor de SCR98",
				"- Servidor con el cual disfrutaras de RUST.",
				"- Los comandos que podras utilizar seran los siguientes.",
                "- Para saber mas sobre los comandos escriba /comandos "
            }));
		}

        [ChatCommand("comandos")]
        void Mensaje(BasePlayer scr)
        {
            SendMessage(scr, string.Join(NewLine, new[]
            {
                "- EDITE ESTO A SU MANERA.",
                "- PONIENDO LO QUE QUIERA.",
                "- Y AÑADIENDO MAS LINEAS.",
                "- PERO PONGA LA COMA AL.",
                "- FINAL DE LAS COMILLAS.",
                "- EXCEPTO LA ULTIMA LINEA.",
                "- DE TODAS EJEMPLO EJEMPLO.",
                "- EJEMPLO EJEMPLO EJEMPLO.",
                "- EJEMPLO EJEMPLO EJEMPLO.",
                "- EJEMPLO EJEMPLO EJEMPLO.",
                "- EJEMPLO EJEMPLO EJEMPLO."
            }));
        }

        /*
        
        [ChatCommand("EJEMPLO")]
        void Mensaje(BasePlayer scr)
        {
            SendMessage(scr, string.Join(NewLine, new[]
            {
                "- Y AÑADIENDO MAS LINEAS.",
                "- Y AÑADIENDO MAS LINEAS."
            }));
        }

        */

        /*
        [ChatCommand("EJEMPLO")]
        void Mensaje(BasePlayer scr)
        {
            SendMessage(scr, string.Join(NewLine, new[]
            {
                "- CON UNA SOLA LINEA."
            }));
        }
        */

        void SendMessage(BasePlayer scr, string msg, params object[] args)
		{
			PrintToChat(scr, msg, args);
		}

		void Brodcast(string msg, params object[] args) 
		{
			PrintToChat(msg, args);
		}

		void Loaded() 
		{
			PrintToChat("El plugin de /ayuda a cargado correctamente.");
		}
	
	}
}
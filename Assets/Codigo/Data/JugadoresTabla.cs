using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class JugadoresTabla
{
    public List<JugadorData> jugadores;

    public JugadoresTabla(List<JugadorData> jugadores)
    {
        this.jugadores = jugadores;
    }
}

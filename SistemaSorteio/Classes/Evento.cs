using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSorteio
{
    class Evento
    {
        String nome;
        int tipoSorteio; // 1-entre participantes / 2-itens para participantes
        List<Participante> participantes;
        List<Item> itens;
    }
}

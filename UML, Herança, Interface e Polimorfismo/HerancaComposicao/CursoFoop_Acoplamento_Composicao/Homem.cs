﻿using System;

namespace CursoFoop_Acoplamento_Composicao
{
    class Homem
    {
        Animal homem = new Animal();
        ComportamentoAndar andar = new ComportamentoAndar();
        public void Ola()
        {
            Console.WriteLine("olá...");
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cochinitoDeDulce.Views
{
    public interface IInicioView
    {
        bool Suscrito { get; set; }
        void Show();
    }
}

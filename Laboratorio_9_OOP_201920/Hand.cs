﻿using Laboratorio_9_OOP_201920.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_9_OOP_201920
{
    [Serializable]
    public class Hand : Deck
    {

        public Hand()
        {
            base.Cards = new List<Card>();
        }

        
    }
}

using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{

    public interface ICarBuilder
    {
        
        void SetSeats();

        void SetEngine();

        void SetColor();

        void SetTires();

        
    }
}
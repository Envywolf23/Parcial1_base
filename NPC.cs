using System;

namespace Parcial1_logic.OOP
{
    public class NPC : ICharacter
    {       



            public MovementType Move(MovementType Movimiento)
            {

            MovementType resultado = new MovementType();

            resultado = MovementType.Waypoint;

            Console.WriteLine("Mi movimiento es = " + resultado);

            return resultado;


            }
     

    }
}
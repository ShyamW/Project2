using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICharacter
    {
        string CharacterClass { get; }
        string Name { get; }
        int Health { get; }
        void PerformAttack { ICharater target; }

        void RecieveAttack { int damage; }

      
    }
}

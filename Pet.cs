using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public abstract class Pet
    {

        public virtual string Name { get; set; }
        public virtual string Species { get; set; }
        public virtual string Color { get; set; }
        public virtual int Hunger { get; set; }
        public virtual int Boredom { get; set; }
        public virtual int Health { get; set; }

        public abstract void Feed();
        public abstract void SeeDoctor();
        public abstract void Play();
    }

}

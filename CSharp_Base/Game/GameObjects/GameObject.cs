using System;

namespace Game.GameObjects
{
    public abstract class GameObject
    {
        public string Name { get; set; }
        public virtual void Interaction(GameObject obj)
        {
            Console.WriteLine("Interaction: {0} => {1}", Name, obj.Name);
        }
    }
}

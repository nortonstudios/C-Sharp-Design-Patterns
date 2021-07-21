using System;

namespace StarbuzzLibrary
{
    public abstract class Beverage
    {
        protected string description = "Unknown beverage";
        protected string size = "Medium";

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual string GetSize()
        {
            return size;
        }

        protected virtual void SetSize(string newSize)
        {
            size = newSize;
        }

        public virtual void MakeLarge()
        {
            size = "Large";
        }

        public virtual void MakeMedium()
        {
            size = "Medium";
        }

        public virtual void MakeSmall()
        {
            size = "Small";
        }

        public abstract double Cost();

    }
}

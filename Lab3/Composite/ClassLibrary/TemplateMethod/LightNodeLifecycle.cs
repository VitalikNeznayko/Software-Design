using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.TemplateMethod
{
    public abstract class LightNodeLifecycle 
    {
        public void Render()
        {
            OnCreated();
            OnInserted();
            OnStylesApplied();
            OnClassListApplied();
            OnTextRendered();
            OnRemoved();
        }
        protected virtual void OnCreated() => Console.WriteLine("Елемент створено.");
        protected virtual void OnInserted() => Console.WriteLine("Елемент вставлено.");
        protected virtual void OnRemoved() => Console.WriteLine("Елемент видалено.");
        protected virtual void OnStylesApplied() => Console.WriteLine("Стилі застосовано.");
        protected virtual void OnClassListApplied() => Console.WriteLine("Класи застосовано.");
        protected virtual void OnTextRendered() => Console.WriteLine("Текст відображено.");
    }
}
namespace ClassLibrary.TemplateMethod
{
    public class LightElementLifecycle : LightNodeLifecycle
    {
        
        protected override void OnCreated()
        {
            Console.WriteLine("[Element] Елемент створено.");
        }

        protected override void OnInserted()
        {
            Console.WriteLine("[Element] Елемент вставлено до DOM.");
        }

        protected override void OnStylesApplied()
        {
            Console.WriteLine("[Element] CSS стилі застосовано.");
        }

        protected override void OnClassListApplied()
        {
            Console.WriteLine("[Element] Список класів оновлено.");
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine("[Element] Текст успішно відображено.");
        }

        protected override void OnRemoved()
        {
            Console.WriteLine("[Element] Елемент видалено з DOM.");
        }
    }
}

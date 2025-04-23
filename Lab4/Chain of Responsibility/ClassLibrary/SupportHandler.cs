namespace ClassLibrary
{
    abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNext(SupportHandler next)
        {
            nextHandler = next;
        }

        public virtual void HandleRequest(UserRequest request)
        {
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Вибачте, ми не змогли знайти відповідний рівень підтримки для вашого запиту.");
                Console.WriteLine("Спробуйте ще раз.\n");
                request.Restart();
            }
        }
    }
}

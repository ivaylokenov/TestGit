namespace TasksBehindTheScenes
{
    using System;

    public class EventBasedApi
    {
        public event Action<string> OnDone = s => { };

        public void Work()
        {
            Console.WriteLine("Working...");

            var end = DateTime.Now.AddSeconds(5);

            while (true)
            {
                if (DateTime.Now > end)
                {
                    break;
                }
            }

            Console.WriteLine("Done...");

            this.OnDone("Data");
        }
    }
}
